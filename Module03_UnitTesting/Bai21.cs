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
    public class Bai21
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai21.csv", "data_Bai21#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai21.csv"), TestMethod]
        public void TestBai21()
        {
            Code_Module03 cls = new Code_Module03();
            string tmp = TestContext.DataRow[0].ToString();

            int result = int.Parse(TestContext.DataRow[1].ToString());

            long result_act = cls.HexToDec(tmp);
            Assert.AreEqual(result, result_act);
        }

      
    }
}