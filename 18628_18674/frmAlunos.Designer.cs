namespace _18628_18674
{
    partial class frmAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.chbDesistente = new System.Windows.Forms.CheckBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(16, 32);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Aluno:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(135, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(345, 20);
            this.txtNome.TabIndex = 3;
            // 
            // chbDesistente
            // 
            this.chbDesistente.AutoSize = true;
            this.chbDesistente.Location = new System.Drawing.Point(404, 13);
            this.chbDesistente.Name = "chbDesistente";
            this.chbDesistente.Size = new System.Drawing.Size(76, 17);
            this.chbDesistente.TabIndex = 4;
            this.chbDesistente.Text = "Desistente";
            this.chbDesistente.UseVisualStyleBackColor = true;
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Location = new System.Drawing.Point(534, 5);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(186, 186);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 5;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Curso:";
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(16, 105);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(286, 21);
            this.cboCurso.TabIndex = 7;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ano:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(320, 106);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(58, 20);
            this.txtAno.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nascimento:";
            // 
            // mtbDataNasc
            // 
            this.mtbDataNasc.Location = new System.Drawing.Point(400, 106);
            this.mtbDataNasc.Mask = "00/00/0000";
            this.mtbDataNasc.Name = "mtbDataNasc";
            this.mtbDataNasc.Size = new System.Drawing.Size(100, 20);
            this.mtbDataNasc.TabIndex = 11;
            this.mtbDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cidade:";
            // 
            // cboCidade
            // 
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(16, 170);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(286, 21);
            this.cboCidade.TabIndex = 13;
            this.cboCidade.SelectedIndexChanged += new System.EventHandler(this.cboCidade_SelectedIndexChanged);
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(316, 171);
            this.txtUF.Name = "txtUF";
            this.txtUF.ReadOnly = true;
            this.txtUF.Size = new System.Drawing.Size(37, 20);
            this.txtUF.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "UF:";
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(370, 171);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(58, 20);
            this.txtRenda.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Renda:";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToOrderColumns = true;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(6, 60);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.Size = new System.Drawing.Size(695, 160);
            this.dgvAlunos.TabIndex = 24;
            this.dgvAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisa);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.dgvAlunos);
            this.groupBox1.Location = new System.Drawing.Point(19, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 226);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite o nome do Aluno para a Pesquisa:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::_18628_18674.Properties.Resources._4_pesquisar;
            this.btnPesquisa.Location = new System.Drawing.Point(633, 13);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(68, 41);
            this.btnPesquisa.TabIndex = 26;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(611, 20);
            this.txtPesquisa.TabIndex = 25;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::_18628_18674.Properties.Resources._4_fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(610, 204);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 60);
            this.btnFechar.TabIndex = 31;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::_18628_18674.Properties.Resources._4_imprimir;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(494, 204);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 60);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::_18628_18674.Properties.Resources._4_excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(378, 204);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 60);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::_18628_18674.Properties.Resources._4_cancelar2;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(262, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 60);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = global::_18628_18674.Properties.Resources._4_atualizar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(146, 204);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(110, 60);
            this.btnAtualizar.TabIndex = 27;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::_18628_18674.Properties.Resources._4_add;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(30, 204);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(110, 60);
            this.btnIncluir.TabIndex = 26;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 575);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbDataNasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.chbDesistente);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "frmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.frmAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox chbDesistente;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbDataNasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}