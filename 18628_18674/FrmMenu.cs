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
    public partial class FrmMenu : Form
    {
        MySqlConnection Conexao = new MySqlConnection("server=localhost; uid=root; pwd=etecjau");

        MySqlCommand Comando;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            conectar();
        }

        void conectar()
        {
            Conexao.Open();

            Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bd_escola;USE bd_escola", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidades " +
                                       "(id integer auto_increment primary key, " +
                                       "nome char(40), " +
                                       "uf char(02))", Conexao);
            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Alunos " +
                                       "(id integer auto_increment primary key, " +
                                       "nome char(40), " +
                                       "id_curso integer, " +
                                       "ano integer, " +
                                       "data_Nasc date," +
                                       "desistente boolean," +
                                       "renda decimal(10,2)," +
                                       "foto char(50)," +
                                       "id_cidade integer)", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cursos" +
                                       "(id integer auto_increment primary key, " +
                                       "nome char(30), " +
                                       "duracao integer)", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Disciplinas" +
                                       "(id integer auto_increment primary key, " +
                                       "nome char(30), " +
                                       "area integer)", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Professores(id integer auto_increment primary key, " +
                "nome char(40), " +
                "endereco char(40), " +
                "bairro char(30), " +
                "id_cidade integer, " +
                "fone char(14), " +
                "celular char(14), " +
                "formacao integer, " +
                "grau char(1), " +
                "data_nasc date, " +
                "afastado boolean) ", Conexao);

            Comando.ExecuteNonQuery();

            Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Grade_Curricular (id integer auto_increment primary key," +
                "id_curso integer, " +
                "id_disciplina integer, " +
                "carga_horaria double(3,1), " +
                "inativo boolean)", Conexao);

            Comando.ExecuteNonQuery();

            Conexao.Close();

            
        }

        private void finalizarOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidades form = new frmCidades();
            form.Show();

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunos form = new frmAlunos();
            form.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursos form = new frmCursos();
            form.Show();
        }

        private void diciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisciplinas form = new frmDisciplinas();
            form.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaAlunoCidade form = new frmConsultaAlunoCidade();
            form.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaAlunoCurso form = new frmConsultaAlunoCurso();
            form.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfessores form = new frmProfessores();
            form.Show();
        }

        private void gradeCurricularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrade form = new frmGrade();
            form.Show();
        }
    }
}
