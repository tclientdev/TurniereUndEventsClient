using System;
using System.Windows.Forms;

namespace Turniere_und_Events_Client
{
    public partial class settings_window : Form
    {
        public settings_window()
        {
            InitializeComponent();
        }

        private void settings_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;    // Do not close the form.
        }

        changelog_window thirdForm = new changelog_window();
        private void changelog_button_Click(object sender, EventArgs e)
        {
            thirdForm.Show();
        }
    }
}
