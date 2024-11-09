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
    public class Bai17
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai17.csv", "data_Bai17#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai17.csv"), TestMethod]
        public void TestBai17()
        {
            Code_Module03 cls = new Code_Module03();

            int year = int.Parse(TestContext.DataRow[0].ToString());
            int month = int.Parse(TestContext.DataRow[1].ToString());
            int day = int.Parse(TestContext.DataRow[2].ToString());


            bool result = bool.Parse(TestContext.DataRow[3].ToString());

            bool result_act = cls.IsValidDate(year, month, day);
            Assert.AreEqual(result, result_act);
        }
    }
}