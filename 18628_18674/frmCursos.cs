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
    public partial class frmCursos : Form
    {
        MySqlConnection Conexao = new MySqlConnection("server = localhost; uid = root; pwd = etecjau");

        MySqlDataAdapter Adaptador;

        MySqlCommand Comando;

        DataTable datTabela;

        public frmCursos()
        {
            InitializeComponent();
        }

        void CarregaGrid()
        {
            Adaptador = new MySqlDataAdapter("select * from cursos where nome like @Nome order by nome", Conexao );

            Adaptador.SelectCommand.Parameters.AddWithValue("@Nome", txtPesquisa.Text + "%");

            Adaptador.Fill(datTabela = new DataTable());

            dgvCursos.DataSource = datTabela;
        }

        void LimparCampos()
        {
            txtID.Clear();
            txtDuracao.Clear();
            txtCurso.Clear();
            txtPesquisa.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregaGrid();
            txtPesquisa.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if(txtCurso.Text == "" || txtDuracao.Text == "")
            {
                MessageBox.Show("Favor Informar o Curso e a Duração", "Inclusão");
                return;
            }

            Conexao.Open();

            Comando = new MySqlCommand("INSERT INTO cursos(nome, duracao) VALUES(@nome, @duracao)", Conexao);

            Comando.Parameters.AddWithValue("@nome", txtCurso.Text);
            Comando.Parameters.AddWithValue("@duracao", txtDuracao.Text);

            Comando.ExecuteNonQuery();

            Conexao.Close();


            CarregaGrid();

            LimparCampos();

        }

        private void frmCursos_Load(object sender, EventArgs e)
        {
            CarregaGrid();

            LimparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(txtID.Text=="")
            {
                MessageBox.Show("Selecione um curso", "Atualizar");
                return;
            }

            Conexao.Open();
            Comando = new MySqlCommand("Update cursos set nome=@nome, duracao=@duracao where id=@id", Conexao);
            Comando.Parameters.AddWithValue("@id", Convert.ToInt16(txtID.Text));
            Comando.Parameters.AddWithValue("@nome", txtCurso.Text);
            Comando.Parameters.AddWithValue("@duracao", Convert.ToInt16(txtDuracao.Text));
            Comando.ExecuteNonQuery();
            Conexao.Close();
            LimparCampos();
            CarregaGrid();
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCursos.RowCount > 0)
            {
                txtID.Text = dgvCursos.CurrentRow.Cells["id"].Value.ToString();
                txtCurso.Text = dgvCursos.CurrentRow.Cells["nome"].Value.ToString();
                txtDuracao.Text = dgvCursos.CurrentRow.Cells["duracao"].Value.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtID.Text=="")
            {
                MessageBox.Show("Favor selecionar um curso", "Exclusão");
                return;
            }
            if(MessageBox.Show("Deseja excluir o curso?","Exclusão",MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)== DialogResult.Yes)
            {
                Conexao.Open();
                Comando = new MySqlCommand("Delete from Cursos where id=@id", Conexao);
                Comando.Parameters.AddWithValue("@id", txtID.Text);
                Comando.ExecuteNonQuery();
                Conexao.Close();
                LimparCampos();
                CarregaGrid();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
