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
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }
        settings_window secondForm = new settings_window();
        private void settings_button_Click(object sender, EventArgs e)
        {
            secondForm.Show();
        }
    }
}
