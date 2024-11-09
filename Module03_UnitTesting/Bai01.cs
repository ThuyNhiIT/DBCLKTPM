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
    public class Bai01
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai01.csv", "data_Bai01#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai01.csv"), TestMethod]

        public void TestBai01()
        {
            Code_Module03 cls = new Code_Module03();
            int firstRadius = int.Parse(TestContext.DataRow[0].ToString());
            int secRadius = int.Parse(TestContext.DataRow[1].ToString());
            int distance = int.Parse(TestContext.DataRow[2].ToString());

            try
            {
                int exp = int.Parse(TestContext.DataRow[3].ToString());

                int act = cls.GetPositionOf2Cir(firstRadius, secRadius, distance);
                Assert.AreEqual(exp, act);
            }
            catch (Exception ex)
            {
                Assert.ThrowsException<IndexOutOfRangeException>(() => cls.GetPositionOf2Cir(firstRadius, secRadius, distance));

            }
        }
    }
}
