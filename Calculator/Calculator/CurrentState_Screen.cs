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
    public partial class CurrentState_Screen : Form
    {
        public CurrentState_Screen()
        {
            InitializeComponent();
        }

        private void CurrentState_Click(object sender, EventArgs e)
        {

        }

        private void History_Click(object sender, EventArgs e)
        {
            History_Screen HS = new History_Screen();
            HS.Show();
            HS.Location = this.Location;  //чтобы окно открывалось в том же месте, где и окно, с которого совершён переход
            HS.Size = this.Size; //то же для размеров
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

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Subtract_Click(object sender, EventArgs e)
        {

        }

        private void CurrentStateList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CurrentState_Screen_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
