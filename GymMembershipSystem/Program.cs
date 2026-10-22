using System;
using System.Windows.Forms;
using GymMembershipSystem.Data;
using GymMembershipSystem.Forms.Auth;
using GymMembershipSystem.Forms.Dashboard;

namespace GymMembershipSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Seed Phase 1 in-memory repository with realistic demonstration records
            DataSeeder.Seed(InMemoryDataStore.Instance);

            // Authentication & Application Shell Lifecycle Loop
            while (true)
            {
                using var loginForm = new LoginForm();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    // User canceled or closed the login window -> exit application
                    break;
                }

                using var mainForm = new MainForm();
                Application.Run(mainForm);

                // If user signed out (DialogResult == Retry), loop back to login dialog
                if (mainForm.DialogResult != DialogResult.Retry)
                {
                    break;
                }
            }
        }
    }
}