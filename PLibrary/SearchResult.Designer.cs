namespace PLibrary
{
    partial class SearchResult
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
            this.dataGridSearchResults = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSearchResults
            // 
            this.dataGridSearchResults.AllowUserToOrderColumns = true;
            this.dataGridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSearchResults.Location = new System.Drawing.Point(134, 83);
            this.dataGridSearchResults.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.dataGridSearchResults.Name = "dataGridSearchResults";
            this.dataGridSearchResults.RowTemplate.Height = 33;
            this.dataGridSearchResults.Size = new System.Drawing.Size(1612, 427);
            this.dataGridSearchResults.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(817, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 60);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 650);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridSearchResults);
            this.Name = "SearchResult";
            this.Text = "SearchResult";
            this.Load += new System.EventHandler(this.SearchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSearchResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSearchResults;
        private System.Windows.Forms.Button btnClose;
    }
}