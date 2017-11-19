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
    public partial class Planning_Screen : Form
    {
        public Planning_Screen()
        {
            InitializeComponent();
        }

        private void CurrentState_Click(object sender, EventArgs e)
        {
            CurrentState_Screen CSS = new CurrentState_Screen();
            CSS.Show();
            CSS.Location = this.Location; //чтобы окно открывалось в том же месте, где и окно, с которого совершён переход
            CSS.Size = this.Size; //то же для размеров
            this.Visible = false;
        }

        private void History_Click(object sender, EventArgs e)
        {
            History_Screen HS = new History_Screen();
            HS.Show();
            HS.Location = this.Location; 
            HS.Size = this.Size; 
            this.Visible = false;
        }

        private void PlanningList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Subtract_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {

        }

        private void Planning_Screen_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
