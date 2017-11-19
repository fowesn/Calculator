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
    public partial class History_Record_Screen : Form
    {
        public History_Record_Screen()
        {
            InitializeComponent();
        }

        private void CurrentState_Click(object sender, EventArgs e)
        {
            CurrentState_Screen CSS = new CurrentState_Screen();
            CSS.Show();
            CSS.Location = this.Location;
            CSS.Size = this.Size;
            this.Visible = false;
        }

        private void Planning_Click(object sender, EventArgs e)
        {
            Planning_Screen PS = new Planning_Screen();
            PS.Show();
            PS.Location = this.Location;
            PS.Size = this.Size;
            this.Visible = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            History_Screen HS = new History_Screen();
            HS.Show();
            HS.Location = this.Location;
            HS.Size = this.Size;
            this.Visible = false;
        }

        private void History_Record_Screen_Closed(object sender, FormClosedEventArgs e)
        {
            History_Screen HS = new History_Screen();
            HS.Show();
            HS.Location = this.Location;
            HS.Size = this.Size;
            this.Visible = false;
        }
    }
}
