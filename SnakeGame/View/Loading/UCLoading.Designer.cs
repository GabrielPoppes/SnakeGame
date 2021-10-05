
namespace SnakeGame.View.Loading
{
    partial class UCLoading
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConectando = new System.Windows.Forms.Label();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.lblGame = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureSnake = new System.Windows.Forms.PictureBox();
            this.panelPurple.SuspendLayout();
            this.panelWhite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSnake)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panelPurple.Controls.Add(this.label1);
            this.panelPurple.Controls.Add(this.pictureSnake);
            this.panelPurple.Controls.Add(this.lblConectando);
            this.panelPurple.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPurple.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelPurple.Location = new System.Drawing.Point(0, 200);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(800, 302);
            this.panelPurple.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clique na cobra para entrar no jogo...";
            // 
            // lblConectando
            // 
            this.lblConectando.AutoSize = true;
            this.lblConectando.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectando.ForeColor = System.Drawing.Color.White;
            this.lblConectando.Location = new System.Drawing.Point(339, 3);
            this.lblConectando.Name = "lblConectando";
            this.lblConectando.Size = new System.Drawing.Size(93, 19);
            this.lblConectando.TabIndex = 0;
            this.lblConectando.Text = "Conectando...";
            // 
            // panelWhite
            // 
            this.panelWhite.Controls.Add(this.pictureBox2);
            this.panelWhite.Controls.Add(this.lblGame);
            this.panelWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWhite.Location = new System.Drawing.Point(0, 0);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(800, 200);
            this.panelWhite.TabIndex = 1;
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.Location = new System.Drawing.Point(335, 176);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(106, 21);
            this.lblGame.TabIndex = 1;
            this.lblGame.Text = "Snake Game";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SnakeGame.Properties.Resources.games;
            this.pictureBox2.Location = new System.Drawing.Point(289, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureSnake
            // 
            this.pictureSnake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSnake.Image = global::SnakeGame.Properties.Resources.snake__1_;
            this.pictureSnake.Location = new System.Drawing.Point(238, 80);
            this.pictureSnake.Name = "pictureSnake";
            this.pictureSnake.Size = new System.Drawing.Size(289, 198);
            this.pictureSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSnake.TabIndex = 1;
            this.pictureSnake.TabStop = false;
            this.pictureSnake.Click += new System.EventHandler(this.pictureSnake_Click);
            // 
            // UCLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelWhite);
            this.Controls.Add(this.panelPurple);
            this.Name = "UCLoading";
            this.Size = new System.Drawing.Size(800, 502);
            this.Load += new System.EventHandler(this.UCLoading_Load);
            this.panelPurple.ResumeLayout(false);
            this.panelPurple.PerformLayout();
            this.panelWhite.ResumeLayout(false);
            this.panelWhite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSnake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.PictureBox pictureSnake;
        private System.Windows.Forms.Label lblConectando;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}
