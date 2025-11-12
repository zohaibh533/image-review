using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace ImageReview.Logic
{
    public static class MySqlDAL
    {
        private static string ConnString { get { return string.Format(@"Data Source={0};Initial Catalog=db_imagereview;
        User ID={1};Allow User Variables=True;Persist Security Info=True;Password={2};Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=300;
        SslMode=None;AllowPublicKeyRetrieval=true; ", Utilis.dbServer, Utilis.dbUser, Utilis.dbPwd); } }

        private static string ConnString119 { get { return string.Format(@"Data Source={0};Initial Catalog=db_master_parkonic_api;
        User ID={1};Allow User Variables=True;Persist Security Info=True;Password={2};Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=300;
        SslMode=None;AllowPublicKeyRetrieval=true; ", "192.168.1.19", "cashier", "@Cashier123"); } }

        public static async Task<DataTable> ExecuteDataTable(string Qry)
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (var cmd = new MySqlCommand(Qry, mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();

                using (var adpt = new MySqlDataAdapter(cmd))
                using (var ds = new DataSet())
                {
                    adpt.Fill(ds);

                    if (ds.Tables.Count > 0)
                        return ds.Tables[0];
                    else
                        return null; // Or throw an exception / return empty table as per your logic
                }
            }
        }

        public static async Task<int> UpdateMissingLocationInfo(int LogID, int LocationID)
        {

            string Qry = string.Format(@"update tbl_correction_log set location_id = {1} where id = {0};",
                   LogID, LocationID);

            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(Qry, mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                int rec = await cmd.ExecuteNonQueryAsync();
                return rec;
            }
        }

        public static async Task<string> AuthenticateSystemUser(string UserName, string Password)
        {

            string HashPassword = Utilis.GetHashString(Password);

            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
              string.Format(@"select ID,ifnull(type,'user')user_type,IFNULL(isarabic,0)IsArabic,
                        IFNULL((SELECT app_version FROM tbl_misc LIMIT 1),'')AppVersion            
                        from tbl_users where username='{0}' and password='{1}' ", UserName, HashPassword), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    string userType = "";
                    if (await reader.ReadAsync())
                    {
                        userType = reader["user_type"].ToString().ToLower();
                        Utilis.UserID = Convert.ToInt32(reader["id"]);
                        Utilis.AppVersion = reader["AppVersion"].ToString();
                        Utilis.IsArabicUser = Convert.ToInt32(reader["IsArabic"]) == 1;
                    }
                    return userType;
                }
            }
        }

        public static async Task AddLoginActivity()
        {
            //delete any active folder for that user, if there is any
            //insert login activity log
            //insert new session to active folder
            //return login id
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
            string.Format(@"
                delete FROM tbl_active_folder WHERE login_id IN (SELECT id FROM tbl_login_activity WHERE user_id={0});
                INSERT INTO tbl_login_activity (USER_id,login_time,system_ip) VALUES({0},NOW(),'{1}');
                INSERT into tbl_active_folder (login_id) VALUES(LAST_INSERT_ID());
                select LAST_INSERT_ID() AS LoginID; ", Utilis.UserID, Utilis.GetLocalIPAddress()), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                        Utilis.LoginID = Convert.ToInt32(reader["LoginID"]);
                }
            }
        }

        public static int UpdateLoginActivity()
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format(@"UPDATE tbl_login_activity SET logout_time= NOW() WHERE id={0};
                    DELETE from tbl_active_folder WHERE login_id = {0}; ",
                Utilis.LoginID), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                mySqlConnection.Open();
                int rec = cmd.ExecuteNonQuery();
                return rec;
            }
        }

        public static async Task<int> UpdateCurrentFolder(string folderName)
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format(@"UPDATE tbl_active_folder af 
                JOIN (
                    SELECT IFNULL(MAX(batch_no), 0) AS max_batch_no
                    FROM tbl_active_folder f
                    LEFT OUTER JOIN tbl_login_activity la ON la.ID=f.Login_ID
                    LEFT OUTER JOIN tbl_users u ON u.ID=la.User_ID
                    WHERE u.type='{2}'
                ) t ON 1=1
                    SET folder_name='{1}',IsIdle=0,
                    UpdateAddTime=now(),af.Batch_No=(IFNULL(af.Batch_No, t.max_batch_no)+1) 
                    WHERE af.login_id={0}; ",
                Utilis.LoginID, folderName, Utilis.UserType), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                int rec = await cmd.ExecuteNonQueryAsync();
                return rec;
            }
        }

        public static async Task<int> ClearCurrentFolders()
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            //clear the folder data if its there for more than 2 mints
            //clear the login session if no activity for 10 mints
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format(@"UPDATE tbl_active_folder SET folder_name = '' 
                    where TIMESTAMPDIFF(SECOND, UpdateAddTime, NOW()) > 120;
                    DELETE from tbl_active_folder where TIMESTAMPDIFF(minute, UpdateAddTime, NOW()) > 10;

                    UPDATE tbl_active_folder SET IsIdle =1,Folder_Name='' where Login_ID={0};
                    ", Utilis.LoginID), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                int rec = await cmd.ExecuteNonQueryAsync();
                return rec;
            }
        }

        public static async Task<List<string>> GetCurrentFolders()
        {
            const string query = @"
            SELECT folder_name FROM tbl_active_folder WHERE folder_name <> ''
            UNION ALL
            SELECT NAME AS folder_name FROM tbl_error_folders
			UNION ALL 
			SELECT foldername AS folder_name FROM tbl_correction_log WHERE created_at>= DATE_SUB(NOW(), INTERVAL 15 second);";

            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                List<string> lst = new List<string>();
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                        lst.Add(reader["folder_name"].ToString());
                }
                return lst;
            }
        }

        public static async Task<List<int>> GetIgnoreAccessPoints()
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format(@"SELECT access_point_id FROM tbl_ignore_access_point;"), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                List<int> lst = new List<int>();
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                        lst.Add(Convert.ToInt32(reader["access_point_id"]));
                }
                return lst;
            }
        }

        public static async Task<List<int>> GetSalikLocations()
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format(@"select location_id from tbl_salik_locations where isvalid=1;"), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                List<int> lst = new List<int>();
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                        lst.Add(Convert.ToInt32(reader["location_id"]));
                }
                return lst;
            }
        }

        public static async Task<List<int>> GetIgnoreDirectionAP()
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format(@"select ap_id from tbl_ignore_direction;"), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                List<int> lst = new List<int>();
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                        lst.Add(Convert.ToInt32(reader["ap_id"]));
                }
                return lst;
            }
        }

        public static async Task<List<int>> GetLocalVerificationLocations()
        {
            using (var mySqlConnection = new MySqlConnection(ConnString119))
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format(@"SELECT location_id FROM tbl_location_sync WHERE isverification=1"), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                List<int> lst = new List<int>();
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                        lst.Add(Convert.ToInt32(reader["location_id"]));
                }
                return lst;
            }
        }

        public static async Task<List<Reason>> GetReasons()
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format(@"SELECT id,NAME FROM tbl_reasons ORDER BY name;"), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                List<Reason> lst = new List<Reason>();
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        lst.Add(new Reason()
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString()
                        });
                    }
                }
                return lst;
            }
        }

        public static async Task<int> ChangeSystemUserPassword(string UserName, string Password)
        {
            string HashPassword = Utilis.GetHashString(Password);
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format("update tbl_users set password='{0}' where username='{1}'",
                HashPassword, UserName), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                int rec = await cmd.ExecuteNonQueryAsync();
                return rec;
            }
        }

        public static async Task<int> MakeUserIdle()
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format(@"UPDATE tbl_active_folder SET IsIdle =1,Folder_Name='',UpdateAddTime=NOW() where Login_ID={0}",
                Utilis.LoginID), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                int rec = await cmd.ExecuteNonQueryAsync();
                return rec;
            }
        }

        public static async Task<LoginIDAndUserCount> GetPriorityLoginID()
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format(@"set @UsersCount = IFNULL((SELECT  COUNT(user_id) 
                    FROM vw_active_folders WHERE TYPE='{0}'),0);

                    SET @LoginID= IFNULL((SELECT af.login_id FROM tbl_active_folder af 
                    LEFT OUTER JOIN tbl_login_activity la ON la.ID=af.Login_ID
                    LEFT OUTER JOIN tbl_users u ON u.ID=la.User_ID
                    WHERE ifnull(af.isidle,1)=1 AND u.type='{0}'
                    ORDER BY ifnull(af.batch_no,0) asc,af.updateaddtime ASC, af.login_id DESC LIMIT 1),0);

                    SELECT IFNULL(@LoginID,0) AS LoginID, IFNULL(@UsersCount,0) as UsersCount;",
                Utilis.UserType), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    LoginIDAndUserCount lu = new LoginIDAndUserCount();
                    if (await reader.ReadAsync())
                    {
                        lu.LoginID = Convert.ToInt32(reader["LoginID"]);
                        lu.UsersCount = Convert.ToInt32(reader["UsersCount"]);
                    }
                    return lu;
                }
            }
        }

        public static async Task<CorrectionLog> GetForwardedDetail(string TransID)
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(
                string.Format(@"SELECT IFNULL(cl.reason_id,0)ReasonID,cl.User_Remarks,IFNULL(u.Username,'')UserName
                    FROM tbl_correction_log cl 
                    LEFT OUTER JOIN tbl_users u ON cl.User_ID=u.id
                    WHERE cl.transaction_id = @TransID AND cl.Action_Type=3"), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                cmd.Parameters.AddWithValue("@TransID", TransID);

                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    CorrectionLog cl = new CorrectionLog();
                    if (await reader.ReadAsync())
                    {
                        cl.ReasonID = Convert.ToInt32(reader["ReasonID"]);
                        cl.UserRemarks = reader["User_Remarks"].ToString();
                        cl.UserName = reader["UserName"].ToString();
                    }
                    return cl;
                }
            }
        }

        public static async Task<int> AddUpdateSystemUser(SystemUser usr)
        {
            string Qry = "";
            string HashPassword = Utilis.GetHashString(usr.Password);
            if (usr.ID == 0)
            {
                Qry = string.Format(@"INSERT INTO tbl_users(username,password,type) 
                    values('{0}','{1}','{2}');", usr.UserName, HashPassword, usr.UserType);
            }
            else
            {
                Qry = string.Format(@"update tbl_users set password = '{1}', type='{2}' where id = {0};",
                    usr.ID, HashPassword, usr.UserType);
            }

            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(Qry, mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                int rec = await cmd.ExecuteNonQueryAsync();
                return rec;
            }
        }

        public static async Task<List<SystemUser>> GetCashiersList()
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(@"select ID,userName,type from tbl_users order by username;", mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                List<SystemUser> cashiers = new List<SystemUser>();
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        cashiers.Add(new SystemUser(Convert.ToInt32(reader["ID"]),
                            reader["userName"].ToString(),
                            reader["type"].ToString(), ""));
                    }

                    return cashiers;
                }
            }
        }

        public static async Task<bool> IsValidCashierName(int CashierID, string CashierName)
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(string.Format(@"select count(ID) from tbl_users where userName='{1}' and {0} <> ID;",
                CashierID, CashierName), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                var result = await cmd.ExecuteScalarAsync();
                int count = Convert.ToInt32(result);
                return count == 0;
            }
        }

        public static async Task<int> AddCorrectionLog(CorrectionLog log)
        {
            //string Qry = string.Format(@"insert into tbl_correction_log(User_ID,User_Remarks,Action_Type,Login_ID,
            //    Location_ID,Access_Point_ID,IsExit,Transaction_ID,Event_DateTime,
            //    Captured_Code,Captured_PlateNo,Captured_City,Corrected_Code,Corrected_PlateNo,Corrected_City,ANPR_Message,
            //    FolderName,PlateRead_Time,Created_At,Reason_ID,trigger_type,is_backward,direction)
            //    values({0},'{1}',{2},{3},{4},{6},{8},'{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}',
            //    '{18}','{19}','{20}',{21},{22},{23},'{24}');

            //    UPDATE tbl_active_folder SET IsIdle =1,Folder_Name='' where Login_ID={3};",

            //log.UserID, log.UserRemarks, log.ActionType, log.LoginID, log.LocationID, "",
            //log.AccessPointID, "", log.IsExit, log.TransactionID, log.EventDateTime, log.CapturedCode,
            //log.CapturedPlateNo, log.CapturedCity, log.CorrectedCode, log.CorrectedPlateNo, log.CorrectedCity, log.ANPRMsg,
            //log.FolderName, log.PlateReadTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), log.ReasonID,

            //log.TriggerType, log.IsBackWard, log.Direction);

            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand()
            {
                CommandType = CommandType.Text
            })
            {
                cmd.Connection = mySqlConnection;
                cmd.CommandText = @"INSERT INTO tbl_correction_log (
                            User_ID, User_Remarks, Action_Type, Login_ID, Location_ID, Access_Point_ID,
                            IsExit, Transaction_ID, Event_DateTime, Captured_Code, Captured_PlateNo, Captured_City,
                            Corrected_Code, Corrected_PlateNo, Corrected_City, ANPR_Message, FolderName, PlateRead_Time,
                            Created_At, Reason_ID, trigger_type, is_backward, direction
                        )
                        VALUES (
                            @UserID, @UserRemarks, @ActionType, @LoginID, @LocationID, @AccessPointID,
                            @IsExit, @TransactionID, @EventDateTime, @CapturedCode, @CapturedPlateNo, @CapturedCity,
                            @CorrectedCode, @CorrectedPlateNo, @CorrectedCity, @ANPRMsg, @FolderName, @PlateReadTime,
                            @CreatedAt, @ReasonID, @TriggerType, @IsBackWard, @Direction
                        );

                        UPDATE tbl_active_folder 
                        SET IsIdle = 1, Folder_Name = '' 
                        WHERE Login_ID = @LoginID;";

                cmd.Parameters.AddWithValue("@UserID", log.UserID);
                cmd.Parameters.AddWithValue("@UserRemarks", log.UserRemarks);
                cmd.Parameters.AddWithValue("@ActionType", log.ActionType);
                cmd.Parameters.AddWithValue("@LoginID", log.LoginID);
                cmd.Parameters.AddWithValue("@LocationID", log.LocationID);
                cmd.Parameters.AddWithValue("@AccessPointID", log.AccessPointID);
                cmd.Parameters.AddWithValue("@IsExit", log.IsExit);
                cmd.Parameters.AddWithValue("@TransactionID", log.TransactionID);
                cmd.Parameters.AddWithValue("@EventDateTime", log.EventDateTime);
                cmd.Parameters.AddWithValue("@CapturedCode", log.CapturedCode);
                cmd.Parameters.AddWithValue("@CapturedPlateNo", log.CapturedPlateNo);
                cmd.Parameters.AddWithValue("@CapturedCity", log.CapturedCity);
                cmd.Parameters.AddWithValue("@CorrectedCode", log.CorrectedCode);
                cmd.Parameters.AddWithValue("@CorrectedPlateNo", log.CorrectedPlateNo);
                cmd.Parameters.AddWithValue("@CorrectedCity", log.CorrectedCity);
                cmd.Parameters.AddWithValue("@ANPRMsg", log.ANPRMsg);
                cmd.Parameters.AddWithValue("@FolderName", log.FolderName);
                cmd.Parameters.AddWithValue("@PlateReadTime", log.PlateReadTime);
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@ReasonID", log.ReasonID);
                cmd.Parameters.AddWithValue("@TriggerType", log.TriggerType);
                cmd.Parameters.AddWithValue("@IsBackWard", log.IsBackWard);
                cmd.Parameters.AddWithValue("@Direction", log.Direction);

                await mySqlConnection.OpenAsync();
                int rec = await cmd.ExecuteNonQueryAsync();
                return rec;
            }
        }

        public static async Task<List<FalseTrigger>> GetFalseTriggeringData(DateTime FromTime, DateTime ToTime,
            List<int> apIDs, int NoOfRecords)
        {

            string apids = "";
            if (apIDs.Count > 0)
                apids = string.Join(",", apIDs);

            string qry = string.Format(@"SELECT accesspoint_id,
                COUNT(accesspoint_id)NoOfTrigger,DATE_FORMAT(event_date, '%Y-%m-%d %H:%i') AS EventTime,
                '' AS LocationName,'' AS AccessPointName,
                GROUP_CONCAT(id ORDER BY id SEPARATOR ',') AS ids
                from tbl_false_trigger_data
                WHERE IFNULL(is_seen, 0) = 0 AND event_date between '{0}' and '{1}' {3}
                GROUP BY accesspoint_id,EventTime
                HAVING COUNT(accesspoint_id) >= {2}
                ORDER BY EventTime desc; ", FromTime.ToString("yyyy-MM-dd HH:mm:ss"), ToTime.ToString("yyyy-MM-dd HH:mm:ss"),
            NoOfRecords, (apIDs.Count > 0 ? string.Format(" and accesspoint_id in ({0}) ", apids) : ""));

            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(qry, mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                List<FalseTrigger> ft = new List<FalseTrigger>();
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        ft.Add(new FalseTrigger()
                        {
                            EventDate = reader["EventTime"].ToString(),
                            AccessPointID = Convert.ToInt32(reader["accesspoint_id"]),
                            NoOfTrigger = Convert.ToInt32(reader["NoOfTrigger"]),
                            AccessPointName = "",
                            LocationName = "",
                            ids = reader["ids"].ToString()
                        });
                    }
                }

                return ft;
            }
        }


        public static async Task<List<FalseTrigger>> GetFalseTriggeringData()
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(@"sp_get_false_triggers", mySqlConnection))
            {
                List<FalseTrigger> ft = new List<FalseTrigger>();
                await mySqlConnection.OpenAsync();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        ft.Add(new FalseTrigger()
                        {
                            EventDate = reader["EventTime"].ToString(),
                            AccessPointID = Convert.ToInt32(reader["accesspoint_id"]),
                            NoOfTrigger = Convert.ToInt32(reader["NoOfTrigger"]),
                            AccessPointName = "",
                            LocationName = "",
                            ids = reader["ids"].ToString()
                        });
                    }
                }
                return ft;
            }
        }

        public static async Task<List<string>> GetFalseTriggerFolders(int AccessPointID, string EventTime)
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(string.Format(@"SELECT ifnull(folder_name,'')folder_name
                FROM tbl_false_trigger_data WHERE accesspoint_id={0} 
                AND DATE_FORMAT(event_date, '%Y-%m-%d %H:%i') ='{1}' ", AccessPointID, EventTime), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                List<string> ft = new List<string>();
                await mySqlConnection.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                        ft.Add(reader["folder_name"].ToString());
                }
                return ft;
            }
        }

        public static async Task<int> UpdateFalseTriggersToSeen(string ids)
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(string.Format(@"update tbl_false_trigger_data SET is_seen=1
                WHERE id in ({0}); ", ids), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                int rec = await cmd.ExecuteNonQueryAsync();
                return rec;
            }
        }

        public static async Task<int> UpdateFalseTriggersToSeen(int AccessPointID, string EventTime)
        {
            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(string.Format(@"update tbl_false_trigger_data SET is_seen=1
                WHERE accesspoint_id={0} AND DATE_FORMAT(event_date, '%Y-%m-%d %H:%i') ='{1}' ", AccessPointID, EventTime), mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                int rec = await cmd.ExecuteNonQueryAsync();
                return rec;
            }
        }

        public static async Task<int> AddSalikLocation(int LocationID)
        {
            string Qry = $"insert into tbl_salik_locations (location_id,isvalid) values ({LocationID},1);";

            using (var mySqlConnection = new MySqlConnection(ConnString))
            using (MySqlCommand cmd = new MySqlCommand(Qry, mySqlConnection)
            {
                CommandType = CommandType.Text
            })
            {
                await mySqlConnection.OpenAsync();
                int rec = await cmd.ExecuteNonQueryAsync();
                return rec;
            }
        }
    }
}
