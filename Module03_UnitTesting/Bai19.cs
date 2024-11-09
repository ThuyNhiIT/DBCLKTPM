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
    public class Bai19
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai19.csv", "data_Bai19#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai19.csv"), TestMethod]
        public void TestBai19()
        {
            Code_Module03 cls = new Code_Module03();

            int height = int.Parse(TestContext.DataRow[0].ToString());
            int weight = int.Parse(TestContext.DataRow[1].ToString());

            int result = int.Parse(TestContext.DataRow[2].ToString());

            int result_act = cls.BodyCheck(height, weight);
            Assert.AreEqual(result, result_act);
        }
    }
}