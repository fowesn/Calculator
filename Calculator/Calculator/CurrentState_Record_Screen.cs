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
    public partial class CurrentState_Record_Screen : Form
    {
        private int index;
        private CurrentState_Record EditRecord = null;
        public CurrentState_Record_Screen(int id)
        {
            InitializeComponent();
            index = id;
            if(index != -1)
            {
                string[] file = File.ReadAllLines(@"CurrentStateList.txt");
                file = file[index + 2].Split(';');
                EditRecord = new CurrentState_Record(int.Parse(file[0]), file[3], float.Parse(file[4]), file[5], DateTime.Parse(file[2]), bool.Parse(file[1]));
                Category.Text = EditRecord.GetCategory;
                Amount.Text = EditRecord.GetAmount.ToString();
                Commentary.Text = EditRecord.GetComment;
                if (Commentary.Text == "0") Commentary.Text = "";
            }
        }

        private void History_Click(object sender, EventArgs e)
        {
            History_Screen HS = new History_Screen();
            HS.Show();
            HS.Location = this.Location;
            HS.Size = this.Size;
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

        private void Save_Click(object sender, EventArgs e)
        {
            if(Category.Text == "")
            {
                MessageBox.Show("Укажите категорию", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Amount.Text == "")
            {
                MessageBox.Show("Укажите сумму", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!float.TryParse(Amount.Text, out float amount))
            {
                MessageBox.Show("Данные в поле \"Сумма\" введены неверно", "Не заполнены обязательные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string category, commentary;
            category = Category.Text;
            if (Commentary.Text == "") { commentary = "0"; }
            else commentary = Commentary.Text;
            if (index < 0)
            {
                CurrentState_Record NewRecord = new CurrentState_Record();
                NewRecord.Write(category, amount, commentary);
            }
            else
            {
                EditRecord.Edit(category, amount, commentary);
            }
            CurrentState_Screen CSS = new CurrentState_Screen();
            CSS.Show();
            CSS.Location = this.Location;
            CSS.Size = this.Size;
            this.Visible = false;

        }

        private void Cancel_Click(object sender, EventArgs e)
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
            this.Visible = false;
        }

        private void CurrentState_Record_Screen_Closed(object sender, FormClosedEventArgs e)
        {
            CurrentState_Screen CSS = new CurrentState_Screen();
            CSS.Show();
            CSS.Location = this.Location;
            CSS.Size = this.Size;
            this.Visible = false;
        }
    }
}
