namespace _18628_18674
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeCurricularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.finalizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cidadesToolStripMenuItem,
            this.alunosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.diciplinasToolStripMenuItem,
            this.consultaDeAlunosToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.gradeCurricularToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cidadesToolStripMenuItem
            // 
            this.cidadesToolStripMenuItem.Name = "cidadesToolStripMenuItem";
            this.cidadesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cidadesToolStripMenuItem.Text = "Cidades";
            this.cidadesToolStripMenuItem.Click += new System.EventHandler(this.cidadesToolStripMenuItem_Click);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // diciplinasToolStripMenuItem
            // 
            this.diciplinasToolStripMenuItem.Name = "diciplinasToolStripMenuItem";
            this.diciplinasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.diciplinasToolStripMenuItem.Text = "Diciplinas";
            this.diciplinasToolStripMenuItem.Click += new System.EventHandler(this.diciplinasToolStripMenuItem_Click);
            // 
            // consultaDeAlunosToolStripMenuItem
            // 
            this.consultaDeAlunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cidadeToolStripMenuItem,
            this.cursoToolStripMenuItem});
            this.consultaDeAlunosToolStripMenuItem.Name = "consultaDeAlunosToolStripMenuItem";
            this.consultaDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.consultaDeAlunosToolStripMenuItem.Text = "Consulta de Alunos";
            // 
            // cidadeToolStripMenuItem
            // 
            this.cidadeToolStripMenuItem.Name = "cidadeToolStripMenuItem";
            this.cidadeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cidadeToolStripMenuItem.Text = "Cidade";
            this.cidadeToolStripMenuItem.Click += new System.EventHandler(this.cidadeToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.professoresToolStripMenuItem.Text = "Professores";
            this.professoresToolStripMenuItem.Click += new System.EventHandler(this.professoresToolStripMenuItem_Click);
            // 
            // finalizarToolStripMenuItem
            // 
            this.finalizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalizarOSistemaToolStripMenuItem});
            this.finalizarToolStripMenuItem.Name = "finalizarToolStripMenuItem";
            this.finalizarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.finalizarToolStripMenuItem.Text = "Finalizar";
            // 
            // finalizarOSistemaToolStripMenuItem
            // 
            this.finalizarOSistemaToolStripMenuItem.Name = "finalizarOSistemaToolStripMenuItem";
            this.finalizarOSistemaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.finalizarOSistemaToolStripMenuItem.Text = "Finalizar o Sistema";
            this.finalizarOSistemaToolStripMenuItem.Click += new System.EventHandler(this.finalizarOSistemaToolStripMenuItem_Click);
            // 
            // gradeCurricularToolStripMenuItem
            // 
            this.gradeCurricularToolStripMenuItem.Name = "gradeCurricularToolStripMenuItem";
            this.gradeCurricularToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gradeCurricularToolStripMenuItem.Text = "Grade Curricular";
            this.gradeCurricularToolStripMenuItem.Click += new System.EventHandler(this.gradeCurricularToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 327);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarOSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradeCurricularToolStripMenuItem;
    }
}

