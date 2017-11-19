using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class InitialState_Screen : Form
    {
        public InitialState_Screen()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            CurrentState_Screen CSS = new CurrentState_Screen();
            CSS.Show();
            CSS.Location = this.Location;
            CSS.Size = this.Size;
            this.Visible = false;
        }
    }
}
