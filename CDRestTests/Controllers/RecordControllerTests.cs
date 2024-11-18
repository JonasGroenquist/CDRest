using Microsoft.VisualStudio.TestTools.UnitTesting;
using CDRest.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDRest.Repositories;

namespace CDRest.Controllers.Tests
{
    [TestClass()]
    public class RecordControllerTests
    {
        RecordController controller;
        RecordRepo repo;
        [TestInitialize]
        public void Setup()
        {
            repo = new RecordRepo();
            controller = new RecordController(repo);
        }
        [TestMethod()]
        public void GetTest()
        {
            Assert.AreEqual(2, controller.Get().Value.Count());
        }
    }
}