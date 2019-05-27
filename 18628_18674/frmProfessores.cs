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
    public partial class frmProfessores : Form
    {
        MySqlCommand comando;

        MySqlConnection conexao = new MySqlConnection("server=localhost ; uid=root ; pwd=etecjau");

        MySqlDataAdapter Adaptador;

        DataTable datTabela;

        public frmProfessores()
        {
            InitializeComponent();
        }

        void CarregaGrid()
        {
            Adaptador = new MySqlDataAdapter("SELECT p.*, ci.nome cidade, ci.UF FROM Professores p left join cidades ci " +
                "on(p.id_cidade = ci.id) like @Nome order by nome", conexao);

            Adaptador.SelectCommand.Parameters.AddWithValue("@Nome", txtPesquisa.Text + "%");

            Adaptador.Fill(datTabela = new DataTable());

            dgvProfessores.DataSource = datTabela;
        }

        void LimpaCampos()
        {
            txtCelular.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtFone.Clear();
            txtGrau.Clear();
            txtID.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();
            txtUF.Clear();
            cboCidade.SelectedIndex = -1;
            cboFormacao.SelectedIndex = -1;
            mtbDataNasc.Clear();
            chbAfastado.Checked = false;
        }

        void CarregaComboCidade()
        {
            Adaptador = new MySqlDataAdapter("SELECT * FROM Cidades order by nome", conexao);

            Adaptador.Fill(datTabela = new DataTable());

            cboCidade.DataSource = datTabela;

            cboCidade.DisplayMember = "nome";

            cboCidade.ValueMember = "id";
        }


        private void frmProfessores_Load(object sender, EventArgs e)
        {
            CarregaComboCidade();
            CarregaGrid();
            LimpaCampos();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtEndereco.Text == "" || txtBairro.Text == "" || cboCidade.Text == "" || mtbDataNasc.Text == "" || cboFormacao.Text == ""
                || txtGrau.Text == "" || txtFone.Text == "" || txtCelular.Text == "")
            {
                MessageBox.Show("Preencha os campos restantes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            conexao.Open();

            comando = new MySqlCommand("Insert into professores (nome, endereco, bairro, id_cidade, fone, celular, formacao, grau, data_nasc, afastado )" +
                "Values (@nome, @endereco, @bairro, @id_cidade, @fone, @celular, @formacao, @grau, @data_nasc, @afastado )", conexao);

            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
            comando.Parameters.AddWithValue("@id_cidade", Convert.ToInt16(cboCidade.SelectedValue));
            comando.Parameters.AddWithValue("@fone", txtFone.Text);
            comando.Parameters.AddWithValue("@celular", txtCelular.Text);
            comando.Parameters.AddWithValue("@formacao", Convert.ToInt16(cboFormacao.SelectedIndex));
            comando.Parameters.AddWithValue("@grau", txtGrau.Text);
            comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(mtbDataNasc.Text));
            comando.Parameters.AddWithValue("@afastado", Convert.ToBoolean(chbAfastado.Checked));

            comando.ExecuteNonQuery();
            conexao.Close();
            LimpaCampos();
            CarregaGrid();

        }

        private void dgvProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfessores.RowCount > 0)
            {
                txtID.Text = dgvProfessores.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvProfessores.CurrentRow.Cells["nome"].Value.ToString();
                txtEndereco.Text = dgvProfessores.CurrentRow.Cells["endereco"].Value.ToString();
                txtBairro.Text = dgvProfessores.CurrentRow.Cells["bairro"].Value.ToString();
                cboCidade.Text = dgvProfessores.CurrentRow.Cells["cidade"].Value.ToString();
                mtbDataNasc.Text = dgvProfessores.CurrentRow.Cells["data_nasc"].Value.ToString();
                cboFormacao.SelectedIndex = int.Parse(dgvProfessores.CurrentRow.Cells["formacao"].Value.ToString());
                txtGrau.Text = dgvProfessores.CurrentRow.Cells["grau"].Value.ToString();
                txtFone.Text = dgvProfessores.CurrentRow.Cells["fone"].Value.ToString();
                txtCelular.Text = dgvProfessores.CurrentRow.Cells["celular"].Value.ToString();
                chbAfastado.Checked = Convert.ToBoolean(dgvProfessores.CurrentRow.Cells["afastado"].Value.ToString());
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidade.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCidade.SelectedItem;
                txtUF.Text = reg["UF"].ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            CarregaGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            conexao.Open();

            comando = new MySqlCommand("UPDATE Professores SET nome=@nome, endereco=@endereco, afastado=@afastado, bairro=@bairro, id_cidade=@id_cidade," +
                " data_nasc=@data_nasc, formacao=@formacao, grau=@grau, fone=@fone, celular=@celular where id=@id", conexao);

            comando.Parameters.AddWithValue("@id", txtID.Text);
            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            comando.Parameters.AddWithValue("@bairro", txtBairro.Text);
            comando.Parameters.AddWithValue("@id_cidade", Convert.ToInt16(cboCidade.SelectedValue));
            comando.Parameters.AddWithValue("@fone", txtFone.Text);
            comando.Parameters.AddWithValue("@celular", txtCelular.Text);
            comando.Parameters.AddWithValue("@formacao", Convert.ToInt16(cboFormacao.SelectedIndex));
            comando.Parameters.AddWithValue("@grau", txtGrau.Text);
            comando.Parameters.AddWithValue("@data_nasc", Convert.ToDateTime(mtbDataNasc.Text));
            comando.Parameters.AddWithValue("@afastado", Convert.ToBoolean(chbAfastado.Checked));

            comando.ExecuteNonQuery();
            conexao.Close();
            LimpaCampos();
            CarregaGrid();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("favor selecionar o professor", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (MessageBox.Show("Deseja mesmo excluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                conexao.Open();

                comando = new MySqlCommand("DELETE FROM Professores WHERE id=@id", conexao);

                comando.Parameters.AddWithValue("@id", txtID.Text);

                comando.ExecuteNonQuery();

                conexao.Close();
                CarregaGrid();
                LimpaCampos();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;

            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            e.Graphics.DrawString("Relatório de Professores", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 230, 10);

            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("Código", new Font("Arial", 10), Brushes.Black, 50, 95);
            e.Graphics.DrawString("Nome", new Font("Arial", 10), Brushes.Black, 130, 95);
            e.Graphics.DrawString("Formação", new Font("Arial", 10), Brushes.Black, 450, 95);

            posicao = 100;

            foreach (DataGridViewRow linha in dgvProfessores.Rows)
            {
                if (itens > 40)
                {
                    e.HasMorePages = true;
                    return;
                }

                posicao += 30;
                e.Graphics.DrawString(linha.Cells[0].Value.ToString(), new Font("Arial", 10), Brushes.Black, 50, posicao);
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 130, posicao);
                e.Graphics.DrawString(linha.Cells["formacao"].Value.ToString(), new Font("Arial", 10), Brushes.Black, 450, posicao);

                itens++;
            }
        }
    }
}
