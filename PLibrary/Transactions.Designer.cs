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
            this.label5 = new System.Windows.Forms.Label();
            this.BookTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.Returned = new System.Windows.Forms.TextBox();
            this.SelectMax = new System.Windows.Forms.DateTimePicker();
            this.SelectMin = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Transaction = new System.Windows.Forms.TextBox();
            this.Account = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tDate = new System.Windows.Forms.TextBox();
            this.dDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ViewTrans = new System.Windows.Forms.Button();
            this.SelectBook = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectAcc
            // 
            this.SelectAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAcc.FormattingEnabled = true;
            this.SelectAcc.Location = new System.Drawing.Point(32, 61);
            this.SelectAcc.Name = "SelectAcc";
            this.SelectAcc.Size = new System.Drawing.Size(187, 32);
            this.SelectAcc.TabIndex = 0;
            this.SelectAcc.SelectedIndexChanged += new System.EventHandler(this.SelectAcc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transaction ID";
            // 
            // SelectTrans
            // 
            this.SelectTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTrans.FormattingEnabled = true;
            this.SelectTrans.Location = new System.Drawing.Point(247, 61);
            this.SelectTrans.Name = "SelectTrans";
            this.SelectTrans.Size = new System.Drawing.Size(173, 32);
            this.SelectTrans.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Book(s)";
            // 
            // BookTitle
            // 
            this.BookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTitle.Location = new System.Drawing.Point(30, 245);
            this.BookTitle.Multiline = true;
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(270, 546);
            this.BookTitle.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(577, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Returned?";
            // 
            // BookAuthor
            // 
            this.BookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAuthor.Location = new System.Drawing.Point(306, 245);
            this.BookAuthor.Multiline = true;
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(268, 546);
            this.BookAuthor.TabIndex = 13;
            // 
            // Returned
            // 
            this.Returned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returned.Location = new System.Drawing.Point(580, 245);
            this.Returned.Multiline = true;
            this.Returned.Name = "Returned";
            this.Returned.Size = new System.Drawing.Size(72, 546);
            this.Returned.TabIndex = 14;
            // 
            // SelectMax
            // 
            this.SelectMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectMax.Location = new System.Drawing.Point(551, 131);
            this.SelectMax.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.SelectMax.MinDate = new System.DateTime(2019, 11, 15, 0, 0, 0, 0);
            this.SelectMax.Name = "SelectMax";
            this.SelectMax.Size = new System.Drawing.Size(349, 29);
            this.SelectMax.TabIndex = 16;
            // 
            // SelectMin
            // 
            this.SelectMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectMin.Location = new System.Drawing.Point(118, 131);
            this.SelectMin.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.SelectMin.MinDate = new System.DateTime(2019, 11, 15, 0, 0, 0, 0);
            this.SelectMin.Name = "SelectMin";
            this.SelectMin.Size = new System.Drawing.Size(348, 29);
            this.SelectMin.TabIndex = 17;
            this.SelectMin.Value = new System.DateTime(2019, 11, 15, 9, 42, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = "From";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(509, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 26);
            this.label12.TabIndex = 20;
            this.label12.Text = "To";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(883, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Transaction";
            // 
            // Transaction
            // 
            this.Transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction.Location = new System.Drawing.Point(886, 245);
            this.Transaction.Multiline = true;
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(80, 546);
            this.Transaction.TabIndex = 23;
            // 
            // Account
            // 
            this.Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account.Location = new System.Drawing.Point(658, 245);
            this.Account.Multiline = true;
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(222, 546);
            this.Account.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(658, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Account";
            // 
            // tDate
            // 
            this.tDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDate.Location = new System.Drawing.Point(972, 245);
            this.tDate.Multiline = true;
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(81, 546);
            this.tDate.TabIndex = 26;
            // 
            // dDate
            // 
            this.dDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dDate.Location = new System.Drawing.Point(1059, 243);
            this.dDate.Multiline = true;
            this.dDate.Name = "dDate";
            this.dDate.Size = new System.Drawing.Size(81, 548);
            this.dDate.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(972, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1056, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Due";
            // 
            // ViewTrans
            // 
            this.ViewTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTrans.Location = new System.Drawing.Point(944, 50);
            this.ViewTrans.Name = "ViewTrans";
            this.ViewTrans.Size = new System.Drawing.Size(179, 90);
            this.ViewTrans.TabIndex = 30;
            this.ViewTrans.Text = "View";
            this.ViewTrans.UseVisualStyleBackColor = true;
            this.ViewTrans.Click += new System.EventHandler(this.ViewTrans_Click);
            // 
            // SelectBook
            // 
            this.SelectBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBook.FormattingEnabled = true;
            this.SelectBook.Location = new System.Drawing.Point(448, 61);
            this.SelectBook.Name = "SelectBook";
            this.SelectBook.Size = new System.Drawing.Size(452, 32);
            this.SelectBook.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Book";
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 821);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectBook);
            this.Controls.Add(this.ViewTrans);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dDate);
            this.Controls.Add(this.tDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.Transaction);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SelectMin);
            this.Controls.Add(this.SelectMax);
            this.Controls.Add(this.Returned);
            this.Controls.Add(this.BookAuthor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SelectTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectAcc);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectTrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BookTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.TextBox Returned;
        private System.Windows.Forms.DateTimePicker SelectMax;
        private System.Windows.Forms.DateTimePicker SelectMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Transaction;
        private System.Windows.Forms.TextBox Account;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tDate;
        private System.Windows.Forms.TextBox dDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ViewTrans;
        private System.Windows.Forms.ComboBox SelectBook;
        private System.Windows.Forms.Label label3;
    }
}