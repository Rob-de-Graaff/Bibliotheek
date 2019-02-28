namespace Bibliotheek
{
    partial class Form1
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
            this.panelLayout = new System.Windows.Forms.Panel();
            this.buttonRemoveReturnedBook = new System.Windows.Forms.Button();
            this.buttonAddReturnedBook = new System.Windows.Forms.Button();
            this.listBoxReturnedBooks = new System.Windows.Forms.ListBox();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.numericUpDownMonth1 = new System.Windows.Forms.NumericUpDown();
            this.panelDay = new System.Windows.Forms.Panel();
            this.numericUpDownDay1 = new System.Windows.Forms.NumericUpDown();
            this.panelYear = new System.Windows.Forms.Panel();
            this.numericUpDownYear1 = new System.Windows.Forms.NumericUpDown();
            this.buttonReset = new System.Windows.Forms.Button();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.listBoxLentBooks = new System.Windows.Forms.ListBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTicketsTotal = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.panelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.panelMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).BeginInit();
            this.panelDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).BeginInit();
            this.panelYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLayout
            // 
            this.panelLayout.Controls.Add(this.buttonRemoveReturnedBook);
            this.panelLayout.Controls.Add(this.buttonAddReturnedBook);
            this.panelLayout.Controls.Add(this.listBoxReturnedBooks);
            this.panelLayout.Controls.Add(this.buttonRemoveBook);
            this.panelLayout.Controls.Add(this.labelDateOfBirth);
            this.panelLayout.Controls.Add(this.numericUpDownAmount);
            this.panelLayout.Controls.Add(this.panelMonth);
            this.panelLayout.Controls.Add(this.panelDay);
            this.panelLayout.Controls.Add(this.panelYear);
            this.panelLayout.Controls.Add(this.buttonReset);
            this.panelLayout.Controls.Add(this.listBoxBooks);
            this.panelLayout.Controls.Add(this.buttonAddBook);
            this.panelLayout.Controls.Add(this.listBoxLentBooks);
            this.panelLayout.Controls.Add(this.buttonCalculate);
            this.panelLayout.Controls.Add(this.labelTicketsTotal);
            this.panelLayout.Controls.Add(this.labelPriceTotal);
            this.panelLayout.Location = new System.Drawing.Point(12, 12);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(1169, 401);
            this.panelLayout.TabIndex = 30;
            // 
            // buttonRemoveReturnedBook
            // 
            this.buttonRemoveReturnedBook.Location = new System.Drawing.Point(1053, 47);
            this.buttonRemoveReturnedBook.Name = "buttonRemoveReturnedBook";
            this.buttonRemoveReturnedBook.Size = new System.Drawing.Size(112, 33);
            this.buttonRemoveReturnedBook.TabIndex = 71;
            this.buttonRemoveReturnedBook.Text = "Remove Book";
            this.buttonRemoveReturnedBook.UseVisualStyleBackColor = true;
            this.buttonRemoveReturnedBook.Click += new System.EventHandler(this.ButtonRemoveReturnedBook_Click);
            // 
            // buttonAddReturnedBook
            // 
            this.buttonAddReturnedBook.Location = new System.Drawing.Point(951, 47);
            this.buttonAddReturnedBook.Name = "buttonAddReturnedBook";
            this.buttonAddReturnedBook.Size = new System.Drawing.Size(89, 33);
            this.buttonAddReturnedBook.TabIndex = 69;
            this.buttonAddReturnedBook.Text = "Add Book";
            this.buttonAddReturnedBook.UseVisualStyleBackColor = true;
            this.buttonAddReturnedBook.Click += new System.EventHandler(this.ButtonAddReturnedBook_Click);
            // 
            // listBoxReturnedBooks
            // 
            this.listBoxReturnedBooks.FormattingEnabled = true;
            this.listBoxReturnedBooks.ItemHeight = 16;
            this.listBoxReturnedBooks.Location = new System.Drawing.Point(688, 86);
            this.listBoxReturnedBooks.Name = "listBoxReturnedBooks";
            this.listBoxReturnedBooks.Size = new System.Drawing.Size(477, 68);
            this.listBoxReturnedBooks.TabIndex = 70;
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Location = new System.Drawing.Point(105, 105);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(117, 33);
            this.buttonRemoveBook.TabIndex = 68;
            this.buttonRemoveBook.Text = "Remove Book";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            this.buttonRemoveBook.Click += new System.EventHandler(this.ButtonRemoveBook_Click);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(855, 8);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(89, 17);
            this.labelDateOfBirth.TabIndex = 66;
            this.labelDateOfBirth.Text = "Return Date:";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(10, 78);
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAmount.TabIndex = 64;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelMonth
            // 
            this.panelMonth.Controls.Add(this.numericUpDownMonth1);
            this.panelMonth.Location = new System.Drawing.Point(1026, 3);
            this.panelMonth.Name = "panelMonth";
            this.panelMonth.Size = new System.Drawing.Size(47, 38);
            this.panelMonth.TabIndex = 62;
            // 
            // numericUpDownMonth1
            // 
            this.numericUpDownMonth1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownMonth1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth1.Name = "numericUpDownMonth1";
            this.numericUpDownMonth1.ReadOnly = true;
            this.numericUpDownMonth1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownMonth1.TabIndex = 25;
            this.numericUpDownMonth1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelDay
            // 
            this.panelDay.Controls.Add(this.numericUpDownDay1);
            this.panelDay.Location = new System.Drawing.Point(951, 3);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(47, 38);
            this.panelDay.TabIndex = 63;
            // 
            // numericUpDownDay1
            // 
            this.numericUpDownDay1.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownDay1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay1.Name = "numericUpDownDay1";
            this.numericUpDownDay1.ReadOnly = true;
            this.numericUpDownDay1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownDay1.TabIndex = 26;
            this.numericUpDownDay1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelYear
            // 
            this.panelYear.Controls.Add(this.numericUpDownYear1);
            this.panelYear.Location = new System.Drawing.Point(1100, 2);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(67, 39);
            this.panelYear.TabIndex = 61;
            // 
            // numericUpDownYear1
            // 
            this.numericUpDownYear1.Location = new System.Drawing.Point(1, 1);
            this.numericUpDownYear1.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDownYear1.Minimum = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            this.numericUpDownYear1.Name = "numericUpDownYear1";
            this.numericUpDownYear1.ReadOnly = true;
            this.numericUpDownYear1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownYear1.TabIndex = 24;
            this.numericUpDownYear1.Value = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1090, 365);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 33);
            this.buttonReset.TabIndex = 60;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.ItemHeight = 16;
            this.listBoxBooks.Location = new System.Drawing.Point(3, 3);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(477, 68);
            this.listBoxBooks.TabIndex = 59;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(3, 105);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(89, 33);
            this.buttonAddBook.TabIndex = 57;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // listBoxLentBooks
            // 
            this.listBoxLentBooks.FormattingEnabled = true;
            this.listBoxLentBooks.ItemHeight = 16;
            this.listBoxLentBooks.Location = new System.Drawing.Point(3, 144);
            this.listBoxLentBooks.Name = "listBoxLentBooks";
            this.listBoxLentBooks.Size = new System.Drawing.Size(477, 68);
            this.listBoxLentBooks.TabIndex = 57;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(10, 365);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(89, 33);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "show price";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelTicketsTotal
            // 
            this.labelTicketsTotal.AutoSize = true;
            this.labelTicketsTotal.Location = new System.Drawing.Point(7, 278);
            this.labelTicketsTotal.Name = "labelTicketsTotal";
            this.labelTicketsTotal.Size = new System.Drawing.Size(13, 17);
            this.labelTicketsTotal.TabIndex = 22;
            this.labelTicketsTotal.Text = "-";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Location = new System.Drawing.Point(7, 336);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(13, 17);
            this.labelPriceTotal.TabIndex = 21;
            this.labelPriceTotal.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 450);
            this.Controls.Add(this.panelLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLayout.ResumeLayout(false);
            this.panelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.panelMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).EndInit();
            this.panelDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).EndInit();
            this.panelYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Panel panelMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth1;
        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.NumericUpDown numericUpDownDay1;
        private System.Windows.Forms.Panel panelYear;
        private System.Windows.Forms.NumericUpDown numericUpDownYear1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.ListBox listBoxLentBooks;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTicketsTotal;
        private System.Windows.Forms.Label labelPriceTotal;
        private System.Windows.Forms.Button buttonRemoveReturnedBook;
        private System.Windows.Forms.Button buttonAddReturnedBook;
        private System.Windows.Forms.ListBox listBoxReturnedBooks;
    }
}

