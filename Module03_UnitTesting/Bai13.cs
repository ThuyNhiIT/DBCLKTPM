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
    public class Bai13
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai13.csv", "data_Bai13#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai13.csv"), TestMethod]
        public void TestBai13()
        {
            Code_Module03 cls = new Code_Module03();
            float x1 = float.Parse(TestContext.DataRow[0].ToString());
            float y1 = float.Parse(TestContext.DataRow[1].ToString());
            float x2 = float.Parse(TestContext.DataRow[2].ToString());
            float y2 = float.Parse(TestContext.DataRow[3].ToString());
            float x = float.Parse(TestContext.DataRow[4].ToString());
            float y = float.Parse(TestContext.DataRow[5].ToString());
            bool result = bool.Parse(TestContext.DataRow[6].ToString());

            bool result_act = cls.KiemTraDiemHCN(x1, y1, x2, y2, x, y);
            Assert.AreEqual(result, result_act);

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
       
        public void TestMethodExceptionBai13()
        {
            Code_Module03 cls = new Code_Module03();

            bool result_act = cls.KiemTraDiemHCN(5,4,3,2,1,1);
            Assert.AreEqual("exception", result_act);
        }
    }
}