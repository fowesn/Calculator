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
        int n;
        float account;
        public CurrentState_Screen()
        {
            InitializeComponent();

            History_Record Transfer = new History_Record();
            Transfer.Write();

            StreamReader sr = new StreamReader(@"CurrentStateList.txt");
            account = float.Parse(sr.ReadLine());

            Today.Text = DateTime.Today.ToShortDateString();
            Account.Text = Math.Round(account, 2).ToString() + " руб.";

            n = int.Parse(sr.ReadLine());
            
            CurrentState_Record[] CurrentStateRecord = new CurrentState_Record[n];
            for(int i = 0; i < n; i++)
            {
                CurrentStateRecord[i] = new CurrentState_Record();
                if(!CurrentStateRecord[i].Read(sr))
                {
                    DialogResult Res = MessageBox.Show("Произошла ошибка при загрузке данных. История текущего состояния счёта будет очищена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    sr.Close();
                    Application.ExitThread();
                    InitialState_Screen ISS = new InitialState_Screen();
                    ISS.Show();
                    ISS.Location = this.Location;
                    ISS.Size = this.Size;
                    try { Application.Run(ISS); }
                    catch { new InitialState_Screen().Show(); }
                }

                CurrentStateList.Columns[0].Text = DateTime.Today.ToLongDateString();

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
            sr.Close();

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
            StreamWriter sw = File.AppendText(@"CurrentStateList.txt");
            sw.Write("{0};true;" + DateTime.Today.ToShortDateString() + ";", n);
            sw.Close();

            CurrentState_Record_Screen CSRS = new CurrentState_Record_Screen(-1);
            CSRS.Show();
            CSRS.Location = this.Location;
            CSRS.Size = this.Size;
            this.Visible = false;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText(@"CurrentStateList.txt");
            sw.Write("{0};false;" + DateTime.Today.ToShortDateString() + ";", n);
            sw.Close();

            CurrentState_Record_Screen CSRS = new CurrentState_Record_Screen(-1);
            CSRS.Show();
            CSRS.Location = this.Location;
            CSRS.Size = this.Size;
            this.Visible = false;
        }

        private void CurrentStateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CurrentStateList.SelectedIndices[0];
            CurrentState_Record_Screen CSRS = new CurrentState_Record_Screen((index - index % 3) / 3); // это формула, которая выведена из того, что на каждый элемент таблицы приходится 
                                                                                                       // по три записи. т.е. для каждой записи индекс в таблице будет 
                                                                                                       // индекс = 3 * (номер записи) + [0,1,2], где [0,1,2] - одна из трёх частей записи
                                                                                                       // пусть номер записи = х и индекс известен, отсюда
                                                                                                       // i = 3x + [0,1,2]
                                                                                                       // => x = (i - i % 3) / 3
            CSRS.Show();
            CSRS.Location = this.Location;
            CSRS.Size = this.Size;
            this.Visible = false;
        }

        private void CurrentState_Screen_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //изменение ширины столбца под ширину таблицы
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CurrentStateList.Columns[0].Width = CurrentStateList.Width - 17;
        }
    }
}
