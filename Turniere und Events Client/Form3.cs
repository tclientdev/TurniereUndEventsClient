using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turniere_und_Events_Client
{
    public partial class changelog_window : Form
    {
        public changelog_window()
        {
            InitializeComponent();
        }

        private void changelog_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;    // Do not close the form.
        }
    }
}
