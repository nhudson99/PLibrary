namespace PLibrary
{
    partial class CheckIn
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
            this.SelectBook = new System.Windows.Forms.ComboBox();
            this.btn_Process = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectAcc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TransactionView = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectBook
            // 
            this.SelectBook.FormattingEnabled = true;
            this.SelectBook.Location = new System.Drawing.Point(155, 92);
            this.SelectBook.Margin = new System.Windows.Forms.Padding(2);
            this.SelectBook.Name = "SelectBook";
            this.SelectBook.Size = new System.Drawing.Size(92, 21);
            this.SelectBook.TabIndex = 14;
            this.SelectBook.SelectedIndexChanged += new System.EventHandler(this.SelectBook_SelectedIndexChanged);
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(265, 93);
            this.btn_Process.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(56, 19);
            this.btn_Process.TabIndex = 13;
            this.btn_Process.Text = "Process";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.Btn_Process_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Book ID";
            // 
            // SelectAcc
            // 
            this.SelectAcc.FormattingEnabled = true;
            this.SelectAcc.Location = new System.Drawing.Point(175, 44);
            this.SelectAcc.Margin = new System.Windows.Forms.Padding(2);
            this.SelectAcc.Name = "SelectAcc";
            this.SelectAcc.Size = new System.Drawing.Size(146, 21);
            this.SelectAcc.TabIndex = 9;
            this.SelectAcc.SelectedIndexChanged += new System.EventHandler(this.SelectAcc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select an Account";
            // 
            // TransactionView
            // 
            this.TransactionView.FormattingEnabled = true;
            this.TransactionView.Location = new System.Drawing.Point(164, 131);
            this.TransactionView.Margin = new System.Windows.Forms.Padding(2);
            this.TransactionView.Name = "TransactionView";
            this.TransactionView.Size = new System.Drawing.Size(92, 21);
            this.TransactionView.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Transaction ID";
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 167);
            this.Controls.Add(this.TransactionView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectBook);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectAcc);
            this.Controls.Add(this.label1);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectBook;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TransactionView;
        private System.Windows.Forms.Label label3;
    }
}