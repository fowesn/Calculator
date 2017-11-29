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
        public InitialState_Screen()
        {
            InitializeComponent();
            Today.Text = DateTime.Today.ToShortDateString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(Amount.Text, out float a) || a < 0)
            {
                MessageBox.Show("Введено неверное значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Amount.Text = "";
                Amount.SelectionStart = 0;
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

        private void InitialState_Screen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string text = Amount.Text;
                if (Amount.Text.Contains("\r\n"))
                {
                    text = text.Remove(text.IndexOf("\r\n"), 2);
                }
                Amount.Text = text;

                this.Save_Click(sender, e);
            }

            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }
    }
}
