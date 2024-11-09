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
    public class Bai11
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai11.csv", "data_Bai11#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai11.csv"), TestMethod]
        public void TestBai11()
        {
            Code_Module03 cls = new Code_Module03();
            float w = float.Parse(TestContext.DataRow[0].ToString());
            float h = float.Parse(TestContext.DataRow[1].ToString());
            float ww = float.Parse(TestContext.DataRow[2].ToString());
            float wh = float.Parse(TestContext.DataRow[3].ToString());
            float x = float.Parse(TestContext.DataRow[4].ToString());
            float y = float.Parse(TestContext.DataRow[5].ToString());

            var result = cls.CanGiuaAnh(w, h, ww, wh);
            Assert.AreEqual(x, result.Item1);
            Assert.AreEqual(y, result.Item2);


        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
       
        public void TestMethodExceptionBai11()
        {
            Code_Module03 cls = new Code_Module03();

            var result = cls.CanGiuaAnh(0,1,1,1);
            Assert.AreEqual("exception", result.Item1);
            Assert.AreEqual("exception", result.Item2);
        }
    }
}