namespace bd_14
{
    partial class frmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.cbxsexo = new System.Windows.Forms.ComboBox();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.imgfoto = new System.Windows.Forms.PictureBox();
            this.btnfoto = new System.Windows.Forms.Button();
            this.ofdfoto = new System.Windows.Forms.OpenFileDialog();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "data de nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "nota";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(22, 37);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 20);
            this.txtmatricula.TabIndex = 5;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(209, 37);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 6;
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(378, 87);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(100, 20);
            this.txtnota.TabIndex = 7;
            // 
            // cbxsexo
            // 
            this.cbxsexo.FormattingEnabled = true;
            this.cbxsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxsexo.Location = new System.Drawing.Point(236, 86);
            this.cbxsexo.Name = "cbxsexo";
            this.cbxsexo.Size = new System.Drawing.Size(121, 21);
            this.cbxsexo.TabIndex = 8;
            // 
            // dtpdata
            // 
            this.dtpdata.Location = new System.Drawing.Point(22, 86);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(200, 20);
            this.dtpdata.TabIndex = 9;
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(11, 376);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(240, 50);
            this.btnnovo.TabIndex = 11;
            this.btnnovo.Text = "novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(257, 376);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(210, 49);
            this.btnvoltar.TabIndex = 15;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // imgfoto
            // 
            this.imgfoto.Location = new System.Drawing.Point(507, 28);
            this.imgfoto.Name = "imgfoto";
            this.imgfoto.Size = new System.Drawing.Size(260, 337);
            this.imgfoto.TabIndex = 16;
            this.imgfoto.TabStop = false;
            // 
            // btnfoto
            // 
            this.btnfoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfoto.Location = new System.Drawing.Point(508, 376);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(259, 49);
            this.btnfoto.TabIndex = 17;
            this.btnfoto.Text = "escolher foto";
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // ofdfoto
            // 
            this.ofdfoto.FileName = "openFileDialog1";
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(11, 170);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(467, 183);
            this.dtglistar.TabIndex = 10;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistar_CellContentClick);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.imgfoto);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.dtglistar);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.cbxsexo);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.ComboBox cbxsexo;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.PictureBox imgfoto;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.OpenFileDialog ofdfoto;
        private System.Windows.Forms.DataGridView dtglistar;
    }
}

