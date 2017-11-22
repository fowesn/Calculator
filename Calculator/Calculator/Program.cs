using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StreamReader CurrentState = null;
            try
            {
                CurrentState = new StreamReader(@"CurrentStateList.txt");
            }
            catch
            {
                FileStream fs = File.Create(@"CurrentStateList.txt");
                fs.Close();
                CurrentState = new StreamReader(@"CurrentStateList.txt");
            }
            string s = null;
            if ((s = CurrentState.ReadLine()) != null)
            {
                if(!float.TryParse(s, out float a))
                {
                    //файл не пуст, но первая строка не соответствует шаблону
                    CurrentState.Close();
                    Application.Run(new InitialState_Screen(true));
                }
                else if (!int.TryParse(CurrentState.ReadLine(), out int n))
                {
                    //файл не пуст, но вторая строка не соответствует шаблону
                    CurrentState.Close();
                    Application.Run(new InitialState_Screen(true));
                }
                else
                {
                    //файл не пуст и первые 2 строки соответствуют шаблону
                    CurrentState.Close();
                    Application.Run(new CurrentState_Screen());
                }
            }
            else
            //файл пуст и нет никаких проблем
            {
                CurrentState.Close();
                Application.Run(new InitialState_Screen(false));
            }
        }
    }
}
