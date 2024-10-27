using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Utils.Database;
using View.Forms;

namespace View
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var connectionString =
                "Server=localhost;Port=5433;Database=sql_cleaning;User Id=postgres;Password=";

            Database database = null;
            try
            {
                database = new Database(connectionString);
                database.OpenConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }


            Application.Run(
                new MainForm
                (
                    database
                )
            );
        }
    }
}