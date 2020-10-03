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

namespace Desafio_Basquete
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// Habilita a GUI e inicia o programa, usando como parâmetro a posição do arquivo .csv. Cria o arquivo caso ele não exista.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileInfo arquivoLista = new FileInfo(Application.StartupPath + @"\ListaDePlacares.csv");
            if (!arquivoLista.Exists)
            {
                File.WriteAllText(arquivoLista.FullName, "");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DesafioBasquete(arquivoLista));
            
        }
    }
}
