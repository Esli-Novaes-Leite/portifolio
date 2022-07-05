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
    public partial class frmmudancas : Form
    {
        public frmmudancas()
        {
            InitializeComponent();
        }
        ConexãoBD bd = new ConexãoBD();
        string sql;
        DateTime data;

        string foto;


        public void listar()
        {
            sql = "select * from criancas";
            dtglistar.DataSource = bd.ConsultarTabelas(sql);
        }

        
        public void limpar()
        {
            txtmatricula.Clear();
            txtnota.Clear();
            txtnome.Clear();
            cbxsexo.SelectedIndex = -1;
            dtpdata.Text = DateTime.Now.ToString();
            imgfoto.Load("H:/infeeerrno/bd_14/semfoto.jpg");

        }
        private void frmmudancas_Load(object sender, EventArgs e)
        {
            listar();
            limpar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            DataTable buscar = new DataTable();
            sql = string.Format("select * from criancas where matricula = '{0}' or nome = '{1}'",
                txtmatricula.Text, txtnome.Text);
            buscar = bd.ConsultarTabelas(sql);

            if (buscar.Rows.Count > 0)
            {
                txtmatricula.Text = buscar.Rows[0]["matricula"].ToString();
                txtnome.Text = buscar.Rows[0]["nome"].ToString();
                txtnota.Text = buscar.Rows[0]["nota"].ToString();
                cbxsexo.Text = buscar.Rows[0]["sexo"].ToString();
                dtpdata.Text = buscar.Rows[0]["dt_nasc"].ToString();
                imgfoto.Load(buscar.Rows[0]["foto"].ToString());
                foto = buscar.Rows[0]["foto"].ToString();
               
            }
            else
            {
                MessageBox.Show("cadastro não realisado ainda!!!", "Buscar cadastro(a))",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }
        

        private void btnalterar_Click(object sender, EventArgs e)
        {

            data = DateTime.Parse(dtpdata.Text);
            foto = foto.Replace(@"\", @"\\");
            sql = string.Format("update criancas set matricula='{0}', nome = '{1}', dt_nasc='{2}', sexo='{3}', nota='{4}', foto='{5}' " +
                "where matricula='{0}'",
                txtmatricula.ToString(), txtnome.Text, data.ToString("yyyy-MM-dd"), cbxsexo.Text, txtnota.Text, foto);
            bd.AlterarTabelas(sql);
            MessageBox.Show("cadastro alterado com sucesso!!!", "Alterar Cadastro."
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
            limpar();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

            sql = string.Format("delete from criancas where matricula = '{0}'", txtmatricula.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("cadastro excluido com sucesso !!!", "excluir cadastro.",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            listar();
            limpar();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatricula.Text = dtglistar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dtglistar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtnota.Text = dtglistar.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxsexo.Text = dtglistar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtnota.Text = dtglistar.Rows[e.RowIndex].Cells[4].Value.ToString();
            imgfoto.Load(dtglistar.Rows[e.RowIndex].Cells[5].Value.ToString());
            foto = dtglistar.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        
    }
}