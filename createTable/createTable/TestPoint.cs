using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace createTable
{
    using NUnit.Framework;

    [TestFixture]
    class TestPoint
    {
        [Test]
        public void TestConstructor00()
        {
            Point p = new Point(0, 0);

            Assert.AreEqual(p.X, 0);
            Assert.AreEqual(p.Y, 0);
        }

        [Test]
        public void TestConstructor12()
        {
            Point p = new Point(1, 2);

            Assert.AreEqual(p.X, 1);
            Assert.AreEqual(p.Y, 2);
        }

    }
}
