using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecuaciones;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //tolerancia
        private double tol = Math.Pow(10, -10000000);
        //test para ecuaciones de primer grado
        [TestMethod]
        public void TestMethod1()
        {
            int a = 0;
            int b=1;
            int c=1;
            double x;
            ResolverEcuacionesPrimer.resolve(a, b, c, out x);
            Assert.AreEqual(double.NaN, x);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 1;
            int b = 1;
            int c = 0;
            double x;
            ResolverEcuacionesPrimer.resolve(a, b, c, out x);
            Assert.AreEqual(-1, x,tol);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a = -1;
            int b = 0;
            int c = 2;
            double x;
            ResolverEcuacionesPrimer.resolve(a, b, c, out x);
            Assert.AreEqual((double)2/(-1), x,tol);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int a = 2;
            int b = -9;
            int c = 3;
            double x;
            ResolverEcuacionesPrimer.resolve(a, b, c, out x);
            Assert.AreEqual(6, x,tol);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int a = 2;
            int b = 0;
            int c = 0;
            double x;
            ResolverEcuacionesPrimer.resolve(a, b, c, out x);
            Assert.AreEqual(0, x,tol);
        }
        //test para ecuaciones de segundo grado
        [TestMethod]
        public void TestMethod6()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d=0;
            double x1,x2
            ResolverEcuacionesSegundo.resolve(a, b, c,d, out x1,out x2);
            Assert.AreEqual(double.NaN, x1);
            Assert.AreEqual(double.NaN, x2);
        }
    }
}
