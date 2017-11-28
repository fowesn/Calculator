using System;
using System.IO;
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
        float account;
        int n;
        Planning_Record[] PlanningRecord = null;
        public Planning_Screen()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader(@"CurrentStateList.txt");
            account = float.Parse(sr.ReadLine());
            sr.Close();

            Today.Text = DateTime.Today.ToShortDateString();
            Account.Text = Math.Round(account, 2).ToString() + " руб.";
            Date.MinDate = DateTime.Today;


            try
            {
                sr = new StreamReader(@"PlanningList.txt");
            }
            catch
            {
                FileStream fs = File.Create(@"PlanningList.txt");
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("0");
                sw.Close();
                fs.Close();

                sr = new StreamReader(@"PlanningList.txt");
            }

            n = int.Parse(sr.ReadLine());

            PlanningRecord = new Planning_Record[n];
            for (int i = 0; i < n; i++)
            {
                PlanningRecord[i] = new Planning_Record();
                if (!PlanningRecord[i].Read(sr))
                {
                    DialogResult Res = MessageBox.Show("Произошла ошибка при загрузке данных. " +
                        "История планирования счёта будет очищена.", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    sr.Close();

                }

                PlanningList.Items.Add(PlanningRecord[i].GetCategory);
                PlanningList.Items[PlanningList.Items.Count - 1].Font = new Font("Century Gothic", 10, FontStyle.Bold);

                string amount = PlanningRecord[i].GetIncrease ? "+" : "-";
                amount += PlanningRecord[i].GetAmount + " руб.";
                PlanningList.Items.Add(amount);
                PlanningList.Items[PlanningList.Items.Count - 1].Font = new Font("Century Gothic", 15, FontStyle.Bold);
                PlanningList.Items[PlanningList.Items.Count - 1].ForeColor = PlanningRecord[i].GetIncrease ?
                    Color.FromArgb(0, 142, 63) : Color.FromArgb(144, 12, 10); //зеленый : красный
                PlanningList.Items[PlanningList.Items.Count - 1].UseItemStyleForSubItems = false;


                //для правильного окончания слова "день"
                string temp = PlanningRecord[i].GetDays.ToString();
                if (temp == "1")
                {
                    PlanningList.Items[PlanningList.Items.Count - 1].SubItems.Add(PlanningRecord[i].GetTimes.ToString() + " раз в день");
                }
                else if (temp == "11" || temp == "12" || temp == "13" || temp == "14")
                    PlanningList.Items[PlanningList.Items.Count - 1].SubItems.Add(PlanningRecord[i].GetTimes.ToString() + " раз в " + PlanningRecord[i].GetDays.ToString() + " дней");
                else switch (temp[temp.Length - 1])
                    {
                        case '1':
                            PlanningList.Items[PlanningList.Items.Count - 1].SubItems.Add(PlanningRecord[i].GetTimes.ToString() + " раз в " + PlanningRecord[i].GetDays.ToString() + " день");
                            break;
                        case '2':
                            PlanningList.Items[PlanningList.Items.Count - 1].SubItems.Add(PlanningRecord[i].GetTimes.ToString() + " раз в " + PlanningRecord[i].GetDays.ToString() + " дня");
                            break;
                        case '3':
                            PlanningList.Items[PlanningList.Items.Count - 1].SubItems.Add(PlanningRecord[i].GetTimes.ToString() + " раз в " + PlanningRecord[i].GetDays.ToString() + " дня");
                            break;
                        case '4':
                            PlanningList.Items[PlanningList.Items.Count - 1].SubItems.Add(PlanningRecord[i].GetTimes.ToString() + " раз в " + PlanningRecord[i].GetDays.ToString() + " дня");
                            break;
                        default:
                            PlanningList.Items[PlanningList.Items.Count - 1].SubItems.Add(PlanningRecord[i].GetTimes.ToString() + " раз в " + PlanningRecord[i].GetDays.ToString() + " дней");
                            break;
                    }


                PlanningList.Items.Add(PlanningRecord[i].GetComment);
                PlanningList.Items[PlanningList.Items.Count - 1].Font = new Font("Century Gothic", 10);
            }
            sr.Close();
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
            int index = PlanningList.SelectedIndices[0];
            Planning_Record_Screen PRS = new Planning_Record_Screen((index - index % 3) / 3);

            PRS.Show();
            PRS.Location = this.Location;
            PRS.Size = this.Size;
            this.Visible = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Вы действительно хотите очистить историю планирования счёта?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                StreamWriter sw = new StreamWriter(@"PlanningList.txt", false);
                sw.WriteLine("0");
                sw.Close();

                for (int i = PlanningList.Items.Count - 1; i >= 0; i--)
                    PlanningList.Items[i].Remove();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText(@"PlanningList.txt");
            sw.Write("{0};true;", n);
            sw.Close();


            Planning_Record_Screen PRS = new Planning_Record_Screen(-1);
            PRS.Show();
            PRS.Location = this.Location;
            PRS.Size = this.Size;
            this.Visible = false;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText(@"PlanningList.txt");
            sw.Write("{0};false;", n);
            sw.Close();


            Planning_Record_Screen PRS = new Planning_Record_Screen(-1);
            PRS.Show();
            PRS.Location = this.Location;
            PRS.Size = this.Size;
            this.Visible = false;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            DateTime TargetDate = Date.Value;
            int days = (TargetDate - DateTime.Today).Days;
            float FutureAccount = account;
            for(int i = 0; i < n; i++)
            {
                int times = PlanningRecord[i].GetTimes * (days / PlanningRecord[i].GetDays);
                FutureAccount = PlanningRecord[i].GetIncrease ? FutureAccount + times * PlanningRecord[i].GetAmount : FutureAccount - times * PlanningRecord[i].GetAmount;
             }
            MessageBox.Show("Ваше состояние счёта " + TargetDate.ToLongDateString() + " составит " + 
                            Math.Round(FutureAccount, 2).ToString() + " руб.", 
                            "Рассчёт до " + TargetDate.ToLongDateString(), 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Planning_Screen_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            PlanningList.Columns[0].Width = PlanningList.Width - 200;
            PlanningList.Columns[1].Width = PlanningList.Width - PlanningList.Columns[0].Width - 17;
        }
    }
}
