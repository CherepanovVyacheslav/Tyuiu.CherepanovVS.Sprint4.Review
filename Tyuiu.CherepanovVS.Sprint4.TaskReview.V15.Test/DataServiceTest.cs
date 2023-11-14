using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint4.TaskReview.V15.Lib;

namespace Tyuiu.CherepanovVS.Sprint4.TaskReview.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];
            string str = "10293847";
            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(res, wait);

        }
    }
}
