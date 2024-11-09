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
    public class Bai08
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai08.csv", "data_Bai08#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai08.csv"), TestMethod]
        public void TestBai08()
        {
            Code_Module03 cls = new Code_Module03();

         
            double a = double.Parse(TestContext.DataRow[0].ToString());
            double b = double.Parse(TestContext.DataRow[1].ToString());
            double c = double.Parse(TestContext.DataRow[2].ToString());
            double x1 = double.Parse(TestContext.DataRow[3].ToString());
            double x2 = double.Parse(TestContext.DataRow[4].ToString());

            var result = cls.PhuongTrinhBacHai(a, b, c);
            Assert.AreEqual(x1, (double)result.x1, 0.2);
            Assert.AreEqual(x2, (double)result.x2, 0.2);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai08.csv", "data_Bai08#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai08.csv"), TestMethod]
        public void TestMethodExceptionBai08()
        {
            Code_Module03 cls = new Code_Module03();

            double a = double.Parse(TestContext.DataRow[0].ToString());
            double b = double.Parse(TestContext.DataRow[1].ToString());
            double c = double.Parse(TestContext.DataRow[2].ToString());
            string x1 = TestContext.DataRow[3].ToString();
            string x2 = TestContext.DataRow[4].ToString();

            var result = cls.PhuongTrinhBacHai(a, b, c);
            Assert.AreEqual(x1, x1);
            Assert.AreEqual(x2, x2);
        }
    }
}