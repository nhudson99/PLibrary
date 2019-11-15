namespace PLibrary
{
    partial class Menu
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
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnProcessBook = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnBookManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(222, 58);
            this.btnBookSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(98, 54);
            this.btnBookSearch.TabIndex = 0;
            this.btnBookSearch.Text = "Search For Book";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnProcessBook
            // 
            this.btnProcessBook.Location = new System.Drawing.Point(222, 138);
            this.btnProcessBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcessBook.Name = "btnProcessBook";
            this.btnProcessBook.Size = new System.Drawing.Size(98, 46);
            this.btnProcessBook.TabIndex = 1;
            this.btnProcessBook.Text = "Process Books";
            this.btnProcessBook.UseVisualStyleBackColor = true;
            this.btnProcessBook.Click += new System.EventHandler(this.btnProcessBook_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(222, 214);
            this.btnTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(96, 44);
            this.btnTransaction.TabIndex = 2;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnBookManagement
            // 
            this.btnBookManagement.Location = new System.Drawing.Point(222, 285);
            this.btnBookManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookManagement.Name = "btnBookManagement";
            this.btnBookManagement.Size = new System.Drawing.Size(96, 44);
            this.btnBookManagement.TabIndex = 3;
            this.btnBookManagement.Text = "Book Management";
            this.btnBookManagement.UseVisualStyleBackColor = true;
            this.btnBookManagement.Click += new System.EventHandler(this.btnBookManagement_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 359);
            this.Controls.Add(this.btnBookManagement);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnProcessBook);
            this.Controls.Add(this.btnBookSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnProcessBook;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnBookManagement;
    }
}

