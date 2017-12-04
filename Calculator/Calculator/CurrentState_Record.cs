using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CurrentState_Record
    {
        private int id;
        private string category;
        private float amount;
        private string commentary;
        private DateTime date;
        private bool increase;

        public CurrentState_Record()
        {
            id = -1;
            category = "";
            amount = -1;
            commentary = "";
            date = DateTime.Today;
            increase = false;
        }
        public CurrentState_Record(int i, string cat, float am, string com, DateTime d, bool inc)
        {
            id = i;
            category = cat;
            amount = am;
            commentary = com;
            date = d;
            increase = inc;
        }
        public bool Edit(string cat, float am, string com)
        {
            category = cat;
            commentary = com == "" ? "0" : com;
            if (amount <= 0 || amount > 1000000) return false;
            try
            {
                string[] file = File.ReadAllLines(@"CurrentStateList.txt");

                file[0] = increase ? (float.Parse(file[0]) - amount + am).ToString() : (float.Parse(file[0]) + amount - am).ToString();

                amount = am;
                if (amount <= 0 || amount > 1000000) return false;
                file[id + 2] = id.ToString() + ';' + increase.ToString() + ';' + date.ToShortDateString() + ';' + category + ';' + amount.ToString() + ';' + commentary;
                File.WriteAllLines(@"CurrentStateList.txt", file);
            }
            catch { return false; }
            return true;

        }
        public bool Read(StreamReader CurrentStateList)
        {
            string s = CurrentStateList.ReadLine();
            if (s == null) return false;
            string[] ss = s.Split(';');
            try
            {
                if (!int.TryParse(ss[0], out id)) return false;
                if (!bool.TryParse(ss[1], out increase)) return false;
                if (!DateTime.TryParse(ss[2], out date)) return false;
                category = ss[3];
                if (!float.TryParse(ss[4], out amount)) return false;
                commentary = ss[5] == "0" ? "" : ss[5];
            }
            catch { return false; }
            return true;
        }

        public bool Write(string cat, float am, string com)
        {
            category = cat;
            amount = am;
            commentary = com == "" ? "0" : com;
            if (amount <= 0 || amount > 1000000) return false;
            try
            {
                string[] file = File.ReadAllLines(@"CurrentStateList.txt");
                if (file == null) return false;
                if (!int.TryParse(file[1], out int n)) return false;
                file[1] = (n + 1).ToString();
                file[file.Length - 1] += category + ";" + amount.ToString() + ";" + commentary;
                if (!float.TryParse(file[0], out float account)) return false;
                file[0] = bool.Parse(file[file.Length - 1].Split(';')[1]) ? (account + amount).ToString() : (account - amount).ToString();
                File.WriteAllLines(@"CurrentStateList.txt", file);
            }
            catch { return false; }
            return true;
        }

        public bool GetIncrease => this.increase;
        public string GetCategory => this.category;
        public float GetAmount => this.amount;
        public string GetComment => this.commentary;
    }
}
