namespace bd_14
{
    partial class frmmudancas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.codigo = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.ofdfoto = new System.Windows.Forms.OpenFileDialog();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxsexo = new System.Windows.Forms.ComboBox();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnfoto = new System.Windows.Forms.Button();
            this.imgfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(53, 40);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(50, 13);
            this.codigo.TabIndex = 0;
            this.codigo.Text = "Matricula";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(53, 56);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 20);
            this.txtmatricula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(230, 56);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 3;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(53, 396);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 41);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(423, 396);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 42);
            this.btnvoltar.TabIndex = 5;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // ofdfoto
            // 
            this.ofdfoto.FileName = "openFileDialog1";
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(43, 216);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(466, 166);
            this.dtglistar.TabIndex = 7;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistar_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "data de nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "informacoes";
            // 
            // cbxsexo
            // 
            this.cbxsexo.FormattingEnabled = true;
            this.cbxsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxsexo.Location = new System.Drawing.Point(238, 158);
            this.cbxsexo.Name = "cbxsexo";
            this.cbxsexo.Size = new System.Drawing.Size(121, 21);
            this.cbxsexo.TabIndex = 11;
            // 
            // dtpdata
            // 
            this.dtpdata.Location = new System.Drawing.Point(53, 159);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(172, 20);
            this.dtpdata.TabIndex = 12;
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(398, 56);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(100, 20);
            this.txtnota.TabIndex = 13;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(185, 396);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 42);
            this.btnalterar.TabIndex = 14;
            this.btnalterar.Text = "alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(308, 396);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 42);
            this.btnexcluir.TabIndex = 15;
            this.btnexcluir.Text = "excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnfoto
            // 
            this.btnfoto.Location = new System.Drawing.Point(560, 396);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(227, 41);
            this.btnfoto.TabIndex = 16;
            this.btnfoto.Text = "escolher foto";
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // imgfoto
            // 
            this.imgfoto.Location = new System.Drawing.Point(560, 12);
            this.imgfoto.Name = "imgfoto";
            this.imgfoto.Size = new System.Drawing.Size(228, 370);
            this.imgfoto.TabIndex = 6;
            this.imgfoto.TabStop = false;
            // 
            // frmmudancas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.cbxsexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtglistar);
            this.Controls.Add(this.imgfoto);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.codigo);
            this.Name = "frmmudancas";
            this.Text = "analise";
            this.Load += new System.EventHandler(this.frmmudancas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.PictureBox imgfoto;
        private System.Windows.Forms.OpenFileDialog ofdfoto;
        private System.Windows.Forms.DataGridView dtglistar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxsexo;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnfoto;
    }
}