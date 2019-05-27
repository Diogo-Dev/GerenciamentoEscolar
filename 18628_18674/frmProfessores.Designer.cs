namespace _18628_18674
{
    partial class frmProfessores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessores));
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvProfessores = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFormacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbAfastado = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::_18628_18674.Properties.Resources._4_fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(598, 227);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 60);
            this.btnFechar.TabIndex = 56;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::_18628_18674.Properties.Resources._4_imprimir;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(482, 227);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 60);
            this.btnImprimir.TabIndex = 55;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::_18628_18674.Properties.Resources._4_excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(366, 227);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 60);
            this.btnExcluir.TabIndex = 54;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::_18628_18674.Properties.Resources._4_cancelar2;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(250, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 60);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = global::_18628_18674.Properties.Resources._4_atualizar;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(134, 227);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(110, 60);
            this.btnAtualizar.TabIndex = 52;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::_18628_18674.Properties.Resources._4_add;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(18, 227);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(110, 60);
            this.btnIncluir.TabIndex = 51;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisa);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.dgvProfessores);
            this.groupBox1.Location = new System.Drawing.Point(7, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 226);
            this.groupBox1.TabIndex = 50;
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
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(611, 20);
            this.txtPesquisa.TabIndex = 25;
            // 
            // dgvProfessores
            // 
            this.dgvProfessores.AllowUserToAddRows = false;
            this.dgvProfessores.AllowUserToDeleteRows = false;
            this.dgvProfessores.AllowUserToOrderColumns = true;
            this.dgvProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessores.Location = new System.Drawing.Point(6, 60);
            this.dgvProfessores.Name = "dgvProfessores";
            this.dgvProfessores.ReadOnly = true;
            this.dgvProfessores.Size = new System.Drawing.Size(695, 160);
            this.dgvProfessores.TabIndex = 24;
            this.dgvProfessores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfessores_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "UF:";
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(312, 131);
            this.txtUF.Name = "txtUF";
            this.txtUF.ReadOnly = true;
            this.txtUF.Size = new System.Drawing.Size(37, 20);
            this.txtUF.TabIndex = 46;
            // 
            // cboCidade
            // 
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(12, 130);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(286, 21);
            this.cboCidade.TabIndex = 45;
            this.cboCidade.SelectedIndexChanged += new System.EventHandler(this.cboCidade_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Cidade:";
            // 
            // mtbDataNasc
            // 
            this.mtbDataNasc.Location = new System.Drawing.Point(391, 131);
            this.mtbDataNasc.Mask = "00/00/0000";
            this.mtbDataNasc.Name = "mtbDataNasc";
            this.mtbDataNasc.Size = new System.Drawing.Size(100, 20);
            this.mtbDataNasc.TabIndex = 43;
            this.mtbDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Data de Nascimento:";
            // 
            // txtGrau
            // 
            this.txtGrau.Location = new System.Drawing.Point(312, 184);
            this.txtGrau.MaxLength = 1;
            this.txtGrau.Name = "txtGrau";
            this.txtGrau.Size = new System.Drawing.Size(37, 20);
            this.txtGrau.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Grau:";
            // 
            // cboFormacao
            // 
            this.cboFormacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormacao.FormattingEnabled = true;
            this.cboFormacao.Items.AddRange(new object[] {
            "Tecnico",
            "Graduado",
            "Pos-Graduado",
            "Mestre",
            "Doutor"});
            this.cboFormacao.Location = new System.Drawing.Point(13, 185);
            this.cboFormacao.Name = "cboFormacao";
            this.cboFormacao.Size = new System.Drawing.Size(286, 21);
            this.cboFormacao.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Formação:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 33);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(345, 20);
            this.txtNome.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nome do Professor:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(12, 33);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Código:";
            // 
            // chbAfastado
            // 
            this.chbAfastado.AutoSize = true;
            this.chbAfastado.Location = new System.Drawing.Point(400, 14);
            this.chbAfastado.Name = "chbAfastado";
            this.chbAfastado.Size = new System.Drawing.Size(68, 17);
            this.chbAfastado.TabIndex = 36;
            this.chbAfastado.Text = "Afastado";
            this.chbAfastado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 82);
            this.txtEndereco.MaxLength = 40;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(345, 20);
            this.txtEndereco.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(384, 82);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(303, 20);
            this.txtBairro.TabIndex = 60;
            // 
            // txtFone
            // 
            this.txtFone.Location = new System.Drawing.Point(384, 184);
            this.txtFone.MaxLength = 14;
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(143, 20);
            this.txtFone.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "Fone:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(544, 184);
            this.txtCelular.MaxLength = 14;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(143, 20);
            this.txtCelular.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Celular:";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 551);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbDataNasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboFormacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbAfastado);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "frmProfessores";
            this.Text = "-";
            this.Load += new System.EventHandler(this.frmProfessores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvProfessores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbDataNasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFormacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbAfastado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}