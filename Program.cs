﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Enums;
using TrackerLibrary;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize Database Connection.

            GlobalConfig.InitializeConnection(DatabaseType.TextFile);

            Application.Run(new CreateTeamForm());
            //Application.Run(new TournamentDashboardForm());
        }
    }
}
