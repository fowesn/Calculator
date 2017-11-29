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
    public partial class Planning_Record_Screen : Form
    {
        private int index;
        private Planning_Record EditRecord = null;
        public Planning_Record_Screen(int id)
        {
            InitializeComponent();
            index = id;
            string[] file = File.ReadAllLines(@"CurrentStateList.txt");
            Account.Text = file[0] + " руб.";
            Today.Text = DateTime.Today.ToShortDateString();

            file = File.ReadAllLines(@"PlanningList.txt");
            if (index != -1)
            {
                file = file[index + 1].Split(';');
                if (bool.Parse(file[1]))
                {
                    string[] categories = { "Стипендия", "Пенсия", "Долг", "Подарок", "Компенсация", "Подработка" };
                    Array.Sort(categories);
                    Category.Items.AddRange(categories);
                }
                else
                {
                    string[] categories = { "Питание", "Одежда", "Долг", "Транспорт", "Интернет", "Телефон", "ЖКУ", "Подарки", "Техника",
                                        "Канцелярия", "Книги", "Бытовая химия", "Ремонт", "Лечение" };
                    Array.Sort(categories);
                    Category.Items.AddRange(categories);
                }
                
                EditRecord = new Planning_Record(int.Parse(file[0]), file[2], float.Parse(file[5]), file[6], 
                             new Frequency(int.Parse(file[3]), int.Parse(file[4])), bool.Parse(file[1]));
                Category.Text = EditRecord.GetCategory;
                Amount.Text = EditRecord.GetAmount.ToString();
                Commentary.Text = EditRecord.GetComment;
                Times.Text = EditRecord.GetTimes.ToString();
                Days.Text = EditRecord.GetDays.ToString();

                if (Commentary.Text == "0") Commentary.Text = "";
            }
            else
            {
                string[] f = file[file.Length - 1].Split(';');
                if (bool.Parse(f[1]))
                {
                    string[] categories = { "Стипендия", "Пенсия", "Долг", "Подарок", "Компенсация", "Подработка" };
                    Array.Sort(categories);
                    Category.Items.AddRange(categories);
                }
                else
                {
                    string[] categories = { "Питание", "Одежда", "Долг", "Транспорт", "Интернет", "Телефон", "ЖКУ", "Подарки", "Техника",
                                        "Канцелярия", "Книги", "Бытовая химия", "Ремонт", "Лечение" };
                    Array.Sort(categories);
                    Category.Items.AddRange(categories);
                }
            }
            Category.Items.Add("Другое");
        }

        private void CurrentState_Click(object sender, EventArgs e)
        {
            string[] file = File.ReadAllLines(@"PlanningList.txt");
            string delete = file[file.Length - 1];
            if (delete[delete.Length - 1] == ';')
            {
                //удаление последней строки файла, т.к. там записывалась часть инфы перед вызовом этой формы
                file = (from x in file where !x.Contains(delete) select x).ToArray();
                File.WriteAllLines(@"PlanningList.txt", file);
            }

            CurrentState_Screen CSS = new CurrentState_Screen();
            CSS.Show();
            CSS.Location = this.Location;
            CSS.Size = this.Size;
            this.Visible = false;
        }

        private void History_Click(object sender, EventArgs e)
        {
            string[] file = File.ReadAllLines(@"PlanningList.txt");
            string delete = file[file.Length - 1];
            if (delete[delete.Length - 1] == ';')
            {
                //удаление последней строки файла, т.к. там записывалась часть инфы перед вызовом этой формы
                file = (from x in file where !x.Contains(delete) select x).ToArray();
                File.WriteAllLines(@"PlanningList.txt", file);
            }

            History_Screen HS = new History_Screen();
            HS.Show();
            HS.Location = this.Location;
            HS.Size = this.Size;
            this.Visible = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Category.Text == "")
            {
                MessageBox.Show("Укажите категорию", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Category.DroppedDown = true;
                return;
            }
            if (Times.Text == "")
            {
                MessageBox.Show("Укажите количество раз", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Times.SelectionStart = Times.Text.Length;
                return;
            }
            if (!int.TryParse(Times.Text, out int times) || times <= 0)
            {
                MessageBox.Show("Количество раз введено неверно", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Times.Text = "";
                Times.SelectionStart = 0;
                return;
            }
            if (Days.Text == "")
            {
                MessageBox.Show("Укажите количество дней", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Days.SelectionStart = Days.Text.Length;
                return;
            }
            if (!int.TryParse(Days.Text, out int days) || days <= 0)
            {
                MessageBox.Show("Количество дней введено неверно", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Days.Text = "";
                Days.SelectionStart = 0;
                return;
            }
            if (Amount.Text == "")
            {
                MessageBox.Show("Укажите сумму", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Amount.SelectionStart = Amount.Text.Length;
                return;
            }
            if (!float.TryParse(Amount.Text, out float amount) || amount <= 0)
            {
                MessageBox.Show("Данные в поле \"Сумма\" введены неверно", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Amount.Text = "";
                Amount.SelectionStart = 0;
                return;
            }

            string category, commentary;
            category = Category.Text;
            if (Commentary.Text == "") { commentary = "0"; }
            else commentary = Commentary.Text;
            if (index < 0)
            {
                Planning_Record NewRecord = new Planning_Record();
                NewRecord.Write(category, (float)Math.Round(amount, 2), commentary, times, days);
            }
            else
            {
                EditRecord.Edit(category, (float)Math.Round(amount, 2), commentary, times, days);
            }
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Planning_Record_Screen_Closed(object sender, FormClosedEventArgs e)
        {
            string[] file = File.ReadAllLines(@"PlanningList.txt");
            string delete = file[file.Length - 1];
            if (delete[delete.Length - 1] == ';')
            {
                //удаление последней строки файла, т.к. там записывалась часть инфы перед вызовом этой формы
                file = (from x in file where !x.Contains(delete) select x).ToArray();
                File.WriteAllLines(@"PlanningList.txt", file);
            }

            Planning_Screen PS = new Planning_Screen();
            PS.Show();
            PS.Location = this.Location;
            PS.Size = this.Size;
            this.Visible = false;
        }

        private void Planning_Record_Screen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = Amount.Text;
                if (Amount.Text.Contains("\r\n"))
                {
                    text = text.Remove(text.IndexOf("\r\n"), 2);
                }
                Amount.Text = text;

                text = Commentary.Text;
                if (Commentary.Text.Contains("\r\n"))
                {
                    text = text.Remove(text.IndexOf("\r\n"), 2);
                }
                Commentary.Text = text;

                text = Days.Text;
                if (Days.Text.Contains("\r\n"))
                {
                    text = text.Remove(text.IndexOf("\r\n"), 2);
                }
                Days.Text = text;

                text = Times.Text;
                if (Times.Text.Contains("\r\n"))
                {
                    text = text.Remove(text.IndexOf("\r\n"), 2);
                }
                Times.Text = text;

                this.Save_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
