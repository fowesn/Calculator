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
    public partial class CurrentState_Screen : Form
    {
        public CurrentState_Screen()
        {
            InitializeComponent();

            StreamReader CurrentState = new StreamReader(@"CurrentStateList.txt");
            Account.Text = CurrentState.ReadLine() + " руб.";
            Today.Text = DateTime.Today.ToShortDateString();

            int n = int.Parse(CurrentState.ReadLine());
            
            CurrentState_Record[] CurrentStateRecord = new CurrentState_Record[n];
            for(int i = 0; i < n; i++)
            {
                CurrentStateRecord[i] = new CurrentState_Record();
                if(!CurrentStateRecord[i].Read(i, CurrentState))
                {
                    DialogResult Res = MessageBox.Show("Произошла ошибка при загрузке данных. История текущего состояния счёта будет очищена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    CurrentState.Close();
                    InitialState_Screen ISS = new InitialState_Screen(true);
                    ISS.Show();
                    ISS.Location = this.Location;
                    ISS.Size = this.Size;
                    Application.ExitThread();
                    Application.Run(new InitialState_Screen(true));
                }

                CurrentStateList.Items.Add(CurrentStateRecord[i].GetCategory);
                CurrentStateList.Items[3 * i].Font = new Font("Century Gothic", 10, FontStyle.Bold);

                string amount = CurrentStateRecord[i].GetIncrease ? "+" : "-";
                amount += CurrentStateRecord[i].GetAmount + " руб.";
                CurrentStateList.Items.Add(amount);
                CurrentStateList.Items[3 * i + 1].Font = new Font("Century Gothic", 15, FontStyle.Bold);
                CurrentStateList.Items[3 * i + 1].ForeColor = CurrentStateRecord[i].GetIncrease ? Color.FromArgb(0, 142, 63) : Color.FromArgb(144, 12, 10); //зеленый : красный

                CurrentStateList.Items.Add(CurrentStateRecord[i].GetComment);
                CurrentStateList.Items[3 * i + 2].Font = new Font("Century Gothic", 10);
            }
        }

        private void History_Click(object sender, EventArgs e)
        {
            History_Screen HS = new History_Screen();
            HS.Show();
            HS.Location = this.Location;  //чтобы окно открывалось в том же месте, где и окно, с которого совершён переход
            HS.Size = this.Size; //то же для размеров
            this.Visible = false;
            //this.Close();
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
            //какие-то действия

            CurrentState_Record_Screen CSRS = new CurrentState_Record_Screen();
            CSRS.Show();
            CSRS.Location = this.Location;
            CSRS.Size = this.Size;
            this.Visible = false;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            //какие-то действия

            CurrentState_Record_Screen CSRS = new CurrentState_Record_Screen();
            CSRS.Show();
            CSRS.Location = this.Location;
            CSRS.Size = this.Size;
            this.Visible = false;
        }

        private void CurrentStateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentState_Record_Screen CSRS = new CurrentState_Record_Screen();
            CSRS.Show();
            CSRS.Location = this.Location;
            CSRS.Size = this.Size;
            this.Visible = false;
            //+добавление инфы
        }

        private void CurrentState_Screen_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
