﻿using System;
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
    public partial class CurrentState_Record_Screen : Form
    {
        private int index;
        private CurrentState_Record EditRecord = null;
        private string category, amount, commentary;
        public CurrentState_Record_Screen(int id)
        {
            InitializeComponent();
            index = id;
            string[] file = File.ReadAllLines(@"CurrentStateList.txt");
            Account.Text = file[0] + " руб.";
            Today.Text = DateTime.Today.ToShortDateString();

            if (index != -1)
            {
                file = file[index + 2].Split(';');
                if (bool.Parse(file[1]))
                {
                    string[] categories = { "Стипендия", "Пенсия", "Долг", "Подарок", "Компенсация", "Подработка", "яя" };
                    Array.Sort(categories);
                    categories[categories.Length - 1] = "Другое";
                    Category.Items.AddRange(categories);
                }
                else
                {
                    string[] categories = { "Питание", "Одежда", "Долг", "Транспорт", "Интернет", "Телефон", "ЖКУ", "Подарки", "Техника",
                                        "Канцелярия", "Книги", "Бытовая химия", "Ремонт", "Лечение", "яя" };
                    Array.Sort(categories);
                    categories[categories.Length - 1] = "Другое";
                    Category.Items.AddRange(categories);
                }
                EditRecord = new CurrentState_Record(int.Parse(file[0]), file[3], float.Parse(file[4]), file[5], DateTime.Parse(file[2]), bool.Parse(file[1]));
                Category.Text = EditRecord.GetCategory;
                Amount.Text = EditRecord.GetAmount.ToString();
                Commentary.Text = EditRecord.GetComment;
                if (Commentary.Text == "0") Commentary.Text = "";
            }
            else
            {
                string[] f = file[file.Length - 1].Split(';');
                if (bool.Parse(f[1]))
                {
                    string[] categories = { "Стипендия", "Пенсия", "Долг", "Подарок", "Компенсация", "Подработка", "яя" };
                    Array.Sort(categories);
                    categories[categories.Length - 1] = "Другое";
                    Category.Items.AddRange(categories);
                }
                else
                {
                    string[] categories = { "Питание", "Одежда", "Долг", "Транспорт", "Интернет", "Телефон", "ЖКУ", "Подарки", "Техника",
                                        "Канцелярия", "Книги", "Бытовая химия", "Ремонт", "Лечение", "яя" };
                    Array.Sort(categories);
                    categories[categories.Length - 1] = "Другое";
                    Category.Items.AddRange(categories);
                }
            }
            category = Category.Text;
            amount = Amount.Text;
            commentary = Commentary.Text;
        }

        private void History_Click(object sender, EventArgs e)
        {
            if (Category.Text != category || Amount.Text != amount || Commentary.Text != commentary)
            {
                DialogResult Result = MessageBox.Show("Все несохранённые данные будут потеряны. Продолжить?",
                    "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.No)
                {
                    //e.Cancel = true;
                    return;
                }
            }
            string[] file = File.ReadAllLines(@"CurrentStateList.txt");
            string delete = file[file.Length - 1];
            if (delete[delete.Length - 1] == ';')
            {
                //удаление последней строки файла, т.к. там записывалась часть инфы перед вызовом этой формы
                file = (from x in file where !x.Contains(delete) select x).ToArray();
                File.WriteAllLines(@"CurrentStateList.txt", file);
            }
            History_Screen HS = new History_Screen();
            HS.Show();
            HS.Location = this.Location;
            HS.Size = this.Size;
            HS.Activate();
            this.Visible = false;
        }

        private void Planning_Click(object sender, EventArgs e)
        {
            if (Category.Text != category || Amount.Text != amount || Commentary.Text != commentary)
            {
                DialogResult Result = MessageBox.Show("Все несохранённые данные будут потеряны. Продолжить?",
                    "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.No)
                {
                    //e.Cancel = true;
                    return;
                }
            }
            string[] file = File.ReadAllLines(@"CurrentStateList.txt");
            string delete = file[file.Length - 1];
            if (delete[delete.Length - 1] == ';')
            {
                //удаление последней строки файла, т.к. там записывалась часть инфы перед вызовом этой формы
                file = (from x in file where !x.Contains(delete) select x).ToArray();
                File.WriteAllLines(@"CurrentStateList.txt", file);
            }
            Planning_Screen PS = new Planning_Screen();
            PS.Show();
            PS.Location = this.Location;
            PS.Size = this.Size;
            PS.Activate();
            this.Visible = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(Category.Text == "")
            {
                MessageBox.Show("Укажите категорию", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Category.DroppedDown = true;
                return;
            }
            if (Amount.Text == "")
            {
                MessageBox.Show("Укажите сумму", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Amount.Focus();
                return;
            }
            if(!float.TryParse(Amount.Text, out float amount) || amount <= 0)
            {
                MessageBox.Show("Данные в поле \"Сумма\" введены неверно", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Amount.Focus();
                Amount.Text = "";
                return;
            }
            if(amount > 1000000)
            {
                MessageBox.Show("Введено слишком большое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Amount.Focus();
                Amount.Text = "";
                return;
            }
            string category, commentary;
            category = Category.Text;
            if (Commentary.Text == "") { commentary = "0"; }
            else commentary = Commentary.Text;
            if (index < 0)
            {
                CurrentState_Record NewRecord = new CurrentState_Record();
                NewRecord.Write(category, (float)Math.Round(amount, 2), commentary);
            }
            else
            {
                EditRecord.Edit(category, (float)Math.Round(amount, 2), commentary);
            }
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (Category.Text != category || Amount.Text != amount || Commentary.Text != commentary)
            {
                DialogResult Result = MessageBox.Show("Все несохранённые данные будут потеряны. Продолжить?",
                    "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.No)
                {
                    //e.Cancel = true;
                    return;
                }
            }
            this.Close();
        }

        private void CurrentState_Record_Screen_Closing(object sender, FormClosingEventArgs e)
        {
            string[] file = File.ReadAllLines(@"CurrentStateList.txt");
            string delete = file[file.Length - 1];
            if (delete[delete.Length - 1] == ';')
            {
                //удаление последней строки файла, т.к. там записывалась часть инфы перед вызовом этой формы
                file = (from x in file where !x.Contains(delete) select x).ToArray();
                File.WriteAllLines(@"CurrentStateList.txt", file);
            }

            CurrentState_Screen CSS = new CurrentState_Screen();
            CSS.Show();
            CSS.Location = this.Location;
            CSS.Size = this.Size;
            CSS.Activate();
        }

        private void CurrentState_Record_Screen_KeyUp(object sender, KeyEventArgs e)
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


                this.Save_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (Category.Text != category || Amount.Text != amount || Commentary.Text != commentary)
                {
                    DialogResult Result = MessageBox.Show("Все несохранённые данные будут потеряны. Продолжить?",
                        "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.No)
                    {
                        //e.Cancel = true;
                        return;
                    }
                }
                this.Close();
            }
        }
    }
}
