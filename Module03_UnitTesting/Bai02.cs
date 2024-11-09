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

    public class Bai02
    {
        public TestContext TestContext { get; set; }
   
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai02.csv", "data_Bai02#csv", DataAccessMethod.Sequential), TestMethod]
        public void TestBai02()
        {
            Code_Module03 cls = new Code_Module03();
            int x = int.Parse(TestContext.DataRow[0].ToString());
            int y = int.Parse(TestContext.DataRow[1].ToString());
            int z = int.Parse(TestContext.DataRow[2].ToString());
            String result = TestContext.DataRow[3].ToString();

            string result_act = cls.CheckValue(x, y, z);
            Assert.AreEqual(result, result_act);
        }

    }
}
