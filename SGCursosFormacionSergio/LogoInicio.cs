using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCursosFormacionSergio
{
    public partial class LogoInicio : Form
    {
        public LogoInicio()
        {
            InitializeComponent();
        }

        private void LogoInicio_Shown(object sender, EventArgs e)
        {
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Stop();
            Form1 frmPrincipal = new Form1();
            frmPrincipal.Show();
            this.Hide();
        }
    }
}
