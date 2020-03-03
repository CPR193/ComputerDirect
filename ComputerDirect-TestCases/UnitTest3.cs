using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputerDirect_TestCases
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staff = new clsStaff();
            Assert.IsNotNull(staff);
        }
    }
}
