using System.Windows.Forms;

namespace GameRockPaperScissors
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imgCPU = new System.Windows.Forms.GroupBox();
            this.imgPlayer1 = new System.Windows.Forms.GroupBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.plcComputer = new System.Windows.Forms.Label();
            this.plcPlayer1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtResultado);
            this.splitContainer1.Panel1.Controls.Add(this.imgCPU);
            this.splitContainer1.Panel1.Controls.Add(this.imgPlayer1);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewGame);
            this.splitContainer1.Panel1.Controls.Add(this.btnExit);
            this.splitContainer1.Panel1.Controls.Add(this.btnRules);
            this.splitContainer1.Panel1.Controls.Add(this.grpResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnScissors);
            this.splitContainer1.Panel2.Controls.Add(this.btnPaper);
            this.splitContainer1.Panel2.Controls.Add(this.btnRock);
            this.splitContainer1.Size = new System.Drawing.Size(624, 441);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // imgCPU
            // 
            this.imgCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCPU.Location = new System.Drawing.Point(417, 21);
            this.imgCPU.Name = "imgCPU";
            this.imgCPU.Size = new System.Drawing.Size(190, 190);
            this.imgCPU.TabIndex = 11;
            this.imgCPU.TabStop = false;
            this.imgCPU.Text = "Computer";
            this.imgCPU.Enter += new System.EventHandler(this.ImgCPU_Enter);
            // 
            // imgPlayer1
            // 
            this.imgPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPlayer1.Location = new System.Drawing.Point(17, 20);
            this.imgPlayer1.Name = "imgPlayer1";
            this.imgPlayer1.Size = new System.Drawing.Size(190, 190);
            this.imgPlayer1.TabIndex = 10;
            this.imgPlayer1.TabStop = false;
            this.imgPlayer1.Text = "Player 1";
            this.imgPlayer1.Enter += new System.EventHandler(this.ImgPlayer1_Enter);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(17, 225);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 35);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "&New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(532, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnRules
            // 
            this.btnRules.Image = global::GameRockPaperScissors.Properties.Resources._1200px_Rock_paper_scissors_svg;
            this.btnRules.Location = new System.Drawing.Point(259, 20);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(110, 110);
            this.btnRules.TabIndex = 3;
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.BtnRules_Click);
            // 
            // grpResult
            // 
            this.grpResult.BackColor = System.Drawing.Color.LightGray;
            this.grpResult.Controls.Add(this.plcComputer);
            this.grpResult.Controls.Add(this.plcPlayer1);
            this.grpResult.Controls.Add(this.label2);
            this.grpResult.Controls.Add(this.label1);
            this.grpResult.Location = new System.Drawing.Point(223, 136);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(178, 99);
            this.grpResult.TabIndex = 2;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // plcComputer
            // 
            this.plcComputer.AutoSize = true;
            this.plcComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plcComputer.Location = new System.Drawing.Point(126, 65);
            this.plcComputer.Name = "plcComputer";
            this.plcComputer.Size = new System.Drawing.Size(24, 25);
            this.plcComputer.TabIndex = 2;
            this.plcComputer.Text = "0";
            this.plcComputer.Click += new System.EventHandler(this.Label3_Click);
            // 
            // plcPlayer1
            // 
            this.plcPlayer1.AutoSize = true;
            this.plcPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plcPlayer1.Location = new System.Drawing.Point(28, 65);
            this.plcPlayer1.Name = "plcPlayer1";
            this.plcPlayer1.Size = new System.Drawing.Size(24, 25);
            this.plcPlayer1.TabIndex = 2;
            this.plcPlayer1.Text = "0";
            this.plcPlayer1.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.Image = global::GameRockPaperScissors.Properties.Resources.scissors;
            this.btnScissors.Location = new System.Drawing.Point(442, 17);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(140, 140);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.BtnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Image = global::GameRockPaperScissors.Properties.Resources.paper;
            this.btnPaper.Location = new System.Drawing.Point(245, 17);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(140, 140);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.BtnPaper_Click);
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Image = ((System.Drawing.Image)(resources.GetObject("btnRock.Image")));
            this.btnRock.Location = new System.Drawing.Point(44, 17);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(140, 140);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.BtnRock_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(223, 241);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(178, 18);
            this.txtResultado.TabIndex = 10;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultado.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game  :::  Rock  -  Paper  -  Scissors";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label plcPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plcComputer;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.GroupBox imgCPU;
        private System.Windows.Forms.GroupBox imgPlayer1;
        private TextBox txtResultado;

        public PictureBox ImgPlayer { get => imgPlayer; set => imgPlayer = value; }
    }
}

