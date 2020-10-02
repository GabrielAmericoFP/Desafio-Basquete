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
using Microsoft.VisualBasic;

namespace Desafio_Basquete
{
    public partial class DesafioBasquete : Form
    {
        #region Variáveis
        //Informações do arquivo contendo informações da tabela
        FileInfo arquivoLista = new FileInfo(Application.StartupPath + @"\ListaDePlacares.csv");

        //Booleano que informa se o arquivo já foi lido
        bool leuLista = false;

        //Inteiros que verificam dados importantes da tabela
        int nJogo = 1;
        int pMax = 0;
        int pMin = 0;
        int qMax = 0;
        int qMin = 0;
        #endregion
        public DesafioBasquete()
        {
            //Inicializa a UI com o botão de maximizar desabilitado
            InitializeComponent();
            MaximizeBox = false;

            #region Atualiza a tabela
            if (leuLista == false && arquivoLista.Exists)
            {
                StreamReader leitorLista = new StreamReader(arquivoLista.FullName);
                while (!leitorLista.EndOfStream)
                {
                    String linha = leitorLista.ReadLine();
                    if (!String.IsNullOrWhiteSpace(linha))
                    {
                        String[] valores = linha.Split(',');
                        if (valores.Length >= 1)
                        {
                            # region Cria label com o número do jogo
                            Label labelJogo = new Label();
                            labelJogo.Dock = System.Windows.Forms.DockStyle.Fill;
                            labelJogo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelJogo.Location = new System.Drawing.Point(4, 42);
                            labelJogo.Name = "labelJogo" + linha;
                            labelJogo.Size = new System.Drawing.Size(48, 238);
                            labelJogo.TabIndex = 6;
                            labelJogo.Text = "" + nJogo;
                            labelJogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            this.tableLayoutPanel1.Controls.Add(labelJogo);
                            #endregion
                            #region Cria label com o placar no jogo
                            Label labelPlacar = new Label();
                            labelPlacar.Dock = System.Windows.Forms.DockStyle.Fill;
                            labelPlacar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelPlacar.Location = new System.Drawing.Point(4, 42);
                            labelPlacar.Name = "labelPlacar" + nJogo;
                            labelPlacar.Size = new System.Drawing.Size(48, 238);
                            labelPlacar.TabIndex = 6;
                            labelPlacar.Text = linha;
                            labelPlacar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            this.tableLayoutPanel1.Controls.Add(labelPlacar);
                            #endregion
                            #region Cria label com a pontuação mínima da temporada
                            if (Int16.Parse(linha) < pMax)
                            {
                                pMin = Int16.Parse(linha);
                            }
                            Label labelPMin = new Label();
                            labelPMin.Dock = System.Windows.Forms.DockStyle.Fill;
                            labelPMin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelPMin.Location = new System.Drawing.Point(4, 42);
                            labelPMin.Name = "labelPlacar" + nJogo;
                            labelPMin.Size = new System.Drawing.Size(48, 238);
                            labelPMin.TabIndex = 6;
                            labelPMin.Text = "" + pMax;
                            labelPMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            this.tableLayoutPanel1.Controls.Add(labelPMin);
                            #endregion
                            #region Cria label com a pontuação máxima da temporada
                            if (Int16.Parse(linha) > pMax)
                            {
                                pMax = Int16.Parse(linha);
                            }
                            Label labelPMax = new Label();
                            labelPMax.Dock = System.Windows.Forms.DockStyle.Fill;
                            labelPMax.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelPMax.Location = new System.Drawing.Point(4, 42);
                            labelPMax.Name = "labelPlacar" + nJogo;
                            labelPMax.Size = new System.Drawing.Size(48, 238);
                            labelPMax.TabIndex = 6;
                            labelPMax.Text = "" + pMax;
                            labelPMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            this.tableLayoutPanel1.Controls.Add(labelPMax);
                            #endregion
                            #region Cria label com a quantidade de vezes que a pontuação mínima foi quebrada

                            #endregion
                            nJogo++;
                        }
                    }
                }
                leitorLista.Close();
                leuLista = true;
            }
            #endregion
        }

        private void AdicionarJogo_Click(object sender, EventArgs e)
        {
            string placar = Interaction.InputBox("Informe o placar", "Adicionar placar", "", 100, 100);

        }
    }
}
