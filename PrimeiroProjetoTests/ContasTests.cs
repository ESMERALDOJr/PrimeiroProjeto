using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 10;
            var contas = new Contas();

            var result = contas.Soma(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 0;
            var contas = new Contas();

            var result = contas.Subtracao(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 1;
            var contas = new Contas();

            var result = contas.Divisao(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 25;
            var contas = new Contas();

            var result = contas.Multiplicacao(a, b);

            Assert.AreEqual(esperado, result);
        }
    }
}