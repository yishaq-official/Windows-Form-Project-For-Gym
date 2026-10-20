using System;
using System.Windows.Forms;
using GymMembershipSystem.Data;

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

            Application.Run(new Form1());
        }
    }
}