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
    public partial class frmConsultaAlunoCurso : Form
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost; uid=root; pwd=etecjau");
        MySqlDataAdapter adaptador;
        DataTable datTabela;

        public frmConsultaAlunoCurso()
        {
            InitializeComponent();
        }

        void carregaGrid()
        {
            adaptador = new MySqlDataAdapter("select * from alunos where id_curso = @id", conexao);
            adaptador.SelectCommand.Parameters.AddWithValue("@id", cboCurso.SelectedValue);
            adaptador.Fill(datTabela = new DataTable());
            dgvConsulta.DataSource = datTabela;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregaGrid();
            cboCurso.SelectedIndex = -1;
        }
        void carregaComboCurso()
        {
            adaptador = new MySqlDataAdapter("SELECT * FROM Cursos order by nome", conexao);

            adaptador.Fill(datTabela = new DataTable());

            cboCurso.DataSource = datTabela;

            cboCurso.DisplayMember = "nome";

            cboCurso.ValueMember = "id";
        }

        private void frmConsultaAlunoCurso_Load(object sender, EventArgs e)
        {
            carregaComboCurso();
            cboCurso.SelectedIndex = -1;
            carregaGrid();
            dgvConsulta.Columns[0].Visible = false;
            dgvConsulta.Columns[2].Visible = false;
            dgvConsulta.Columns[7].Visible = false;
            dgvConsulta.Columns[8].Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;

            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int posicao, itens = 0;

            e.Graphics.DrawString("Relatório de Alunos", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, 230, 10);

            e.Graphics.DrawLine(Pens.Black, 50, 90, 780, 90);
            e.Graphics.DrawString("Código", new Font("Arial", 10), Brushes.Black, 50, 95);
            e.Graphics.DrawString("Nome", new Font("Arial", 10), Brushes.Black, 130, 95);
            e.Graphics.DrawString("Curso", new Font("Arial", 10), Brushes.Black, 450, 95);

            posicao = 100;

            foreach(DataGridViewRow linha in dgvConsulta.Rows )
            {
                if(itens > 40 )
                {
                    e.HasMorePages = true;
                    return;
                }

                posicao += 30;
                e.Graphics.DrawString(linha.Cells[0].Value.ToString(), new Font("Arial", 10), Brushes.Black, 50, posicao);
                e.Graphics.DrawString(linha.Cells[1].Value.ToString(), new Font("Arial", 10), Brushes.Black, 130, posicao);
                e.Graphics.DrawString(linha.Cells[2].Value.ToString(), new Font("Arial", 10), Brushes.Black, 450, posicao);

                itens++;
            }
        }
    }
}
