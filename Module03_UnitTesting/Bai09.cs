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
    public class Bai09
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai09.csv", "data_Bai09#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai09.csv"), TestMethod]
        public void TestBai09()
        {
            Code_Module03 cls = new Code_Module03();
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());
            float x = float.Parse(TestContext.DataRow[2].ToString());

            float result = float.Parse(TestContext.DataRow[3].ToString());

            float result_act = cls.Limit(a, b, x);
            Assert.AreEqual(result, result_act);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBai09_Exception()
        {
            Code_Module03 cls = new Code_Module03();

            float result_act = cls.Limit(4,2,2);
            Assert.AreEqual("excption", result_act);
        }
    }
}