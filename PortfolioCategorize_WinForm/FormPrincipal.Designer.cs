
namespace PortfolioCategorize_WinForm
{
    partial class FormPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValueTrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxClientSectorTrade = new System.Windows.Forms.ComboBox();
            this.btnAddTrade = new System.Windows.Forms.Button();
            this.lstPortfolio = new System.Windows.Forms.ListView();
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClientSector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnCategorize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value:";
            // 
            // txtValueTrade
            // 
            this.txtValueTrade.Location = new System.Drawing.Point(56, 13);
            this.txtValueTrade.Name = "txtValueTrade";
            this.txtValueTrade.Size = new System.Drawing.Size(91, 20);
            this.txtValueTrade.TabIndex = 1;
            this.txtValueTrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValueTrade_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client sector:";
            // 
            // cbxClientSectorTrade
            // 
            this.cbxClientSectorTrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClientSectorTrade.FormattingEnabled = true;
            this.cbxClientSectorTrade.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.cbxClientSectorTrade.Location = new System.Drawing.Point(227, 13);
            this.cbxClientSectorTrade.Name = "cbxClientSectorTrade";
            this.cbxClientSectorTrade.Size = new System.Drawing.Size(61, 21);
            this.cbxClientSectorTrade.TabIndex = 3;
            // 
            // btnAddTrade
            // 
            this.btnAddTrade.Location = new System.Drawing.Point(294, 11);
            this.btnAddTrade.Name = "btnAddTrade";
            this.btnAddTrade.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrade.TabIndex = 4;
            this.btnAddTrade.Text = "Add trade";
            this.btnAddTrade.UseVisualStyleBackColor = true;
            this.btnAddTrade.Click += new System.EventHandler(this.btnAddTrade_Click);
            // 
            // lstPortfolio
            // 
            this.lstPortfolio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chValue,
            this.chClientSector,
            this.chCategory});
            this.lstPortfolio.HideSelection = false;
            this.lstPortfolio.Location = new System.Drawing.Point(13, 54);
            this.lstPortfolio.Name = "lstPortfolio";
            this.lstPortfolio.Size = new System.Drawing.Size(357, 384);
            this.lstPortfolio.TabIndex = 5;
            this.lstPortfolio.UseCompatibleStateImageBehavior = false;
            this.lstPortfolio.View = System.Windows.Forms.View.Details;
            // 
            // chValue
            // 
            this.chValue.Text = "Value";
            this.chValue.Width = 91;
            // 
            // chClientSector
            // 
            this.chClientSector.Text = "Client sector";
            this.chClientSector.Width = 70;
            // 
            // chCategory
            // 
            this.chCategory.Text = "Category";
            this.chCategory.Width = 191;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Portfolio:";
            // 
            // btnCategorize
            // 
            this.btnCategorize.Location = new System.Drawing.Point(294, 444);
            this.btnCategorize.Name = "btnCategorize";
            this.btnCategorize.Size = new System.Drawing.Size(75, 23);
            this.btnCategorize.TabIndex = 7;
            this.btnCategorize.Text = "Categorize";
            this.btnCategorize.UseVisualStyleBackColor = true;
            this.btnCategorize.Click += new System.EventHandler(this.btnCategorize_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 471);
            this.Controls.Add(this.btnCategorize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPortfolio);
            this.Controls.Add(this.btnAddTrade);
            this.Controls.Add(this.cbxClientSectorTrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValueTrade);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portfolio Categorize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValueTrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxClientSectorTrade;
        private System.Windows.Forms.Button btnAddTrade;
        private System.Windows.Forms.ListView lstPortfolio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.ColumnHeader chClientSector;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.Button btnCategorize;
    }
}

