﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    struct Frequency
    {
        public int times;
        public int days;
        public Frequency(int a, int b)
        {
            times = a;
            days = b;
        }
    }
    class Planning_Record
    {
        private int id;
        private string category;
        private float amount;
        private string commentary;
        private bool increase;
        private Frequency frequency;

        public Planning_Record()
        {
            id = -1;
            category = "";
            amount = -1;
            commentary = "";
            increase = false;
        }
        public Planning_Record(int i, string cat, float am, string com, Frequency freq, bool inc)
        {
            id = i;
            category = cat;
            amount = am;
            commentary = com;
            increase = inc;
            frequency = freq;
        }
        public void Edit(string cat, float am, string com, int times, int days)
        {
            category = cat;
            commentary = com == "" ? "0" : com;
            frequency.days = days;
            frequency.times = times;
            amount = am;

            string[] file = File.ReadAllLines(@"PlanningList.txt");
            file[id + 1] = id.ToString() + ';' + increase.ToString() + ';' + category + ';' +
                           frequency.times.ToString() + ';' + frequency.days.ToString() + ';' + 
                           amount.ToString() + ';' + commentary;
            File.WriteAllLines(@"PlanningList.txt", file);
        }
        public bool Read(StreamReader PlanningList)
        {
            string s = PlanningList.ReadLine();
            if (s == null) return false;
            if (s == "") return false;
            string[] ss = s.Split(';');
            try
            {
                if (!int.TryParse(ss[0], out id)) return false;
                if (!bool.TryParse(ss[1], out increase)) return false;
                category = ss[2];
                if (!int.TryParse(ss[3], out frequency.times)) return false;
                if (!int.TryParse(ss[4], out frequency.days)) return false;
                if (!float.TryParse(ss[5], out amount)) return false;
                commentary = ss[6] == "0" ? "" : ss[6];
            }
            catch { return false; }
            return true;
        }

        public bool Write(string cat, float am, string com, int times, int days)
        {
            category = cat;
            amount = am;
            commentary = com;
            frequency.times = times;
            frequency.days = days;
            string[] file = File.ReadAllLines(@"PlanningList.txt");
            file[0] = (int.Parse(file[0]) + 1).ToString();
            file[file.Length - 1] += category + ";" + frequency.times.ToString() + ';' + frequency.days.ToString() + ';' + amount.ToString() + ";" + commentary;
            File.WriteAllLines(@"PlanningList.txt", file);
            return true;
        }

        public bool GetIncrease => this.increase;
        public string GetCategory => this.category;
        public float GetAmount => this.amount;
        public string GetComment => this.commentary;
        public int GetTimes => this.frequency.times;
        public int GetDays => this.frequency.days;
    }
}
