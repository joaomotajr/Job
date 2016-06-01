namespace ti1sem2016agendac
{
    partial class FrmConsultar
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
            this.txtagdid = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Colagdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colagdnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colagdtelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colagdcpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa por Nome";
            // 
            // txtagdid
            // 
            this.txtagdid.Location = new System.Drawing.Point(247, 12);
            this.txtagdid.Name = "txtagdid";
            this.txtagdid.Size = new System.Drawing.Size(253, 20);
            this.txtagdid.TabIndex = 1;
            this.txtagdid.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(135, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 121);
            this.listBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colagdid,
            this.colagdnome,
            this.colagdtelefone,
            this.colagdcpf});
            this.dataGridView1.Location = new System.Drawing.Point(90, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Colagdid
            // 
            this.Colagdid.HeaderText = "Código";
            this.Colagdid.Name = "Colagdid";
            this.Colagdid.ReadOnly = true;
            // 
            // colagdnome
            // 
            this.colagdnome.HeaderText = "Nome";
            this.colagdnome.Name = "colagdnome";
            this.colagdnome.ReadOnly = true;
            // 
            // colagdtelefone
            // 
            this.colagdtelefone.HeaderText = "Telefone";
            this.colagdtelefone.Name = "colagdtelefone";
            this.colagdtelefone.ReadOnly = true;
            // 
            // colagdcpf
            // 
            this.colagdcpf.HeaderText = "CPF";
            this.colagdcpf.Name = "colagdcpf";
            this.colagdcpf.ReadOnly = true;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;            
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 414);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtagdid);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultar";
            this.Text = "Pesquisa de cliente";
            this.Load += new System.EventHandler(this.FrmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtagdid;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colagdid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colagdnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colagdtelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colagdcpf;
    }
}