﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03_UnitTesting
{

    [TestClass]
    public class Bai18
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data_Bai18.csv", "data_Bai18#csv", DataAccessMethod.Sequential), DeploymentItem("data_Bai18.csv"), TestMethod]
        public void TestBai18()
        {
            Code_Module03 cls = new Code_Module03();

            String email = TestContext.DataRow[0].ToString();

            bool result = bool.Parse(TestContext.DataRow[1].ToString());

            bool result_act = cls.KiemTraEmail(email);
            Assert.AreEqual(result, result_act);
        }
    }
}