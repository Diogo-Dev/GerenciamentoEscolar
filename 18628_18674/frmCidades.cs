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
    public partial class frmCidades : Form
    {
        MySqlConnection Conexao = new MySqlConnection("server=localhost; uid=root; pwd=etecjau");

        MySqlCommand Comando;

        MySqlDataAdapter Adaptador;

        DataTable datTabela;

        public frmCidades()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carregaGrid();
            txtPesquisa.Clear();
        }

        void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();
            txtUF.Clear();
        }

        void carregaGrid()
        {
            Adaptador = new MySqlDataAdapter("select * from cidades where nome like @Nome order by nome", Conexao);

            Adaptador.SelectCommand.Parameters.AddWithValue("@Nome", txtPesquisa.Text + "%");

            Adaptador.Fill(datTabela = new DataTable());

            dgvCidades.DataSource = datTabela;
        }

        private void frmCidades_Load(object sender, EventArgs e)
        {
            carregaGrid();

            LimparCampos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtUF.Text == "")
            {
                MessageBox.Show("Favor informar o nome da cidade", "Inclusão");
                return;
            }

            Conexao.Open();

            Comando = new MySqlCommand("INSERT INTO cidades(nome, uf) VALUES(@nome, @uf)", Conexao);

            Comando.Parameters.AddWithValue("@nome", txtNome.Text);
            Comando.Parameters.AddWithValue("@uf", txtUF.Text);

            Comando.ExecuteNonQuery();

            Conexao.Close();

            LimparCampos();

            carregaGrid();
        }

        private void dgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCidades.RowCount > 0)
            {
                txtID.Text = dgvCidades.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                txtUF.Text = dgvCidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Favor Selecionar uma cidade", "Atualizar");
                return;
            }

            Conexao.Open();
            Comando = new MySqlCommand("Update cidades set nome=@nome, uf=@uf where id=@id", Conexao);
            Comando.Parameters.AddWithValue("@id", Convert.ToInt16(txtID.Text));
            Comando.Parameters.AddWithValue("@uf", txtUF.Text);
            Comando.Parameters.AddWithValue("@nome", txtNome.Text);
            Comando.ExecuteNonQuery();
            Conexao.Close();
            LimparCampos();
            carregaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtID.Text =="")
            {
                MessageBox.Show("Favor Selecionar uma cidade", "Exclusão");
                return;
            }

            if (MessageBox.Show("Deseja realmente Excluir a Cidade?" + txtNome.Text, "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Conexao.Open();
                Comando = new MySqlCommand("Delete from cidades where id=@id",Conexao);
                Comando.Parameters.AddWithValue("@id", txtID.Text);
                Comando.ExecuteNonQuery();
                Conexao.Close();
                LimparCampos();
                carregaGrid();
                
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            carregaGrid();
        }
    }
}
