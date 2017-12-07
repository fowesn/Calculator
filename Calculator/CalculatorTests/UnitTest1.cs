using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Calculator;

namespace CalculatorTests
{
    [TestClass]
    public class CurrentState_Record_Tests
    {
        // позитивный 
        // в файле значения верны; ожидается, что Read() вернёт true
        [TestMethod]
        public void ReadFile_PositiveTest()
        {
            StreamReader sr = new StreamReader(@"CurrentStateList.txt");
            try
            {
                sr.ReadLine();
                sr.ReadLine();
            }
            catch { Assert.Fail(); }
            CurrentState_Record CSR = new CurrentState_Record();

            Assert.IsTrue(CSR.Read(sr));
        }

        // негативный
        // в файле значения неверны; ожидается, что Read() вернёт false
        [TestMethod]
        public void ReadFile_NegatveTest()
        {
            StreamReader sr = new StreamReader(@"CurrentStateList.txt");
            try
            {
                sr.ReadLine();
                sr.ReadLine();
            }
            catch { }
            CurrentState_Record CSR = new CurrentState_Record();

            Assert.IsFalse(CSR.Read(sr));
        }

        // позитивный
        // передаём функции Write() верные значения; ожидается, что Write() вернёт true
        [TestMethod]
        public void WriteFile_PositiveTest()
        {
            string category = "Другое";
            float amount = 1000;
            string commentary = "";
            CurrentState_Record CSR = new CurrentState_Record();

            Assert.IsTrue(CSR.Write(category, amount, commentary));
        }

        // негативный
        // передаём функции Write() неверные значения; ожидается, что Write() вернёт false
        [TestMethod]
        public void WriteFile_NegativeTest()
        {
            string category = "Другое";
            float amount = -2000;
            string commentary = "";
            CurrentState_Record CSR = new CurrentState_Record();

            Assert.IsFalse(CSR.Write(category, amount, commentary));
        }

        // краевой
        // передаём функции Write() верные граничные значения; ожидается, что Write() вернёт true
        [TestMethod]
        public void WriteFile_BoundaryTest1()
        {
            string category = "Другое";
            float amount = 1;
            string commentary = "";
            CurrentState_Record CSR = new CurrentState_Record();

            Assert.IsTrue(CSR.Write(category, amount, commentary));
        }

        // краевой
        [TestMethod]
        public void WriteFile_BoundaryTest2()
        {
            string category = "Другое";
            float amount = 1000000;
            string commentary = "123";
            CurrentState_Record CSR = new CurrentState_Record();

            Assert.IsTrue(CSR.Write(category, amount, commentary));
        }

        // позитивный
        // передаём функции Edit() верные значения; ожидается, что Edit() вернёт true
        [TestMethod]
        public void EditFile_PositiveTest()
        {
            string category = "Другое";
            float amount = 1000;
            string commentary = "";
            CurrentState_Record CSR = new CurrentState_Record(2, "Интернет", 500, "0", DateTime.Today, false);

            Assert.IsTrue(CSR.Edit(category, amount, commentary));
        }
        // негативный
        // передаём функции Edit() неверные значения; ожидается, что Edit() вернёт false
        [TestMethod]
        public void EditFile_NegativeTest()
        {
            string category = "Другое";
            float amount = 0;
            string commentary = "";
            CurrentState_Record CSR = new CurrentState_Record(2, "Интернет", 500, "0", DateTime.Today, false);

            Assert.IsFalse(CSR.Edit(category, amount, commentary));
        }

        // краевой
        // передаём функции Edit() верные граничные значения; ожидается, что Edit() вернёт true
        [TestMethod]
        public void EditFile_BoundaryTest1()
        {
            string category = "Другое";
            float amount = 1;
            string commentary = "";
            CurrentState_Record CSR = new CurrentState_Record(2, "Интернет", 500, "0", DateTime.Today, false);

            Assert.IsTrue(CSR.Edit(category, amount, commentary));
        }

        // краевой
        [TestMethod]
        public void EditFile_BoundaryTest2()
        {
            string category = "Другое";
            float amount = 1000000;
            string commentary = "";
            CurrentState_Record CSR = new CurrentState_Record(2, "Интернет", 500, "0", DateTime.Today, false);

            Assert.IsTrue(CSR.Edit(category, amount, commentary));
        }
    }

    [TestClass]
    public class History_Record_Tests
    {
        [TestMethod]
        public void Test()
        {
        }
    }

    [TestClass]
    public class Planning_Record_Tests
    {
        // попытка записи в файл, когда times == -1
        [TestMethod]
        public void Write_Negative_1()
        {
            // входные данные
            Planning_Record PR = new Planning_Record();
            Frequency FR = new Frequency(-1, 1);
            string cat = "Подарок";
            float am = 100;
            string com = "От друзей";
            bool expected = false;

            // получение результата с помощью тестируемой функции
            bool actual = PR.Write(cat, am, com, FR.times, FR.days);

            // проверка совпадения ожидаемого и полученного значений
            Assert.AreEqual(expected, actual);
        }

        // попытка записи в файл, когда times == 1000001
        [TestMethod]
        public void Write_Negative_2()
        {
            // входные данные
            Planning_Record PR = new Planning_Record();
            Frequency FR = new Frequency(1000001, 1);
            string cat = "Подарок";
            float am = 100;
            string com = "От друзей";
            bool expected = false;

            // получение результата с помощью тестируемой функции
            bool actual = PR.Write(cat, am, com, FR.times, FR.days);

            // проверка совпадения ожидаемого и полученного значений
            Assert.AreEqual(expected, actual);
        }

        // попытка записи в файл, когда days == 0
        [TestMethod]
        public void Write_Edge_1()
        {
            // входные данные
            Planning_Record PR = new Planning_Record();
            Frequency FR = new Frequency(1, 0);
            string cat = "Подарок";
            float am = 100;
            string com = "От друзей";
            bool expected = true;

            // получение результата с помощью тестируемой функции
            bool actual = PR.Write(cat, am, com, FR.times, FR.days);

            // проверка совпадения ожидаемого и полученного значений
            Assert.AreEqual(expected, actual);
        }

        // попытка записи в файл, когда days == 1000
        [TestMethod]
        public void Write_Edge_2()
        {
            // входные данные
            Planning_Record PR = new Planning_Record();
            Frequency FR = new Frequency(1, 1000);
            string cat = "Подарок";
            float am = 100;
            string com = "От друзей";
            bool expected = true;

            // получение результата с помощью тестируемой функции
            bool actual = PR.Write(cat, am, com, FR.times, FR.days);

            // проверка совпадения ожидаемого и полученного значений
            Assert.AreEqual(expected, actual);
        }

        // попытка записи в файл, когда days == 1001
        [TestMethod]
        public void Edit_Negative_1()
        {
            // входные данные
            Frequency FR = new Frequency(1, 1001);
            Planning_Record PR = new Planning_Record(1, "ЖКУ", 1000, "", FR, false);
            string cat = "Транспорт";
            float am = 100;
            string com = "Проездной";
            bool expected = false;

            // получение результата с помощью тестируемой функции
            bool actual = PR.Edit(cat, am, com, FR.times, FR.days);

            // проверка совпадения ожидаемого и полученного значений
            Assert.AreEqual(expected, actual);
        }

        // попытка записи в файл, когда days == -1
        [TestMethod]
        public void Edit_Negative_2()
        {
            // входные данные
            Frequency FR = new Frequency(1, -1);
            Planning_Record PR = new Planning_Record(1, "ЖКУ", 1000, "", FR, false);
            string cat = "Транспорт";
            float am = 100;
            string com = "Проездной";
            bool expected = false;

            // получение результата с помощью тестируемой функции
            bool actual = PR.Edit(cat, am, com, FR.times, FR.days);

            // проверка совпадения ожидаемого и полученного значений
            Assert.AreEqual(expected, actual);
        }

        // попытка записи в файл, когда файл удален
        [TestMethod]
        public void Edit_Negative_3()
        {
            // входные данные
            Planning_Record PR = new Planning_Record();
            Frequency FR = new Frequency(1, -1);
            string cat = "Транспорт";
            float am = 100;
            string com = "Проездной";
            bool expected = false;
            // удаление файла
            File.Delete(@"PlanningList.txt");

            // получение результата с помощью тестируемой функции
            bool actual = PR.Edit(cat, am, com, FR.times, FR.days);

            // проверка совпадения ожидаемого и полученного значений
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Edit_Positive()
        {
            // входные данные
            Frequency FR = new Frequency(5, 7);
            Planning_Record PR = new Planning_Record(1, "ЖКУ", 1000, "ytyt", FR, false);
            string cat = "Транспорт";
            float am = 100;
            string com = "Проездной";
            bool expected = true;
            Frequency FR_ = new Frequency(6, 4);

            // получение результата с помощью тестируемой функции
            bool actual = PR.Edit(cat, am, com, FR_.times, FR_.days);

            // проверка совпадения ожидаемого и полученного значений
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Read_Negative()
        {
            // входные данные
            Planning_Record PR = new Planning_Record();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"PlanningList.txt");
            }

            catch
            {
                //Assert.Fail();
            }
            bool expected = false;

            // получение результата с помощью тестируемой функции
            bool actual = PR.Read(sr);

            // проверка совпадения ожидаемого и полученного значений
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Read_Positive()
        {
            // входные данные
            Planning_Record PR = new Planning_Record();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"PlanningList.txt");
            }

            catch
            {
                Assert.Fail();
            }

            sr.ReadLine();
            bool expected = true;

            // получение результата с помощью тестируемой функции
            bool actual = PR.Read(sr);

            // проверка совпадения ожидаемого и полученного значений
            Assert.AreEqual(expected, actual);
        }
    }
}
