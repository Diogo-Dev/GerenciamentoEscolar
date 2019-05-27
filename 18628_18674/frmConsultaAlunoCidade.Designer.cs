namespace _18628_18674
{
    partial class frmConsultaAlunoCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaAlunoCidade));
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cidade";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(348, 23);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(123, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consulta";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToOrderColumns = true;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(16, 78);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(455, 150);
            this.dgvConsulta.TabIndex = 3;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(266, 235);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(95, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(367, 234);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(104, 23);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cboCidade
            // 
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(53, 23);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(289, 21);
            this.cboCidade.TabIndex = 6;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // frmConsultaAlunoCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 271);
            this.ControlBox = false;
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaAlunoCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Aluno por Cidade";
            this.Load += new System.EventHandler(this.frmConsultaAlunoCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}