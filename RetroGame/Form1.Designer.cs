namespace RetroGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btComecar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNumeroJogadores = new System.Windows.Forms.ComboBox();
            this.rbMapaTradicional = new System.Windows.Forms.RadioButton();
            this.cbDado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbMapaAleatorio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtJogador1 = new RetroGame.Extensions.PlaceHolderTextBox();
            this.txtJogador2 = new RetroGame.Extensions.PlaceHolderTextBox();
            this.txtJogador3 = new RetroGame.Extensions.PlaceHolderTextBox();
            this.txtJogador4 = new RetroGame.Extensions.PlaceHolderTextBox();
            this.txtJogador8 = new RetroGame.Extensions.PlaceHolderTextBox();
            this.txtJogador7 = new RetroGame.Extensions.PlaceHolderTextBox();
            this.txtJogador6 = new RetroGame.Extensions.PlaceHolderTextBox();
            this.txtJogador5 = new RetroGame.Extensions.PlaceHolderTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // btComecar
            // 
            this.btComecar.Location = new System.Drawing.Point(467, 361);
            this.btComecar.Name = "btComecar";
            this.btComecar.Size = new System.Drawing.Size(109, 50);
            this.btComecar.TabIndex = 0;
            this.btComecar.Text = "Começar";
            this.btComecar.UseVisualStyleBackColor = true;
            this.btComecar.Click += new System.EventHandler(this.btComecar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantos Jogadores?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Mapa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Dado:";
            // 
            // cbNumeroJogadores
            // 
            this.cbNumeroJogadores.FormattingEnabled = true;
            this.cbNumeroJogadores.Location = new System.Drawing.Point(256, 93);
            this.cbNumeroJogadores.Name = "cbNumeroJogadores";
            this.cbNumeroJogadores.Size = new System.Drawing.Size(42, 23);
            this.cbNumeroJogadores.TabIndex = 4;
            this.cbNumeroJogadores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbMapaTradicional
            // 
            this.rbMapaTradicional.AutoSize = true;
            this.rbMapaTradicional.Location = new System.Drawing.Point(8, 22);
            this.rbMapaTradicional.Name = "rbMapaTradicional";
            this.rbMapaTradicional.Size = new System.Drawing.Size(82, 19);
            this.rbMapaTradicional.TabIndex = 5;
            this.rbMapaTradicional.TabStop = true;
            this.rbMapaTradicional.Text = "Tradicional";
            this.rbMapaTradicional.UseVisualStyleBackColor = true;
            // 
            // cbDado
            // 
            this.cbDado.FormattingEnabled = true;
            this.cbDado.Location = new System.Drawing.Point(257, 179);
            this.cbDado.Name = "cbDado";
            this.cbDado.Size = new System.Drawing.Size(42, 23);
            this.cbDado.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Faces";
            // 
            // rbMapaAleatorio
            // 
            this.rbMapaAleatorio.AutoSize = true;
            this.rbMapaAleatorio.Location = new System.Drawing.Point(96, 22);
            this.rbMapaAleatorio.Name = "rbMapaAleatorio";
            this.rbMapaAleatorio.Size = new System.Drawing.Size(73, 19);
            this.rbMapaAleatorio.TabIndex = 8;
            this.rbMapaAleatorio.TabStop = true;
            this.rbMapaAleatorio.Text = "Aleatório";
            this.rbMapaAleatorio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMapaAleatorio);
            this.groupBox1.Controls.Add(this.rbMapaTradicional);
            this.groupBox1.Location = new System.Drawing.Point(256, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 51);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txtJogador1
            // 
            this.txtJogador1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtJogador1.ForeColor = System.Drawing.Color.Gray;
            this.txtJogador1.Location = new System.Drawing.Point(763, 60);
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.PlaceHolderText = "Jogador 1";
            this.txtJogador1.Size = new System.Drawing.Size(172, 23);
            this.txtJogador1.TabIndex = 10;
            this.txtJogador1.Text = "Jogador 1";
            // 
            // txtJogador2
            // 
            this.txtJogador2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtJogador2.ForeColor = System.Drawing.Color.Gray;
            this.txtJogador2.Location = new System.Drawing.Point(763, 96);
            this.txtJogador2.Name = "txtJogador2";
            this.txtJogador2.PlaceHolderText = "Jogador 2";
            this.txtJogador2.Size = new System.Drawing.Size(172, 23);
            this.txtJogador2.TabIndex = 11;
            this.txtJogador2.Text = "Jogador 2\r\n";
            // 
            // txtJogador3
            // 
            this.txtJogador3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtJogador3.ForeColor = System.Drawing.Color.Gray;
            this.txtJogador3.Location = new System.Drawing.Point(763, 134);
            this.txtJogador3.Name = "txtJogador3";
            this.txtJogador3.PlaceHolderText = "Jogador 3";
            this.txtJogador3.Size = new System.Drawing.Size(172, 23);
            this.txtJogador3.TabIndex = 12;
            this.txtJogador3.Text = "Jogador 3";
            // 
            // txtJogador4
            // 
            this.txtJogador4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtJogador4.ForeColor = System.Drawing.Color.Gray;
            this.txtJogador4.Location = new System.Drawing.Point(763, 170);
            this.txtJogador4.Name = "txtJogador4";
            this.txtJogador4.PlaceHolderText = "Jogador 4";
            this.txtJogador4.Size = new System.Drawing.Size(172, 23);
            this.txtJogador4.TabIndex = 13;
            this.txtJogador4.Text = "Jogador 4";
            // 
            // txtJogador8
            // 
            this.txtJogador8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtJogador8.ForeColor = System.Drawing.Color.Gray;
            this.txtJogador8.Location = new System.Drawing.Point(763, 319);
            this.txtJogador8.Name = "txtJogador8";
            this.txtJogador8.PlaceHolderText = "Jogador 8";
            this.txtJogador8.ReadOnly = true;
            this.txtJogador8.Size = new System.Drawing.Size(172, 23);
            this.txtJogador8.TabIndex = 17;
            this.txtJogador8.Text = "Jogador 8";
            // 
            // txtJogador7
            // 
            this.txtJogador7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtJogador7.ForeColor = System.Drawing.Color.Gray;
            this.txtJogador7.Location = new System.Drawing.Point(763, 278);
            this.txtJogador7.Name = "txtJogador7";
            this.txtJogador7.PlaceHolderText = "Jogador 7";
            this.txtJogador7.ReadOnly = true;
            this.txtJogador7.Size = new System.Drawing.Size(172, 23);
            this.txtJogador7.TabIndex = 16;
            this.txtJogador7.Text = "Jogador 7";
            // 
            // txtJogador6
            // 
            this.txtJogador6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtJogador6.ForeColor = System.Drawing.Color.Gray;
            this.txtJogador6.Location = new System.Drawing.Point(763, 240);
            this.txtJogador6.Name = "txtJogador6";
            this.txtJogador6.PlaceHolderText = "Jogador 6";
            this.txtJogador6.ReadOnly = true;
            this.txtJogador6.Size = new System.Drawing.Size(172, 23);
            this.txtJogador6.TabIndex = 15;
            this.txtJogador6.Text = "Jogador 6";
            // 
            // txtJogador5
            // 
            this.txtJogador5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtJogador5.ForeColor = System.Drawing.Color.Gray;
            this.txtJogador5.Location = new System.Drawing.Point(763, 204);
            this.txtJogador5.Name = "txtJogador5";
            this.txtJogador5.PlaceHolderText = "Jogador 5";
            this.txtJogador5.ReadOnly = true;
            this.txtJogador5.Size = new System.Drawing.Size(172, 23);
            this.txtJogador5.TabIndex = 14;
            this.txtJogador5.Text = "Jogador 5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(732, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(732, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(732, 134);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(732, 168);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.ImageLocation = "";
            this.pictureBox5.Location = new System.Drawing.Point(732, 202);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.ImageLocation = "";
            this.pictureBox6.Location = new System.Drawing.Point(732, 240);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.ImageLocation = "";
            this.pictureBox7.Location = new System.Drawing.Point(732, 278);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.ImageLocation = "";
            this.pictureBox8.Location = new System.Drawing.Point(732, 317);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtJogador8);
            this.Controls.Add(this.txtJogador7);
            this.Controls.Add(this.txtJogador6);
            this.Controls.Add(this.txtJogador5);
            this.Controls.Add(this.txtJogador4);
            this.Controls.Add(this.txtJogador3);
            this.Controls.Add(this.txtJogador2);
            this.Controls.Add(this.txtJogador1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDado);
            this.Controls.Add(this.cbNumeroJogadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btComecar);
            this.Name = "Form1";
            this.Text = "RetroGame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btComecar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbNumeroJogadores;
        private RadioButton rbMapaTradicional;
        private ComboBox cbDado;
        private Label label4;
        private RadioButton rbMapaAleatorio;
        private GroupBox groupBox1;
        private Extensions.PlaceHolderTextBox txtJogador1;
        private Extensions.PlaceHolderTextBox txtJogador2;
        private Extensions.PlaceHolderTextBox txtJogador3;
        private Extensions.PlaceHolderTextBox txtJogador4;
        private Extensions.PlaceHolderTextBox txtJogador8;
        private Extensions.PlaceHolderTextBox txtJogador7;
        private Extensions.PlaceHolderTextBox txtJogador6;
        private Extensions.PlaceHolderTextBox txtJogador5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}