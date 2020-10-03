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
    /// <summary>
    /// <c>DesafioBasquete</c> extende Form e é a classe principal do código.
    /// </summary>
    public partial class DesafioBasquete : Form
    {
        #region Variáveis de classe
        //Booleano que informa se o arquivo já foi lido
        bool leuLista = false;

        //Inteiros que verificam dados importantes da tabela
        public int nJogo = 1;
        public int pMax = 0;
        public int pMin = 0;
        public int qMax = 0;
        public int qMin = 0;

        //Informações do arquivo contendo informações da tabela
        FileInfo arquivoLista = new FileInfo(Application.StartupPath + @"\ListaDePlacares.csv");
        #endregion
        /// <summary>
        /// O método <c>DesafioBasquete</c> é responsável por inicializar o corpo do aplicativo.
        /// Desabilita o botão de maximizar, cria o arquivo .csv (caso ele não exista) e gera a tabela baseada no mesmo.
        /// </summary>
        /// <param name="caminhoArquivo">São as informações do arquivo .csv.</param>
        public DesafioBasquete(FileInfo caminhoArquivo)
        {
            //Inicializa a UI com o botão de maximizar desabilitado
            InitializeComponent();
            MaximizeBox = false;
            Size = new Size(816, 378);
            //Cria um novo arquivo para a tabela, caso ele não exista
            if (!caminhoArquivo.Exists)
            {
                File.WriteAllText(caminhoArquivo.FullName, "");
            }
            StreamReader leitorLista = new StreamReader(caminhoArquivo.FullName);
            //Atualiza a tabela
            if (!leuLista)
            {
                AtualizarTabela(leitorLista, caminhoArquivo);
            }
        }
        /// <summary>
        /// O método <c>AdicionarJogo_Click</c> é responsável pelas ações que ocorrerão ao clicar no botão "Adicionar Placar". 
        /// Pega o input do usuário e chama o método <c>AdicionaPlacar</c> utilizando a string placar como parâmetro.
        /// </summary>
        /// <param name="sender">É o botão.</param>
        /// <param name="e">São os eventos que deveriam ser executados junto ao botão.</param>
        private void AdicionarJogo_Click(object sender, EventArgs e)
        {
            //Pega input do usuário para adicionar à tabela
            string placar = Interaction.InputBox("Informe o placar. Deve ser um número positivo menor que mil.", "Adicionar placar", "", 100, 100);
            AdicionaPlacar(placar, arquivoLista);
        }
        /// <summary>
        /// O método <c>AdicionaPlacar</c> é responsável por escrever o placar no arquivo .csv e mostrá-lo na tabela.
        /// Ele cria um editor do arquivo .csv  e, após checar se a string placar é um número válido, adiciona-a à tabela.
        /// </summary>
        /// <param name="placar">Input do usuário.</param>
        /// <param name="caminhoArquivo">São as informações do arquivo .csv.</param>
        public void AdicionaPlacar(string placar, FileInfo caminhoArquivo)
        {
            //Cria uma variável do tipo StreamWriter para escrever no arquivo .csv
            StreamWriter escritorLista = new StreamWriter(caminhoArquivo.FullName, true);
            escritorLista.AutoFlush = false;
            #region Checa se a string placar é um número válido
            if (placar != "")
            {
                this.tableLayoutPanel1.SuspendLayout();
                if (int.TryParse(placar, out _))
                {
                    if (Int16.Parse(placar) >= 0)
                    {
                        if (Int16.Parse(placar) < 1000)
                        {
                            //Edita o arquivo
                            escritorLista.WriteLine(placar);

                            //Termina a edição do arquivo
                            escritorLista.Close();
                            #region Código para adicionar placares
                            //Cria outra linha na tabela
                            this.tableLayoutPanel1.RowCount++;
                            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
                            #region Cria label com o número do jogo
                            Label labelJogo = new Label();
                            labelJogo.Dock = System.Windows.Forms.DockStyle.Fill;
                            labelJogo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            labelJogo.Location = new System.Drawing.Point(4, 42);
                            labelJogo.Name = "labelJogo" + nJogo;
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
                            labelPlacar.Text = placar;
                            labelPlacar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                            this.tableLayoutPanel1.Controls.Add(labelPlacar);
                            #endregion
                            #region Cria label com a pontuação mínima da temporada
                            if (nJogo > 1)
                            {
                                if (Int16.Parse(placar) < pMin)
                                {
                                    pMin = Int16.Parse(placar);
                                    qMin++;
                                    labelPlacar.BackColor = Color.IndianRed;
                                }
                            }
                            else
                            {
                                pMin = Int16.Parse(placar);
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
                                if (Int16.Parse(placar) > pMax)
                                {
                                    pMax = Int16.Parse(placar);
                                    qMax++;
                                    labelPlacar.BackColor = Color.LightGreen;
                                }
                            }
                            else
                            {
                                pMax = Int16.Parse(placar);
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
                            this.tableLayoutPanel1.ResumeLayout();
                            #endregion
                        }
                        else
                        {
                            MessageBox.Show("O placar deve ser menor que mil.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            escritorLista.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O placar não pode ser negativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        escritorLista.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Apenas números são aceitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    escritorLista.Close();
                }
            }
            else
            {
                escritorLista.Close();
            }

            #endregion
        }
        /// <summary>
        /// O método <c>LimparLista_Click</c> é responsável pelas ações que ocorrerão ao clicar no botão "Limpar Lista e Fechar". 
        /// Mostra uma caixa de confirmação da ação. Se sim, apaga todo o conteúdo do arquivo .csv e reinicia o aplicativo.
        /// </summary>
        /// <param name="sender">É o botão.</param>
        /// <param name="e">São os eventos que deveriam ser executados junto ao botão.</param>
        private void LimparLista_Click(object sender, EventArgs e)
        {
            //Confirma se o usuário não clicou no botão por acidente
            DialogResult dr = MessageBox.Show("Tem certeza que deseja apagar todo o conteúdo da lista e reiniciar o programa?", "Limpar e Sair",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                File.WriteAllText(arquivoLista.FullName, "");
                Application.Restart();
            }
        }
        /// <summary>
        /// O método <c>AtualizarTabela</c> é responsável por atualizar o conteúdo da tabela com base no arquivo .csv. 
        /// Cria um leitor do arquivo .csv e adiciona labels à tabela com base nos números apresentados no .csv.
        /// </summary>
        public void AtualizarTabela(StreamReader leitorLista, FileInfo caminhoArquivo)
        {
            #region Atualiza a tabela
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
                        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 22f));
                        #region Cria label com o número do jogo
                        Label labelJogo = new Label();
                        labelJogo.Dock = System.Windows.Forms.DockStyle.Fill;
                        labelJogo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        labelJogo.Location = new System.Drawing.Point(4, 42);
                        labelJogo.Name = "labelJogo" + nJogo;
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
                                labelPlacar.BackColor = Color.IndianRed;
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
                                labelPlacar.BackColor = Color.LightGreen;
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
            #endregion
        }

    }
}
