using ImageReview.UI;
using System;
using System.Windows.Forms;
using System.Threading;
using ImageReview.Logic;

namespace ImageReview
{
    static class Program
    {
        private static Mutex mutex = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                const string appName = "ImageReviewApp";
                bool createdNew;
                mutex = new Mutex(true, appName, out createdNew);

                if (!createdNew)
                {
                    string message = "There is already Image Review application is running.\nPlease close that application before starting a new one.";
                    MessageBox.Show(message, "Application is already running", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(0);
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new frmLogin1());
                }
            }
            catch (Exception ee)
            {
                LogFile.UpdateLogFile(string.Format("Error Main : {0}", ee.Message));
            }
        }
    }
}
