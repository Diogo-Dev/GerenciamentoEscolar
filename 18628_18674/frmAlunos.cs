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
    public partial class frmAlunos : Form
    {
        MySqlConnection Conexao = new MySqlConnection("server=localhost; uid=root; pwd=etecjau");

        MySqlCommand Comando;

        MySqlDataAdapter Adaptador;

        DataTable datTabela;
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            carregaGrid();

            dgvAlunos.Columns[2].Visible = false;
            dgvAlunos.Columns[7].Visible = false;
            dgvAlunos.Columns[8].Visible = false;

            carregaComboCidade();

            carregaComboCurso();

            LimparCampos();
        }

        void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtAno.Clear();
            txtPesquisa.Clear();
            txtRenda.Clear();
            txtUF.Clear();
            mtbDataNasc.Clear();


            cboCidade.SelectedIndex = -1;

            cboCurso.SelectedIndex = -1;

            chbDesistente.Checked = false;

            picFoto.ImageLocation = "";
        }

        void carregaGrid()
        {
            Adaptador =  new MySqlDataAdapter("SELECT a.*, ci.nome cidade, ci.UF, c.nome curso FROM Alunos a left join cidades ci " +
                "on(a.id_cidade = ci.id) left join cursos c on (c.id = a.id_curso) where a.nome like @Nome order by a.nome", Conexao);

            Adaptador.SelectCommand.Parameters.AddWithValue("@Nome", txtPesquisa.Text + "%");

            Adaptador.Fill(datTabela = new DataTable());

            dgvAlunos.DataSource = datTabela;
        }

        void carregaComboCidade()
        {
            Adaptador = new MySqlDataAdapter("SELECT * FROM Cidades order by nome", Conexao);

            Adaptador.Fill(datTabela = new DataTable());

            cboCidade.DataSource = datTabela;

            cboCidade.DisplayMember = "nome";

            cboCidade.ValueMember = "id";
        }

        void carregaComboCurso()
        {
            Adaptador = new MySqlDataAdapter("SELECT * FROM Cursos order by nome", Conexao);

            Adaptador.Fill(datTabela = new DataTable());

            cboCurso.DataSource = datTabela;

            cboCurso.DisplayMember = "nome";

            cboCurso.ValueMember = "id";
        }

        private void cboCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidade.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCidade.SelectedItem;
                txtUF.Text = reg["UF"].ToString();
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "C:\\";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" )return;

            Conexao.Open();

            Comando = new MySqlCommand("INSERT INTO alunos (nome,id_curso, id_cidade, ano, desistente, renda, foto, data_Nasc) " +
             "VALUES(@nome,@id_curso, @id_cidade, @ano, @desistente, @renda, @foto, @data_Nasc)", Conexao);

            Comando.Parameters.AddWithValue("@nome", txtNome.Text);
            Comando.Parameters.AddWithValue("@id_curso", cboCurso.SelectedValue);
            Comando.Parameters.AddWithValue("@id_cidade", cboCidade.SelectedValue);
            Comando.Parameters.AddWithValue("@ano", Convert.ToInt16(txtAno.Text));
            Comando.Parameters.AddWithValue("@desistente", Convert.ToBoolean(chbDesistente.Checked));
            Comando.Parameters.AddWithValue("@data_Nasc", Convert.ToDateTime(mtbDataNasc.Text));
            Comando.Parameters.AddWithValue("@renda", Convert.ToDouble(txtRenda.Text));
            Comando.Parameters.AddWithValue("@foto", picFoto.ImageLocation);

            Comando.ExecuteNonQuery();

            Conexao.Close();

            LimparCampos();

            carregaGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvAlunos.CurrentRow.Cells["id"].Value.ToString();
            txtNome.Text = dgvAlunos.CurrentRow.Cells["nome"].Value.ToString();
            cboCurso.Text= dgvAlunos.CurrentRow.Cells["curso"].Value.ToString();
            txtAno.Text = dgvAlunos.CurrentRow.Cells["ano"].Value.ToString();
            mtbDataNasc.Text = dgvAlunos.CurrentRow.Cells["data_nasc"].Value.ToString();
            chbDesistente.Checked = Convert.ToBoolean(dgvAlunos.CurrentRow.Cells["desistente"].Value.ToString());
            txtRenda.Text = dgvAlunos.CurrentRow.Cells["renda"].Value.ToString();
            picFoto.ImageLocation= dgvAlunos.CurrentRow.Cells["foto"].Value.ToString();
            cboCidade.Text = dgvAlunos.CurrentRow.Cells["cidade"].Value.ToString();
            txtUF.Text= dgvAlunos.CurrentRow.Cells["UF"].Value.ToString();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Conexao.Open();

            Comando = new MySqlCommand("UPDATE alunos set nome=@nome ,id_curso=@id_curso, id_cidade=@id_cidade, ano=@ano,desistente=@desistente, data_Nasc=@data_Nasc, renda=@renda, foto=@foto where id=@id ", Conexao);

            Comando.Parameters.AddWithValue("@id", Convert.ToInt16(txtID.Text));
            Comando.Parameters.AddWithValue("@nome", txtNome.Text);
            Comando.Parameters.AddWithValue("@id_curso", cboCurso.SelectedValue);
            Comando.Parameters.AddWithValue("@id_cidade", cboCidade.SelectedValue);
            Comando.Parameters.AddWithValue("@ano", Convert.ToInt16(txtAno.Text));
            Comando.Parameters.AddWithValue("@desistente", Convert.ToBoolean(chbDesistente.Checked));
            Comando.Parameters.AddWithValue("@data_Nasc", Convert.ToDateTime(mtbDataNasc.Text));
            Comando.Parameters.AddWithValue("@renda", Convert.ToDouble(txtRenda.Text));
            Comando.Parameters.AddWithValue("@foto", picFoto.ImageLocation);

            Comando.ExecuteNonQuery();

            Conexao.Close();

            LimparCampos();

            carregaGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();

            carregaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "")
            {
                MessageBox.Show("Favor selecionar um curso", "Exclusão");
                return;
            }
            if (MessageBox.Show("Deseja excluir o curso?", "Exclusão", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Conexao.Open();

                Comando = new MySqlCommand("Delete from alunos where id=@id ", Conexao);

                Comando.Parameters.AddWithValue("@id", Convert.ToInt16(txtID.Text));

                Comando.ExecuteNonQuery();

                Conexao.Close();

                LimparCampos();

                carregaGrid();
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            carregaGrid();
            txtPesquisa.Clear();
        }
    }
}
