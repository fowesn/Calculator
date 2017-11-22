using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CurrentState_Record
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
        public void Edit(string cat, float am, string com)
        {

        }
        public bool Read(int i, StreamReader CurrentStateList)
        {
            string s = CurrentStateList.ReadLine();
            if (s == null) return false;
            string[] ss = s.Split(';');
            if (!int.TryParse(ss[0], out id)) return false;
            if (!bool.TryParse(ss[1], out increase)) return false;
            if(!DateTime.TryParse(ss[2], out date)) return false;
            try { category = ss[3]; } catch { return false; }
            if(!float.TryParse(ss[4], out amount)) return false;
            try { commentary = ss[5] == "0" ? "" : ss[5]; } catch { return false;  }
            return true;
        }
        public bool Write()
        {
            return true;
        }

        public bool GetIncrease
        {
            get
            {
                return this.increase;
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
