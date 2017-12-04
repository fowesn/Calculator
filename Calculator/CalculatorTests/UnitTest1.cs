using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System.IO;

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
        [TestMethod]
        public void Test()
        {
        }
    }
}
