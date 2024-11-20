using Microsoft.VisualStudio.TestTools.UnitTesting;
using CDRest.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDRest.Repositories;
using CDRest.Model;

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
            List<Record> records = repo.GetAll();
            Assert.AreEqual(3, records.Count);
        }

        [TestMethod]
        public void FilterTest() { 
            List<Record> records = repo.GetAll();
            Assert.AreEqual(3, records.Count);
            records = repo.GetAll(artist: "Art");
            Assert.AreEqual(2, records.Count);
            records = repo.GetAll(artist: "3");
            Assert.AreEqual(1, records.Count);
            records = repo.GetAll(sortBy: "Year");
            Assert.AreEqual(1919, records[0].Year);


        }
    }
}