using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Desafio_Basquete;

namespace Teste_Unitário_Basquete
{
    /// <summary>
    /// <c>TestadorDeTabelas</c> é uma classe feita para a realização de testes unitários.
    /// Possui como variável o caminho do arquivo de testes, na área de trabalho do usuário.
    /// </summary>
    [TestClass]
    public class TestadorDeTabelas
    {
        FileInfo caminhoArquivo = new FileInfo(@"C:\Users\" + Environment.UserName + @"\Desktop\test.csv");
        /// <summary>
        /// O método <c>TesteAdicionarPlacares</c> testa se o número do jogo, o recorde  máximo e o recorde mínimo estão corretos.
        /// Cria um arquivo de teste na área de trabalho (ou o limpa, se já existir), instancia a classe DesafioBasquete e realiza os testes com o método AdicionaPlacar.
        /// </summary>
        [TestMethod]
        public void TesteAdicionarPlacares()
        {
            File.WriteAllText(caminhoArquivo.FullName, "");
            var reader = new StreamReader(caminhoArquivo.FullName);
            DesafioBasquete teste = new DesafioBasquete(reader, caminhoArquivo);

            Assert.AreEqual(1, teste.nJogo);
            teste.AdicionaPlacar("100",caminhoArquivo);
            Assert.AreEqual(100, teste.pMax);
            Assert.AreEqual(100, teste.pMin);

            Assert.AreEqual(2, teste.nJogo);
            teste.AdicionaPlacar("90", caminhoArquivo);
            Assert.AreEqual(100, teste.pMax);
            Assert.AreEqual(90, teste.pMin);

            Assert.AreEqual(3, teste.nJogo);
            teste.AdicionaPlacar("110", caminhoArquivo);
            Assert.AreEqual(110, teste.pMax);
            Assert.AreEqual(90, teste.pMin);
        }
    }
}
