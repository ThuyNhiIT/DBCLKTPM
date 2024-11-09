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
    public class Bai10
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai10.csv", "data_Bai10#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai10.csv"), TestMethod]
        public void TestBai10()
        {
            Code_Module03 cls = new Code_Module03();
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());
            float c = float.Parse(TestContext.DataRow[2].ToString());

            bool result = bool.Parse(TestContext.DataRow[3].ToString());

            bool result_act = cls.KiemTraTamGiac(a, b, c);
            Assert.AreEqual(result, result_act);
        }
    }
}