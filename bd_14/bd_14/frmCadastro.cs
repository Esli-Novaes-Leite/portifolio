using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_14
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        ConexãoBD bd = new ConexãoBD();
        string sql;
        DateTime data;

        string foto;

        public void limpar()
        {
            txtmatricula.Clear();
            txtnota.Clear();
            txtnome.Clear();
            cbxsexo.SelectedIndex = -1;
            dtpdata.Text = DateTime.Now.ToString();
            imgfoto.Load("H:/infeeerrno/bd_14/semfoto.jpg");

        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            foto = "";
            if (
                ofdfoto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgfoto.Load(ofdfoto.FileName);
                foto = ofdfoto.FileName;
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            data = DateTime.Parse(dtpdata.Text);
            foto = foto.Replace(@"\", @"\\");
            sql = string.Format("insert into criancas values('{0}','{1}','{2}','{3}','{4}','{5}')",
            txtmatricula.Text, txtnome.Text, data.ToString("yyyy-MM-dd"), cbxsexo.Text, txtnota.Text, foto);
            bd.AlterarTabelas(sql);
            MessageBox.Show("cadastro feito com sucesso !!!", "cadastro de crianças.",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
            limpar();
        }
    public void listar()
        {
            sql = "select * from criancas";
            dtglistar.DataSource = bd.ConsultarTabelas(sql);
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            listar();
            limpar();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatricula.Text = dtglistar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dtglistar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtnota.Text = dtglistar.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxsexo.Text = dtglistar.Rows[e.RowIndex].Cells[3].Value.ToString();
            imgfoto.Load(dtglistar.Rows[e.RowIndex].Cells[5].Value.ToString());
            foto = dtglistar.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
