using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _18628_18674
{
    public partial class frmDisciplinas : Form
    {
        MySqlConnection Conexao = new MySqlConnection("server = localhost; uid = root; pwd = etecjau");

        MySqlDataAdapter Adaptador;

        MySqlCommand Comando;

        DataTable datTabela;

        public frmDisciplinas()
        {
            InitializeComponent();
        }
        void CarregaGrid()
        {
            Adaptador = new MySqlDataAdapter("select * from disciplinas where nome like @Nome order by nome", Conexao);

            Adaptador.SelectCommand.Parameters.AddWithValue("@Nome", txtPesquisa.Text + "%");

            Adaptador.Fill(datTabela = new DataTable());

            dgvDisciplinas.DataSource = datTabela;
        }

        void LimparCampos()
        {
            txtID.Clear();
            txtDisciplinas.Clear();
            cboArea.SelectedIndex = -1;
            txtPesquisa.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtDisciplinas.Text == "" || cboArea.Text == "")
            {
                MessageBox.Show("Favor Informar a Disciplina e a Área", "Inclusão");
                return;
            }

            Conexao.Open();

            Comando = new MySqlCommand("INSERT INTO disciplinas (nome, area) VALUES(@nome, @area)", Conexao);

            Comando.Parameters.AddWithValue("@nome", txtDisciplinas.Text);
            Comando.Parameters.AddWithValue("@area", cboArea.SelectedIndex);

            Comando.ExecuteNonQuery();

            Conexao.Close();


            CarregaGrid();

            LimparCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            CarregaGrid();
            txtPesquisa.Clear();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtDisciplinas.Text == "" || cboArea.Text == "")
            {
                MessageBox.Show("Favor Informar a Disciplina e a Área", "Inclusão");
                return;
            }

            Conexao.Open();

            Comando = new MySqlCommand("UPDATE disciplinas set nome=@nome , area=@area where id=@id", Conexao);
            Comando.Parameters.AddWithValue("@id", Convert.ToInt16(txtID.Text));
            Comando.Parameters.AddWithValue("@nome", txtDisciplinas.Text);
            Comando.Parameters.AddWithValue("@area", cboArea.SelectedIndex);

            Comando.ExecuteNonQuery();

            Conexao.Close();
            LimparCampos();
            CarregaGrid();
        }

        private void dgvDisciplinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisciplinas.RowCount > 0)
            {
                txtID.Text = dgvDisciplinas.CurrentRow.Cells["id"].Value.ToString();
                txtDisciplinas.Text = dgvDisciplinas.CurrentRow.Cells["nome"].Value.ToString();
                cboArea.SelectedIndex =Convert.ToInt16(dgvDisciplinas.CurrentRow.Cells["area"].Value);
            }
        }

        private void frmDiciplinas_Load(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Favor selecionar uma disciplina", "Exclusão");
                return;
            }
            if (MessageBox.Show("Deseja excluir a disciplina?", "Exclusão", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Conexao.Open();
                Comando = new MySqlCommand("Delete from disciplinas where id=@id", Conexao);
                Comando.Parameters.AddWithValue("@id", txtID.Text);
                Comando.ExecuteNonQuery();
                Conexao.Close();
                LimparCampos();
                CarregaGrid();
            }
        }
    }
}
