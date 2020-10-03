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
using System.Windows.Forms;
using System.Windows.Forms;

namespace Desafio_Basquete
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// Habilita a GUI e inicia o programa, usando como parâmetros o leitor e a posição do arquivo .csv.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DesafioBasquete(new StreamReader(Application.StartupPath + @"\ListaDePlacares.csv")
                , new FileInfo(Application.StartupPath + @"\ListaDePlacares.csv")));
            
        }
    }
}
