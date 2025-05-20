namespace JogoDaVelha
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbJogoVelha = new System.Windows.Forms.GroupBox();
            this.btn33 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbJogoVelha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DarkRed;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechar.Location = new System.Drawing.Point(503, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(117, 82);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JogoDaVelha.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grbJogoVelha
            // 
            this.grbJogoVelha.BackgroundImage = global::JogoDaVelha.Properties.Resources.JogoVelha;
            this.grbJogoVelha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grbJogoVelha.Controls.Add(this.btn33);
            this.grbJogoVelha.Controls.Add(this.btn32);
            this.grbJogoVelha.Controls.Add(this.btn31);
            this.grbJogoVelha.Controls.Add(this.btn23);
            this.grbJogoVelha.Controls.Add(this.btn22);
            this.grbJogoVelha.Controls.Add(this.btn21);
            this.grbJogoVelha.Controls.Add(this.btn13);
            this.grbJogoVelha.Controls.Add(this.btn12);
            this.grbJogoVelha.Controls.Add(this.btn11);
            this.grbJogoVelha.Location = new System.Drawing.Point(23, 193);
            this.grbJogoVelha.Name = "grbJogoVelha";
            this.grbJogoVelha.Size = new System.Drawing.Size(471, 368);
            this.grbJogoVelha.TabIndex = 0;
            this.grbJogoVelha.TabStop = false;
            this.grbJogoVelha.Text = "Jogo Da Velha";
            // 
            // btn33
            // 
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn33.Location = new System.Drawing.Point(281, 236);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(71, 53);
            this.btn33.TabIndex = 8;
            this.btn33.UseVisualStyleBackColor = true;
            this.btn33.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn32
            // 
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn32.Location = new System.Drawing.Point(195, 236);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(71, 53);
            this.btn32.TabIndex = 7;
            this.btn32.UseVisualStyleBackColor = true;
            this.btn32.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn31
            // 
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn31.Location = new System.Drawing.Point(109, 236);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(71, 53);
            this.btn31.TabIndex = 6;
            this.btn31.UseVisualStyleBackColor = true;
            this.btn31.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn23
            // 
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn23.Location = new System.Drawing.Point(281, 163);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(71, 53);
            this.btn23.TabIndex = 5;
            this.btn23.UseVisualStyleBackColor = true;
            this.btn23.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn22
            // 
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Location = new System.Drawing.Point(195, 163);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(71, 53);
            this.btn22.TabIndex = 4;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn21
            // 
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Location = new System.Drawing.Point(109, 163);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(71, 53);
            this.btn21.TabIndex = 3;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn13
            // 
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Location = new System.Drawing.Point(281, 87);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(64, 53);
            this.btn13.TabIndex = 2;
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn12
            // 
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Location = new System.Drawing.Point(195, 85);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(71, 56);
            this.btn12.TabIndex = 1;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btn11
            // 
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Location = new System.Drawing.Point(109, 85);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(71, 53);
            this.btn11.TabIndex = 0;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.Jogada_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(334, 12);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(112, 82);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(294, 121);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(296, 55);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "É a vez do X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 573);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbJogoVelha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbJogoVelha.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbJogoVelha;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblInfo;
    }
}

