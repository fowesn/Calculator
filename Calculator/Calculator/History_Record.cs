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
        private string category;
        private float amount;
        private string commentary;
        private DateTime date;
        private bool increase;

        public bool Read(StreamReader HistoryList)
        {
            string s = HistoryList.ReadLine();
            if (s == null) return false;
            string[] ss = s.Split(';');
            try
            {
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

            string[] History = null;
            try
            {
                History = File.ReadAllLines(@"HistoryList.txt");
            }
            catch
            {
                FileStream fs = File.Create(@"HistoryList.txt");
                StreamWriter sw1 = new StreamWriter(fs);
                sw1.WriteLine("0");
                sw1.Close();
                fs.Close();
                History = File.ReadAllLines(@"HistoryList.txt");
            }
            if (!DateTime.TryParse(Record[2], out DateTime CurrentStateDate)) return false;
            
            if(CurrentStateDate < DateTime.Today.Date)
            {
                int m;
                if (!int.TryParse(CurrentState[1], out int n)) return false;
                if (n == 0) return true;
                
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

        public bool GetIncrease => this.increase;
        public DateTime GetDate => this.date;
        public string GetCategory => this.category;
        public float GetAmount => this.amount;
        public string GetComment => this.commentary;
    }
}
