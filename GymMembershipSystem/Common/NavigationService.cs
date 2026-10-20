using System;
using System.Windows.Forms;

namespace GymMembershipSystem.Common
{
    /// <summary>
    /// Coordinates dynamic user control view swapping inside the main shell content host.
    /// </summary>
    public class NavigationService
    {
        private readonly Panel _contentHost;
        private UserControl? _currentControl;

        public NavigationService(Panel contentHost)
        {
            _contentHost = contentHost ?? throw new ArgumentNullException(nameof(contentHost));
        }

        /// <summary>
        /// Loads a new UserControl view into the content host panel.
        /// </summary>
        public void NavigateTo(UserControl viewControl)
        {
            if (viewControl == null) throw new ArgumentNullException(nameof(viewControl));

            _contentHost.SuspendLayout();

            // Clear previous controls
            if (_currentControl != null)
            {
                _contentHost.Controls.Remove(_currentControl);
                // Note: caller or host can determine if controls are reused or disposed
            }

            viewControl.Dock = DockStyle.Fill;
            _contentHost.Controls.Add(viewControl);
            viewControl.BringToFront();
            _currentControl = viewControl;

            _contentHost.ResumeLayout(true);
        }

        public UserControl? CurrentView => _currentControl;
    }
}
