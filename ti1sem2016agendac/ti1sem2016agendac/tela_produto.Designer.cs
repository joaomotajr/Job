namespace ti1sem2016agendac
{
    partial class tela_produto
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
            this.lbl_codproduto = new System.Windows.Forms.Label();
            this.lbl_nomeprod = new System.Windows.Forms.Label();
            this.lbl_precoprod = new System.Windows.Forms.Label();
            this.lbl_tipoprod = new System.Windows.Forms.Label();
            this.txt_codproduto = new System.Windows.Forms.TextBox();
            this.txt_nomeprod = new System.Windows.Forms.TextBox();
            this.cbx_tipoproduto = new System.Windows.Forms.ComboBox();
            this.txt_precoprod = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codproduto
            // 
            this.lbl_codproduto.AutoSize = true;
            this.lbl_codproduto.Location = new System.Drawing.Point(65, 24);
            this.lbl_codproduto.Name = "lbl_codproduto";
            this.lbl_codproduto.Size = new System.Drawing.Size(40, 13);
            this.lbl_codproduto.TabIndex = 0;
            this.lbl_codproduto.Text = "Código";
            // 
            // lbl_nomeprod
            // 
            this.lbl_nomeprod.AutoSize = true;
            this.lbl_nomeprod.Location = new System.Drawing.Point(65, 65);
            this.lbl_nomeprod.Name = "lbl_nomeprod";
            this.lbl_nomeprod.Size = new System.Drawing.Size(90, 13);
            this.lbl_nomeprod.TabIndex = 1;
            this.lbl_nomeprod.Text = "Nome do Produto";
            // 
            // lbl_precoprod
            // 
            this.lbl_precoprod.AutoSize = true;
            this.lbl_precoprod.Location = new System.Drawing.Point(65, 116);
            this.lbl_precoprod.Name = "lbl_precoprod";
            this.lbl_precoprod.Size = new System.Drawing.Size(35, 13);
            this.lbl_precoprod.TabIndex = 2;
            this.lbl_precoprod.Text = "Preço";
            // 
            // lbl_tipoprod
            // 
            this.lbl_tipoprod.AutoSize = true;
            this.lbl_tipoprod.Location = new System.Drawing.Point(65, 164);
            this.lbl_tipoprod.Name = "lbl_tipoprod";
            this.lbl_tipoprod.Size = new System.Drawing.Size(83, 13);
            this.lbl_tipoprod.TabIndex = 3;
            this.lbl_tipoprod.Text = "Tipo do Produto";
            // 
            // txt_codproduto
            // 
            this.txt_codproduto.Location = new System.Drawing.Point(122, 21);
            this.txt_codproduto.Name = "txt_codproduto";
            this.txt_codproduto.Size = new System.Drawing.Size(58, 20);
            this.txt_codproduto.TabIndex = 4;
            // 
            // txt_nomeprod
            // 
            this.txt_nomeprod.Location = new System.Drawing.Point(174, 62);
            this.txt_nomeprod.Name = "txt_nomeprod";
            this.txt_nomeprod.Size = new System.Drawing.Size(327, 20);
            this.txt_nomeprod.TabIndex = 5;
            // 
            // cbx_tipoproduto
            // 
            this.cbx_tipoproduto.FormattingEnabled = true;
            this.cbx_tipoproduto.Location = new System.Drawing.Point(160, 161);
            this.cbx_tipoproduto.Name = "cbx_tipoproduto";
            this.cbx_tipoproduto.Size = new System.Drawing.Size(202, 21);
            this.cbx_tipoproduto.TabIndex = 7;
            // 
            // txt_precoprod
            // 
            this.txt_precoprod.Location = new System.Drawing.Point(122, 113);
            this.txt_precoprod.Name = "txt_precoprod";
            this.txt_precoprod.Size = new System.Drawing.Size(159, 20);
            this.txt_precoprod.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 176);
            this.dataGridView1.TabIndex = 9;
            // 
            // tela_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;                        
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_precoprod);
            this.Controls.Add(this.cbx_tipoproduto);
            this.Controls.Add(this.txt_nomeprod);
            this.Controls.Add(this.txt_codproduto);
            this.Controls.Add(this.lbl_tipoprod);
            this.Controls.Add(this.lbl_precoprod);
            this.Controls.Add(this.lbl_nomeprod);
            this.Controls.Add(this.lbl_codproduto);
            this.Name = "tela_produto";
            this.Text = "tela_produto";
            this.Load += new System.EventHandler(this.tela_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codproduto;
        private System.Windows.Forms.Label lbl_nomeprod;
        private System.Windows.Forms.Label lbl_precoprod;
        private System.Windows.Forms.Label lbl_tipoprod;
        private System.Windows.Forms.TextBox txt_codproduto;
        private System.Windows.Forms.TextBox txt_nomeprod;
        private System.Windows.Forms.ComboBox cbx_tipoproduto;
        private System.Windows.Forms.TextBox txt_precoprod;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}