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
    public class Bai05
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai05.csv", "data_Bai05#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai05.csv"), TestMethod]
        public void TestBai05()
        {
            Code_Module03 cls = new Code_Module03();

            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            String exp = TestContext.DataRow[3].ToString();
            String act = cls.Triangle(a, b, c);
            Assert.AreEqual(exp, act);
        }
    }
}