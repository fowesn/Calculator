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
    public partial class History_Screen : Form
    {
        public History_Screen()
        {
            InitializeComponent();

            History_Record Transfer = new History_Record();
            Transfer.Write();

            StreamReader sr = new StreamReader(@"CurrentStateList.txt");
            float account = float.Parse(sr.ReadLine());
            sr.Close();

            Account.Text = Math.Round(account, 2).ToString() + " руб.";
            Today.Text = DateTime.Today.ToShortDateString();

            try
            {
                sr = new StreamReader(@"HistoryList.txt");
            }
            catch
            {
                FileStream fs = File.Create(@"HistoryList.txt");
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("0");
                sw.Close();
                fs.Close();
                sr = new StreamReader(@"HistoryList.txt");
            }

            if (!int.TryParse(sr.ReadLine(), out int n)) return;
            History_Record[] HistoryRecord = new History_Record[n];
            for (int i = 0; i < n; i++)
            {
                HistoryRecord[i] = new History_Record();
                if (!HistoryRecord[i].Read(sr))
                {
                    MessageBox.Show("Произошла ошибка при загрузке данных. История счёта будет очищена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    sr.Close();
                    StreamWriter sw = new StreamWriter(@"HistoryList.txt", false);
                    sw.WriteLine("0");
                    sw.Close();

                    for (int j = HistoryList.Items.Count - 1; i > 0; i--)
                        HistoryList.Items[j].Remove();

                    n = 0;
                    return;
                }

                //HistoryList.Columns[0].Text = DateTime.Today.ToLongDateString();
                if (i != 0 && HistoryRecord[i - 1].GetDate != HistoryRecord[i].GetDate)
                {
                    HistoryList.Items.Add("  " + HistoryRecord[i].GetDate.ToShortDateString());
                    HistoryList.Items[HistoryList.Items.Count - 1].ForeColor = Color.White;
                    HistoryList.Items[HistoryList.Items.Count - 1].BackColor = Color.FromArgb(64, 64, 64);
                }
                if (i == 0)
                {
                    HistoryList.Items.Add("  " + HistoryRecord[i].GetDate.ToShortDateString());
                    HistoryList.Items[HistoryList.Items.Count - 1].ForeColor = Color.White;
                    HistoryList.Items[HistoryList.Items.Count - 1].BackColor = Color.FromArgb(64, 64, 64);
                }

                HistoryList.Items.Add("  " + HistoryRecord[i].GetCategory);
                HistoryList.Items[HistoryList.Items.Count - 1].Font = new Font("Century Gothic", 10, FontStyle.Bold);

                string amount = HistoryRecord[i].GetIncrease ? "+" : "-";
                amount += HistoryRecord[i].GetAmount + " руб.";
                HistoryList.Items.Add("  " + amount);
                HistoryList.Items[HistoryList.Items.Count - 1].Font = new Font("Century Gothic", 15, FontStyle.Bold);
                HistoryList.Items[HistoryList.Items.Count - 1].ForeColor = HistoryRecord[i].GetIncrease ? Color.FromArgb(0, 142, 63) : Color.FromArgb(144, 12, 10); //зеленый : красный

                HistoryList.Items.Add("  " + HistoryRecord[i].GetComment);
                HistoryList.Items[HistoryList.Items.Count - 1].Font = new Font("Century Gothic", 10);
            }
            sr.Close();
        }
        private void CurrentState_Click(object sender, EventArgs e)
        {
            CurrentState_Screen CSS = new CurrentState_Screen();
            CSS.Show();
            CSS.Location = this.Location; //чтобы окно открывалось в том же месте, где и окно, с которого совершён переход
            CSS.Size = this.Size; //то же для размеров
            CSS.Activate();
            this.Visible = false;
        }

        private void Planning_Click(object sender, EventArgs e)
        {
            Planning_Screen PS = new Planning_Screen();
            PS.Show();
            PS.Location = this.Location;
            PS.Size = this.Size;
            PS.Activate();
            this.Visible = false;
        }

        private void HistoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (HistoryList.Items[HistoryList.SelectedIndices[0]].BackColor == Color.FromArgb(64, 64, 64))
                {

                    HistoryList.Items[HistoryList.SelectedIndices[0]].Selected = false;
                    return;
                }
            }
            catch { return; }

            int index = HistoryList.SelectedIndices[0] - 1;
            for (int i = 0; i < HistoryList.SelectedIndices[0]; i++)
            {
                if (HistoryList.Items[i].BackColor == Color.FromArgb(64, 64, 64))
                    index--;
            }

            History_Record_Screen HRS = new History_Record_Screen((index - index % 3) / 3);

            HRS.Show();
            HRS.Location = this.Location;
            HRS.Size = this.Size;
            HRS.Activate();
            this.Visible = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Вы действительно хотите очистить историю счёта?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                StreamWriter sw = new StreamWriter(@"HistoryList.txt", false);
                sw.WriteLine("0");
                sw.Close();

                for (int i = HistoryList.Items.Count - 1; i > 0; i--)
                    HistoryList.Items[i].Remove();
            }
        }

        private void History_Screen_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            HistoryList.Columns[0].Width = HistoryList.Width - 17;
        }
    }
}
