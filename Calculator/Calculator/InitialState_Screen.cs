using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator
{
    public partial class InitialState_Screen : Form
    {
        public InitialState_Screen(bool war)
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(Amount.Text, out float a))
            {
                MessageBox.Show("Введено неверное значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            File.WriteAllText(@"CurrentStateList.txt", a.ToString() + "\r\n" + '0' + "\r\n");
            CurrentState_Screen CSS = new CurrentState_Screen();
            CSS.Show();
            CSS.Location = this.Location;
            CSS.Size = this.Size;
            this.Visible = false;
        }

        private void InitialState_Screen_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
