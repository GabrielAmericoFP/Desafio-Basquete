namespace Desafio_Basquete
{
    partial class DesafioBasquete
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdicionarPlacar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.QuebraMax0 = new System.Windows.Forms.Label();
            this.QuebraMin0 = new System.Windows.Forms.Label();
            this.Maximo0 = new System.Windows.Forms.Label();
            this.Minimo0 = new System.Windows.Forms.Label();
            this.Placar0 = new System.Windows.Forms.Label();
            this.Jogo0 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LimparLista = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdicionarPlacar
            // 
            this.AdicionarPlacar.BackColor = System.Drawing.SystemColors.Control;
            this.AdicionarPlacar.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdicionarPlacar.Location = new System.Drawing.Point(0, 0);
            this.AdicionarPlacar.Name = "AdicionarPlacar";
            this.AdicionarPlacar.Size = new System.Drawing.Size(121, 56);
            this.AdicionarPlacar.TabIndex = 0;
            this.AdicionarPlacar.Text = "Adicionar Placar";
            this.AdicionarPlacar.UseVisualStyleBackColor = false;
            this.AdicionarPlacar.Click += new System.EventHandler(this.AdicionarJogo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.905371F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.590793F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.09974F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.3555F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.46036F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.58824F));
            this.tableLayoutPanel1.Controls.Add(this.QuebraMax0, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.QuebraMin0, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Maximo0, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Minimo0, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Placar0, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Jogo0, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 282);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // QuebraMax0
            // 
            this.QuebraMax0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuebraMax0.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuebraMax0.Location = new System.Drawing.Point(637, 1);
            this.QuebraMax0.Name = "QuebraMax0";
            this.QuebraMax0.Size = new System.Drawing.Size(159, 280);
            this.QuebraMax0.TabIndex = 5;
            this.QuebraMax0.Text = "Quebra recorde máx.";
            this.QuebraMax0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuebraMin0
            // 
            this.QuebraMin0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuebraMin0.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuebraMin0.Location = new System.Drawing.Point(474, 1);
            this.QuebraMin0.Name = "QuebraMin0";
            this.QuebraMin0.Size = new System.Drawing.Size(156, 280);
            this.QuebraMin0.TabIndex = 4;
            this.QuebraMin0.Text = "Quebra recorde min.";
            this.QuebraMin0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Maximo0
            // 
            this.Maximo0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maximo0.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximo0.Location = new System.Drawing.Point(304, 1);
            this.Maximo0.Name = "Maximo0";
            this.Maximo0.Size = new System.Drawing.Size(163, 280);
            this.Maximo0.TabIndex = 3;
            this.Maximo0.Text = "Máximo da temporada";
            this.Maximo0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Minimo0
            // 
            this.Minimo0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minimo0.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimo0.Location = new System.Drawing.Point(136, 1);
            this.Minimo0.Name = "Minimo0";
            this.Minimo0.Size = new System.Drawing.Size(161, 280);
            this.Minimo0.TabIndex = 2;
            this.Minimo0.Text = "Mínimo da temporada";
            this.Minimo0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Placar0
            // 
            this.Placar0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Placar0.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placar0.Location = new System.Drawing.Point(59, 1);
            this.Placar0.Name = "Placar0";
            this.Placar0.Size = new System.Drawing.Size(70, 280);
            this.Placar0.TabIndex = 1;
            this.Placar0.Text = "Placar";
            this.Placar0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Jogo0
            // 
            this.Jogo0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Jogo0.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jogo0.Location = new System.Drawing.Point(4, 1);
            this.Jogo0.Name = "Jogo0";
            this.Jogo0.Size = new System.Drawing.Size(48, 280);
            this.Jogo0.TabIndex = 0;
            this.Jogo0.Text = "Jogo";
            this.Jogo0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LimparLista);
            this.panel1.Controls.Add(this.AdicionarPlacar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 0;
            // 
            // LimparLista
            // 
            this.LimparLista.BackColor = System.Drawing.SystemColors.Control;
            this.LimparLista.Dock = System.Windows.Forms.DockStyle.Right;
            this.LimparLista.Location = new System.Drawing.Point(679, 0);
            this.LimparLista.Name = "LimparLista";
            this.LimparLista.Size = new System.Drawing.Size(121, 56);
            this.LimparLista.TabIndex = 1;
            this.LimparLista.Text = "Limpar Lista e Fechar";
            this.LimparLista.UseVisualStyleBackColor = false;
            this.LimparLista.Click += new System.EventHandler(this.LimparLista_Click);
            // 
            // DesafioBasquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DesafioBasquete";
            this.Text = "Desafio Basquete";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdicionarPlacar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label QuebraMax0;
        private System.Windows.Forms.Label QuebraMin0;
        private System.Windows.Forms.Label Maximo0;
        private System.Windows.Forms.Label Minimo0;
        private System.Windows.Forms.Label Placar0;
        private System.Windows.Forms.Label Jogo0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LimparLista;
    }
}

