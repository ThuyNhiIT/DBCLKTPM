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
    public class Bai14
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai14.csv", "data_Bai14#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai14.csv"), TestMethod]
        public void TestBai14()
        {
            Code_Module03 cls = new Code_Module03();
            float w = float.Parse(TestContext.DataRow[0].ToString());
            float h = float.Parse(TestContext.DataRow[1].ToString());
            float x = float.Parse(TestContext.DataRow[2].ToString());
            float y = float.Parse(TestContext.DataRow[3].ToString());
            float s = float.Parse(TestContext.DataRow[4].ToString());

            var result = cls.TaoIcon(w, h);

            Assert.AreEqual(x, (float)result.x);
            Assert.AreEqual(y, (float)result.y);
            Assert.AreEqual(s, (float)result.s);

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
       
        public void TestMethodExceptionBai14()
        {
            Code_Module03 cls = new Code_Module03();

            var result = cls.TaoIcon(-1, -0);
            Assert.AreEqual("error", result.x);
            Assert.AreEqual("error", result.y);
            Assert.AreEqual("error", result.s);
        }
    }
}