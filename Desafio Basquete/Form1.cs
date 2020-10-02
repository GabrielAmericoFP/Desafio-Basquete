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
        #region Variáveis de classe
        //Informações do arquivo contendo informações da tabela
        FileInfo arquivoLista = new FileInfo(Application.StartupPath + @"\ListaDePlacares.csv");

        //Booleano que informa se o arquivo já foi lido
        bool leuLista = false;

        #endregion
        public DesafioBasquete()
        {
            //Inicializa a UI com o botão de maximizar desabilitado
            InitializeComponent();
            MaximizeBox = false;
            AtualizarTabela();
        }

        private void AdicionarJogo_Click(object sender, EventArgs e)
        {
            string placar = Interaction.InputBox("Informe o placar", "Adicionar placar", "", 100, 100);

        }

        private void AtualizarTabela()
        {

            #region Atualiza a tabela
            //Inteiros que verificam dados importantes da tabela
            int nJogo = 1;
            int pMax = 0;
            int pMin = 0;
            int qMax = 0;
            int qMin = 0;
            if (leuLista == false && arquivoLista.Exists)
            {
                //Chama uma variável do tipo StreamReader para ler o arquivo .csv
                StreamReader leitorLista = new StreamReader(arquivoLista.FullName);
                while (!leitorLista.EndOfStream)
                {
                    //Detecta o final da linha
                    String linha = leitorLista.ReadLine();
                    if (!String.IsNullOrWhiteSpace(linha))
                    {
                        //Guarda os valores do arquivo pela duração da leitura
                        String[] valores = linha.Split(',');
                        if (valores.Length >= 1)
                        {
                            //Cria outra linha na tabela
                            this.tableLayoutPanel1.RowCount++;
                            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
                            #region Cria label com o número do jogo
                            Label labelJogo = new Label();
                            labelJogo.Dock = System.Windows.Forms.DockStyle.Fill;
                            labelJogo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                            if (nJogo > 1)
                            {
                                if (Int16.Parse(linha) < pMin)
                                {
                                    pMin = Int16.Parse(linha);
                                    qMin++;
                                }
                            }
                            else
                            {
                                pMin = Int16.Parse(linha);
                            }
                            Label labelPMin = new Label();
                            labelPMin.Dock = System.Windows.Forms.DockStyle.Fill;
                            labelPMin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelPMin.Location = new System.Drawing.Point(4, 42);
                            labelPMin.Name = "labelPMin" + nJogo;
                            labelPMin.Size = new System.Drawing.Size(48, 238);
                            labelPMin.TabIndex = 6;
                            labelPMin.Text = "" + pMin;
                            labelPMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            this.tableLayoutPanel1.Controls.Add(labelPMin);
                            #endregion
                            #region Cria label com a pontuação máxima da temporada
                            if (nJogo > 1)
                            {
                                if (Int16.Parse(linha) > pMax)
                                {
                                    pMax = Int16.Parse(linha);
                                    qMax++;
                                }
                            }
                            else
                            {
                                pMax = Int16.Parse(linha);
                            }
                            Label labelPMax = new Label();
                            labelPMax.Dock = System.Windows.Forms.DockStyle.Fill;
                            labelPMax.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelPMax.Location = new System.Drawing.Point(4, 42);
                            labelPMax.Name = "labelPMax" + nJogo;
                            labelPMax.Size = new System.Drawing.Size(48, 238);
                            labelPMax.TabIndex = 6;
                            labelPMax.Text = "" + pMax;
                            labelPMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            this.tableLayoutPanel1.Controls.Add(labelPMax);
                            #endregion
                            #region Cria label com a quantidade de vezes que a pontuação mínima foi quebrada
                            Label labelQMin = new Label();
                            labelQMin.Dock = System.Windows.Forms.DockStyle.Fill;
                            labelQMin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelQMin.Location = new System.Drawing.Point(4, 42);
                            labelQMin.Name = "labelQMin" + nJogo;
                            labelQMin.Size = new System.Drawing.Size(48, 238);
                            labelQMin.TabIndex = 6;
                            labelQMin.Text = "" + qMin;
                            labelQMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            this.tableLayoutPanel1.Controls.Add(labelQMin);
                            #endregion
                            #region Cria label com a quantidade de vezes que a pontuação máxima foi quebrada
                            Label labelQMax = new Label();
                            labelQMax.Dock = System.Windows.Forms.DockStyle.Fill;
                            labelQMax.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelQMax.Location = new System.Drawing.Point(4, 42);
                            labelQMax.Name = "labelQMax" + nJogo;
                            labelQMax.Size = new System.Drawing.Size(48, 238);
                            labelQMax.TabIndex = 6;
                            labelQMax.Text = "" + qMax;
                            labelQMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            this.tableLayoutPanel1.Controls.Add(labelQMax);
                            #endregion
                            //Incrementa o número do jogo
                            nJogo++;
                        }
                    }
                }
                //Termina a leitura do arquivo
                leitorLista.Close();
                leuLista = true;
            }
            #endregion
        }
    }
}
