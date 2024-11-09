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
    public class Bai06
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai06.csv", "data_Bai06#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai06.csv"), TestMethod]
        public void TestBai06()
        {
            Code_Module03 cls = new Code_Module03();
            int sum = int.Parse(TestContext.DataRow[0].ToString());
            int count = int.Parse(TestContext.DataRow[1].ToString());

            double result = double.Parse(TestContext.DataRow[2].ToString());

            double result_act = cls.Average(sum, count);
            Assert.AreEqual(result, result_act);
        }
    }
}