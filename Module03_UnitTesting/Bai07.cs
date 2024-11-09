using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03_UnitTesting
{

    [TestClass]
    public class Bai07
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai07.csv", "data_Bai07#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai07.csv"), TestMethod]
        public void TestBai07()
        {
            Code_Module03 cls = new Code_Module03();
            int month = int.Parse(TestContext.DataRow[0].ToString());
            int year = int.Parse(TestContext.DataRow[1].ToString());
            
            int result = int.Parse(TestContext.DataRow[2].ToString());

            int result_act = cls.DayInMonth(year, month);
            Assert.AreEqual(result, result_act);
        }

        [TestMethod]
        public void Testmethod()
        {
            Code_Module03 cls = new Code_Module03();
            int month = 12;
            int year = 2024;
            int result = 31;

            int result_act = cls.DayInMonth(year, month);
            Assert.AreEqual(result, result_act);
        }
    }
}