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
        FileInfo arquivoLista = new FileInfo(Application.StartupPath + @"\ListaDePlacares.csv");
        bool leuLista = false;
        int nJogo = 1;
        int pMax = 0;
        int pMin = 0;
        public DesafioBasquete()
        {
            InitializeComponent();
            MaximizeBox = false;

            //Ler lista
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
                            #region Cria label com a pontuação máxima da temporada
                            if (Int16.Parse(linha) > pMax)
                            {
                                pMax = Int16.Parse(linha);
                            }/*
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
                            */
                            nJogo++;
                        }
                    }
                }
                leitorLista.Close();
                leuLista = true;
            }
        }

        private void AdicionarJogo_Click(object sender, EventArgs e)
        {
            string placar = Interaction.InputBox("Informe o placar", "Adicionar placar", "", 100, 100);

        }
    }
}
