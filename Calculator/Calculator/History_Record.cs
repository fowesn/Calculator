using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class History_Record
    {
        private int id;
        private string category;
        private float amount;
        private string commentary;
        private DateTime date;
        private bool increase;

       /* public History_Record()
        {
            id = -1;
            category = "";
            amount = -1;
            commentary = "";
            date = DateTime.Today;
            increase = false;
        }
        public History_Record(int i, string cat, float am, string com, DateTime d, bool inc)
        {
            id = i;
            category = cat;
            amount = am;
            commentary = com;
            date = d;
            increase = inc;
        }*/

        public bool Read(StreamReader HistoryList)
        {
            string s = HistoryList.ReadLine();
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

        public bool Write()
        {
            string[] CurrentState = File.ReadAllLines(@"CurrentStateList.txt");
            string[] Record = null; 
            try
            {
                Record = CurrentState[2].Split(';');
            }
            catch
            {
                return true;
            }
            if (!DateTime.TryParse(Record[2], out DateTime CurrentStateDate)) return false;
            
            if(CurrentStateDate < DateTime.Today.Date)
            {
                int m;
                if (!int.TryParse(CurrentState[1], out int n)) return false;
                if (n == 0) return true;
                string[] History = File.ReadAllLines(@"HistoryList.txt");
                try { if (!int.TryParse(History[0], out m)) return false; }
                catch { m = 0; }

                string[] NewHistory = new string[n + m + 1];
                NewHistory[0] = (n + m).ToString();

                //Пополнение файла historylist записями из currentstatelist
                for (int i = 1; i < m + 1; i++)
                    NewHistory[i] = History[i];
                for (int i = m + 1; i < m + n + 1; i++)
                    NewHistory[i] = CurrentState[i - m + 1];
                File.WriteAllLines(@"HistoryList.txt", NewHistory);

                //перезапись файла currentstatelist
                StreamWriter sw = new StreamWriter(@"CurrentStateList.txt", false);
                sw.WriteLine(CurrentState[0]);
                sw.WriteLine("0");
                sw.Close();
            }

            return true;
        }

        public bool GetIncrease
        {
            get
            {
                return this.increase;
            }
        }
        public DateTime GetDate
        {
            get
            {
                return this.date;
            }
        }
        public string GetCategory
        {
            get
            {
                return this.category;
            }
        }
        public float GetAmount
        {
            get
            {
                return this.amount;
            }
        }
        public string GetComment
        {
            get
            {
                return this.commentary;
            }
        }
    }
}
