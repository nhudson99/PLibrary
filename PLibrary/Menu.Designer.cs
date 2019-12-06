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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnProcessBook = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnBookManagement = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(632, 80);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(147, 83);
            this.btnBookSearch.TabIndex = 0;
            this.btnBookSearch.Text = "Search For Book";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnProcessBook
            // 
            this.btnProcessBook.Location = new System.Drawing.Point(632, 203);
            this.btnProcessBook.Name = "btnProcessBook";
            this.btnProcessBook.Size = new System.Drawing.Size(147, 71);
            this.btnProcessBook.TabIndex = 1;
            this.btnProcessBook.Text = "Process Books";
            this.btnProcessBook.UseVisualStyleBackColor = true;
            this.btnProcessBook.Click += new System.EventHandler(this.btnProcessBook_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(632, 320);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(144, 68);
            this.btnTransaction.TabIndex = 2;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnBookManagement
            // 
            this.btnBookManagement.Location = new System.Drawing.Point(632, 429);
            this.btnBookManagement.Name = "btnBookManagement";
            this.btnBookManagement.Size = new System.Drawing.Size(144, 68);
            this.btnBookManagement.TabIndex = 3;
            this.btnBookManagement.Text = "Book Management";
            this.btnBookManagement.UseVisualStyleBackColor = true;
            this.btnBookManagement.Click += new System.EventHandler(this.btnBookManagement_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 80);
            this.label2.TabIndex = 6;
            this.label2.Text = "PLibrary Management System";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBookManagement);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnProcessBook);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnProcessBook;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnBookManagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

