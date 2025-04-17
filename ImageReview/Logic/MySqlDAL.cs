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
        User ID={1};Allow User Variables=True;Persist Security Info=True;Password={2};
        SslMode=None;AllowPublicKeyRetrieval=true; ", Utilis.dbServer, Utilis.dbUser, Utilis.dbPwd); } }

        public static MySqlConnection mySqlConnection { get { return new MySqlConnection(ConnString); } }

        public static Task<DataTable> ExecuteDataTable(string Qry)
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(Qry, mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
                    using (DataSet ds = new DataSet())
                    {
                        adpt.Fill(ds);
                        cmd.Connection.Close();
                        return ds.Tables[0];
                    }
                }
            });
        }

        public static Task<int> UpdateMissingLocationInfo(int LogID, int LocationID)
        {
            return Task.Run(() =>
            {
                string Qry = string.Format(@"update tbl_correction_log set location_id = {1} where id = {0};",
                       LogID, LocationID);

                using (MySqlCommand cmd = new MySqlCommand(Qry, mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    int rec = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return rec;
                }
            });
        }

        public static Task<string> AuthenticateSystemUser(string UserName, string Password)
        {
            return Task.Run(() =>
            {
                string HashPassword = Utilis.GetHashString(Password);

                using (MySqlCommand cmd = new MySqlCommand(
                  string.Format(@"select ID,ifnull(type,'user')user_type,IFNULL(isarabic,0)IsArabic from tbl_users 
                        where username='{0}' and password='{1}' ", UserName, HashPassword), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    string userType = "";
                    if (reader.Read())
                    {
                        userType = reader["user_type"].ToString().ToLower();
                        Utilis.UserID = Convert.ToInt32(reader["id"]);
                        Utilis.IsArabicUser = Convert.ToInt32(reader["IsArabic"]) == 1;
                    }

                    cmd.Connection.Close();
                    return userType;
                }
            });
        }

        public static Task AddLoginActivity()
        {
            return Task.Run(() =>
            {
                //delete any active folder for that user, if there is any
                //insert login activity log
                //insert new session to active folder
                //return login id
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
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                        Utilis.LoginID = Convert.ToInt32(reader["LoginID"]);

                    cmd.Connection.Close();
                }
            });
        }

        public static Task<int> UpdateLoginActivity()
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    string.Format(@"UPDATE tbl_login_activity SET logout_time= NOW() WHERE id={0};
                    DELETE from tbl_active_folder WHERE login_id = {0}; ",
                    Utilis.LoginID), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    int rec = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return rec;
                }
            });
        }

        public static Task<int> UpdateCurrentFolder(string folderName)
        {
            return Task.Run(() =>
            {
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
                    cmd.Connection.Open();
                    int rec = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return rec;
                }
            });
        }

        public static Task<int> ClearCurrentFolders()
        {
            return Task.Run(() =>
            {
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
                    cmd.Connection.Open();
                    int rec = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return rec;
                }
            });
        }

        public static Task<List<string>> GetCurrentFolders()
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    string.Format(@"select folder_name from tbl_active_folder where folder_name<>''
                    UNION ALL 
                    SELECT NAME AS folder_name FROM tbl_error_folders;"), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    List<string> lst = new List<string>();
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        lst.Add(reader["folder_name"].ToString());

                    cmd.Connection.Close();
                    return lst;
                }
            });
        }

        public static Task<List<int>> GetIgnoreAccessPoints()
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    string.Format(@"SELECT access_point_id FROM tbl_ignore_access_point;"), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    List<int> lst = new List<int>();
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        lst.Add(Convert.ToInt32(reader["access_point_id"]));

                    cmd.Connection.Close();
                    return lst;
                }
            });
        }

        public static Task<List<int>> GetSalikLocations()
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    string.Format(@"select location_id from tbl_salik_locations;"), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    List<int> lst = new List<int>();
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        lst.Add(Convert.ToInt32(reader["location_id"]));

                    cmd.Connection.Close();
                    return lst;
                }
            });
        }

        public static Task<List<Reason>> GetReasons()
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    string.Format(@"SELECT id,NAME FROM tbl_reasons ORDER BY name;"), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    List<Reason> lst = new List<Reason>();
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        lst.Add(new Reason()
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString()
                        });
                    }
                    cmd.Connection.Close();
                    return lst;
                }
            });
        }

        public static Task<int> ChangeSystemUserPassword(string UserName, string Password)
        {
            return Task.Run(() =>
            {
                string HashPassword = Utilis.GetHashString(Password);
                using (MySqlCommand cmd = new MySqlCommand(
                    string.Format("update tbl_users set password='{0}' where username='{1}'",
                    HashPassword, UserName), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    int rec = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return rec;
                }
            });
        }

        public static Task<int> MakeUserIdle()
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    string.Format(@"UPDATE tbl_active_folder SET IsIdle =1,Folder_Name='',UpdateAddTime=NOW() where Login_ID={0}",
                    Utilis.LoginID), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    int rec = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Connection.Close();
                    return rec;
                }
            });
        }

        public static Task<LoginIDAndUserCount> GetPriorityLoginID()
        {
            return Task.Run(() =>
            {
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
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    LoginIDAndUserCount lu = new LoginIDAndUserCount();
                    if (reader.Read())
                    {
                        lu.LoginID = Convert.ToInt32(reader["LoginID"]);
                        lu.UsersCount = Convert.ToInt32(reader["UsersCount"]);
                    }
                    cmd.Connection.Close();
                    return lu;
                }
            });
        }

        public static Task<CorrectionLog> GetForwardedDetail(string TransID)
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(
                    string.Format(@"SELECT IFNULL(cl.reason_id,0)ReasonID,cl.User_Remarks,IFNULL(u.Username,'')UserName
                    FROM tbl_correction_log cl 
                    LEFT OUTER JOIN tbl_users u ON cl.User_ID=u.id
                    WHERE cl.transaction_id = '{0}' AND cl.Action_Type=3", TransID), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    CorrectionLog cl = new CorrectionLog();
                    if (reader.Read())
                    {
                        cl.ReasonID = Convert.ToInt32(reader["ReasonID"]);
                        cl.UserRemarks = reader["User_Remarks"].ToString();
                        cl.UserName = reader["UserName"].ToString();
                    }
                    cmd.Connection.Close();
                    return cl;
                }
            });
        }

        public static Task<int> AddUpdateSystemUser(SystemUser usr)
        {
            return Task.Run(() =>
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

                using (MySqlCommand cmd = new MySqlCommand(Qry, mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    int rec = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return rec;
                }
            });
        }

        public static Task<List<SystemUser>> GetCashiersList()
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(@"select ID,userName,type from tbl_users order by username;", mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    List<SystemUser> cashiers = new List<SystemUser>();
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cashiers.Add(new SystemUser(Convert.ToInt32(reader["ID"]),
                            reader["userName"].ToString(),
                            reader["type"].ToString(), ""));
                    }

                    cmd.Connection.Close();
                    return cashiers;
                }
            });
        }

        public static Task<bool> IsValidCashierName(int CashierID, string CashierName)
        {
            return Task.Run(() =>
            {
                //spCashier_IsValidUserName
                using (MySqlCommand cmd = new MySqlCommand(string.Format(@"select count(ID) from tbl_users where userName='{1}' and {0} <> ID;",
                    CashierID, CashierName), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    int rec = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Connection.Close();
                    return rec == 0;
                }
            });
        }

        public static Task<int> AddCorrectionLog(CorrectionLog log)
        {
            return Task.Run(() =>
            {
                string Qry = string.Format(@"insert into tbl_correction_log(User_ID,User_Remarks,Action_Type,Login_ID,
                Location_ID,Access_Point_ID,IsExit,Transaction_ID,Event_DateTime,
                Captured_Code,Captured_PlateNo,Captured_City,Corrected_Code,Corrected_PlateNo,Corrected_City,ANPR_Message,
                FolderName,PlateRead_Time,Created_At,Reason_ID,trigger_type,is_backward,direction)
                values({0},'{1}',{2},{3},{4},{6},{8},'{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}',
                '{18}','{19}','{20}',{21},{22},{23},'{24}');

                UPDATE tbl_active_folder SET IsIdle =1,Folder_Name='' where Login_ID={3};",

                log.UserID, log.UserRemarks, log.ActionType, log.LoginID, log.LocationID, "",
                log.AccessPointID, "", log.IsExit, log.TransactionID, log.EventDateTime, log.CapturedCode,
                log.CapturedPlateNo, log.CapturedCity, log.CorrectedCode, log.CorrectedPlateNo, log.CorrectedCity, log.ANPRMsg,
                log.FolderName, log.PlateReadTime, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), log.ReasonID,

                log.TriggerType, log.IsBackWard, log.Direction);

                using (MySqlCommand cmd = new MySqlCommand(Qry, mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    int rec = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return rec;
                }
            });
        }

        public static Task<int> InsertFalseTriggeringData(List<FalseTrigger> lst)
        {
            return Task.Run(() =>
            {
                string qry = string.Format(@"INSERT INTO tbl_false_trigger_data (accesspoint_id, event_date, folder_name) VALUES ");

                foreach (FalseTrigger ft in lst)
                    qry = string.Format("{0} ({1},'{2}','{3}'),", qry, ft.AccessPointID, ft.EventDate, ft.FolderName);
                qry = qry.Substring(0, qry.Length - 1);

                using (MySqlCommand cmd = new MySqlCommand(qry, mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    int rec = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return rec;
                }
            });
        }

        public static Task<List<FalseTrigger>> GetFalseTriggeringData()
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(@"sp_get_false_triggers", mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    List<FalseTrigger> ft = new List<FalseTrigger>();
                    cmd.Connection.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ft.Add(new FalseTrigger()
                        {
                            EventDate = reader["EventTime"].ToString(),
                            AccessPointID = Convert.ToInt32(reader["accesspoint_id"]),
                            NoOfTrigger = Convert.ToInt32(reader["NoOfTrigger"]),
                            AccessPointName = "",
                            LocationName = ""
                        });
                    }

                    cmd.Connection.Close();
                    return ft;
                }
            });
        }

        public static Task<List<string>> GetFalseTriggerFolders(int AccessPointID, string EventTime)
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(string.Format(@"SELECT ifnull(folder_name,'')folder_name
                FROM tbl_false_trigger_data WHERE accesspoint_id={0} 
                AND DATE_FORMAT(event_date, '%Y-%m-%d %H:%i') ='{1}' ", AccessPointID, EventTime), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    List<string> ft = new List<string>();
                    cmd.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                        ft.Add(reader["folder_name"].ToString());
                    cmd.Connection.Close();
                    return ft;
                }
            });
        }

        public static Task<int> UpdateFalseTriggersToSeen(int AccessPointID, string EventTime)
        {
            return Task.Run(() =>
            {
                using (MySqlCommand cmd = new MySqlCommand(string.Format(@"update tbl_false_trigger_data SET is_seen=1
                WHERE accesspoint_id={0} AND DATE_FORMAT(event_date, '%Y-%m-%d %H:%i') ='{1}' ", AccessPointID, EventTime), mySqlConnection)
                {
                    CommandType = CommandType.Text
                })
                {
                    cmd.Connection.Open();
                    int rec = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return rec;
                }
            });
        }
    }
}
