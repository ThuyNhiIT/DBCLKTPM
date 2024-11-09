using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Module03_Library;

namespace Module03_UnitTesting
{
    [TestClass]
    public class Bai03
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai03.csv", "data_Bai03#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai03.csv"), TestMethod]

        public void TestBai03()
        {
            Code_Module03 cls = new Code_Module03();
            double mean_act;
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            int max_exp = int.Parse(TestContext.DataRow[3].ToString());
            double mean_exp = double.Parse(TestContext.DataRow[4].ToString());
            int max_act = cls.MaxAndMean(a, b, c, out mean_act);
            Assert.AreEqual(max_exp, max_act);
            Assert.AreEqual(mean_exp, mean_act);
        }

    }
}
