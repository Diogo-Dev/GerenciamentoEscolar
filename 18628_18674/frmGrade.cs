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
    public partial class frmGrade : Form
    {
        MySqlCommand comando;

        MySqlConnection conexao = new MySqlConnection("server=localhost ; uid=root ; pwd=etecjau");

        MySqlDataAdapter Adaptador;

        DataTable datTabela;

        public frmGrade()
        {
            InitializeComponent();
        }

        void carregaComboCurso()
        {
            Adaptador = new MySqlDataAdapter("SELECT * FROM Cursos order by nome", conexao);
            Adaptador.Fill(datTabela = new DataTable());
            cboCurso.DataSource = datTabela;
            cboCurso.DisplayMember = "nome";
            cboCurso.ValueMember = "id";
        }

        void carregaGrid()
        {
            Adaptador = new MySqlDataAdapter("Select g.*, c.nome Curso, d.nome Disciplina from Grade_Curricular g left join Cursos c on(g.id_curso = c.id) " +
                "left join Disciplinas d on(g.id_disciplina=d.id) where c.nome like @nome order by c.nome ", conexao);

            Adaptador.SelectCommand.Parameters.AddWithValue("@nome", txtPesquisa.Text + "%");

            Adaptador.Fill(datTabela = new DataTable());

            dgvGrade_Curricular.DataSource = datTabela;
        }

        void carregaComboDisciplina()
        {
            Adaptador = new MySqlDataAdapter("SELECT * FROM Disciplinas order by nome", conexao);
            Adaptador.Fill(datTabela = new DataTable());
            cboDisciplina.DataSource = datTabela;
            cboDisciplina.DisplayMember = "nome";
            cboDisciplina.ValueMember = "id";
        }

        void limpaCampos()
        {
            cboCurso.SelectedIndex = -1;
            cboDisciplina.SelectedIndex = -1;
            txtID.Clear();
            chbInativo.Checked = false;
            mtbCargaHoraria.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if(cboCurso.Text == "" || cboDisciplina.Text == "" || mtbCargaHoraria.Text == "  ,")
            {
                MessageBox.Show("Preencha os campos restantes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            conexao.Open();
            comando = new MySqlCommand("INSERT INTO Grade_Curricular (id_curso, id_disciplina, carga_horaria, inativo)" +
                " VALUES (@id_curso, @id_disciplina, @carga_horaria, @inativo)", conexao);

            comando.Parameters.AddWithValue("@id_curso", cboCurso.SelectedValue);
            comando.Parameters.AddWithValue("@id_disciplina", cboDisciplina.SelectedValue);
            comando.Parameters.AddWithValue("@carga_horaria", double.Parse(mtbCargaHoraria.Text));
            comando.Parameters.AddWithValue("@inativo", Convert.ToBoolean(chbInativo.Checked));
            comando.ExecuteNonQuery();

            conexao.Close();
            limpaCampos();
            carregaGrid();
        }



        private void frmGrade_Load(object sender, EventArgs e)
        {
            carregaComboCurso();
            carregaComboDisciplina();
            carregaGrid();
            limpaCampos();

            dgvGrade_Curricular.Columns[1].Visible = false;
            dgvGrade_Curricular.Columns[2].Visible = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            conexao.Open();

            comando = new MySqlCommand("UPDATE Grade_Curricular set id_curso=@id_curso, id_disciplina=@id_disciplina, carga_horaria=@carga_horaria, " +
                " inativo=@inativo where id=@id", conexao);

            comando.Parameters.AddWithValue("@id", txtID.Text);
            comando.Parameters.AddWithValue("@id_curso", cboCurso.SelectedValue);
            comando.Parameters.AddWithValue("@id_disciplina", cboDisciplina.SelectedValue);
            comando.Parameters.AddWithValue("@carga_horaria", double.Parse(mtbCargaHoraria.Text));
            comando.Parameters.AddWithValue("@inativo", Convert.ToBoolean(chbInativo.Checked));
            comando.ExecuteNonQuery();

            conexao.Close();
            limpaCampos();
            carregaGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Selecione", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(MessageBox.Show("Deseja mesmo excluir?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                conexao.Open();

                comando = new MySqlCommand("DELETE FROM Grade_Curricular where id=@id", conexao);

                comando.Parameters.AddWithValue("@id", txtID.Text);

                comando.ExecuteNonQuery();

                conexao.Close();
                carregaGrid();
                limpaCampos();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvGrade_Curricular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrade_Curricular.RowCount > 0)
            {
                txtID.Text = dgvGrade_Curricular.CurrentRow.Cells["id"].Value.ToString();
                mtbCargaHoraria.Text = dgvGrade_Curricular.CurrentRow.Cells["carga_horaria"].Value.ToString();
                cboCurso.SelectedValue = int.Parse(dgvGrade_Curricular.CurrentRow.Cells["id_curso"].Value.ToString());
                cboDisciplina.SelectedValue = int.Parse(dgvGrade_Curricular.CurrentRow.Cells["id_disciplina"].Value.ToString());
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

            foreach (DataGridViewRow linha in dgvGrade_Curricular.Rows)
            {
                if (itens > 40)
                {
                    e.HasMorePages = true;
                    return;
                }

                posicao += 30;
                e.Graphics.DrawString(linha.Cells["id"].Value.ToString(), new Font("Arial", 10), Brushes.Black, 50, posicao);
                e.Graphics.DrawString(linha.Cells["carga_horaria"].Value.ToString(), new Font("Arial", 10), Brushes.Black, 130, posicao);
                e.Graphics.DrawString(linha.Cells["Curso"].Value.ToString(), new Font("Arial", 10), Brushes.Black, 450, posicao);
                e.Graphics.DrawString(linha.Cells["Disciplina"].Value.ToString(), new Font("Arial", 10), Brushes.Black, 450, posicao);

                itens++;
            }
        }
    }
}
