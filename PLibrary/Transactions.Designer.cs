namespace PLibrary
{
    partial class Transactions
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
            this.SelectAcc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectTrans = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Books = new System.Windows.Forms.TextBox();
            this.tDate = new System.Windows.Forms.TextBox();
            this.dDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SelectAcc
            // 
            this.SelectAcc.FormattingEnabled = true;
            this.SelectAcc.Location = new System.Drawing.Point(21, 31);
            this.SelectAcc.Name = "SelectAcc";
            this.SelectAcc.Size = new System.Drawing.Size(121, 21);
            this.SelectAcc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transaction";
            // 
            // SelectTrans
            // 
            this.SelectTrans.FormattingEnabled = true;
            this.SelectTrans.Location = new System.Drawing.Point(166, 31);
            this.SelectTrans.Name = "SelectTrans";
            this.SelectTrans.Size = new System.Drawing.Size(121, 21);
            this.SelectTrans.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transaction Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Book(s)";
            // 
            // Books
            // 
            this.Books.Location = new System.Drawing.Point(25, 160);
            this.Books.Multiline = true;
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(343, 251);
            this.Books.TabIndex = 7;
            // 
            // tDate
            // 
            this.tDate.Location = new System.Drawing.Point(21, 105);
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(100, 20);
            this.tDate.TabIndex = 8;
            // 
            // dDate
            // 
            this.dDate.Location = new System.Drawing.Point(166, 105);
            this.dDate.Name = "dDate";
            this.dDate.Size = new System.Drawing.Size(100, 20);
            this.dDate.TabIndex = 9;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dDate);
            this.Controls.Add(this.tDate);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectAcc);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Books;
        private System.Windows.Forms.TextBox tDate;
        private System.Windows.Forms.TextBox dDate;
    }
}