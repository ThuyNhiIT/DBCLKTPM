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
    public class Bai12
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai12.csv", "data_Bai12#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai12.csv"), TestMethod]
        public void TestBai12()
        {
            Code_Module03 cls = new Code_Module03();
            float total = float.Parse(TestContext.DataRow[0].ToString());
            float p1 = float.Parse(TestContext.DataRow[1].ToString());
            float p2 = float.Parse(TestContext.DataRow[2].ToString());
            float p3 = float.Parse(TestContext.DataRow[3].ToString());
            float result = float.Parse(TestContext.DataRow[4].ToString());

            float result_act = cls.TinhGiaNhieuMuc(total, p1, p2, p3);
            Assert.AreEqual(result, result_act);

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
       
        public void TestMethodExceptionBai12()
        {
            Code_Module03 cls = new Code_Module03();

            float result_act = cls.TinhGiaNhieuMuc(-1, 1,2,3);
            Assert.AreEqual("exception", result_act);
        }
    }
}