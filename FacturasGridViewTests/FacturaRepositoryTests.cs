using Microsoft.VisualStudio.TestTools.UnitTesting;
using FacturasGridView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationTest.Utils;
using FacturasGridViewTests;

namespace FacturasGridView.Tests
{
    [TestClass()]
    public class FacturaRepositoryTests : IoCSupportedTest<FacturaRepositoryModule>
    {
        IRepository repository;

        [TestInitialize]
        public void Setup()
        {
            this.repository = Resolve<IRepository>();
        }

        [TestCleanup]
        public void CleanUp()
        {
            this.repository = null;
            ShutdownIoC();
        }

        [TestMethod()]
        public void AddFacturaTest()
        {
            repository.AddFactura(new Factura());
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetFacturasTest()
        {
            var facturas = repository.GetFacturas();
            Assert.IsInstanceOfType(facturas, typeof(List<Factura>));
        }
    }
}