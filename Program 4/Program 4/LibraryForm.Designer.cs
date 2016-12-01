namespace Program_4
{
    partial class program4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.callnumTxt = new System.Windows.Forms.TextBox();
            this.copyrightTxt = new System.Windows.Forms.TextBox();
            this.publisherTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.bookListGroup = new System.Windows.Forms.GroupBox();
            this.returnBttn = new System.Windows.Forms.Button();
            this.checkOutBttn = new System.Windows.Forms.Button();
            this.detailsBttn = new System.Windows.Forms.Button();
            this.BookList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.bookListGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBttn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.copyrightLabel);
            this.groupBox1.Controls.Add(this.publisherLabel);
            this.groupBox1.Controls.Add(this.authorLabel);
            this.groupBox1.Controls.Add(this.titleLabel);
            this.groupBox1.Controls.Add(this.callnumTxt);
            this.groupBox1.Controls.Add(this.copyrightTxt);
            this.groupBox1.Controls.Add(this.publisherTxt);
            this.groupBox1.Controls.Add(this.authorTxt);
            this.groupBox1.Controls.Add(this.titleTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Library Book Information";
            // 
            // addBttn
            // 
            this.addBttn.Location = new System.Drawing.Point(62, 159);
            this.addBttn.Name = "addBttn";
            this.addBttn.Size = new System.Drawing.Size(75, 23);
            this.addBttn.TabIndex = 11;
            this.addBttn.Text = "Add Book";
            this.addBttn.UseVisualStyleBackColor = true;
            this.addBttn.Click += new System.EventHandler(this.addBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Call Number";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(10, 110);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(79, 13);
            this.copyrightLabel.TabIndex = 9;
            this.copyrightLabel.Text = "Enter Copyright";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(10, 84);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(78, 13);
            this.publisherLabel.TabIndex = 8;
            this.publisherLabel.Text = "Enter Publisher";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(10, 58);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(65, 13);
            this.authorLabel.TabIndex = 7;
            this.authorLabel.Text = "Enter author";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(10, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 13);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Enter Title";
            // 
            // callnumTxt
            // 
            this.callnumTxt.Location = new System.Drawing.Point(111, 133);
            this.callnumTxt.Name = "callnumTxt";
            this.callnumTxt.Size = new System.Drawing.Size(100, 20);
            this.callnumTxt.TabIndex = 4;
            // 
            // copyrightTxt
            // 
            this.copyrightTxt.Location = new System.Drawing.Point(111, 107);
            this.copyrightTxt.Name = "copyrightTxt";
            this.copyrightTxt.Size = new System.Drawing.Size(100, 20);
            this.copyrightTxt.TabIndex = 3;
            // 
            // publisherTxt
            // 
            this.publisherTxt.Location = new System.Drawing.Point(111, 81);
            this.publisherTxt.Name = "publisherTxt";
            this.publisherTxt.Size = new System.Drawing.Size(100, 20);
            this.publisherTxt.TabIndex = 2;
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(111, 55);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(100, 20);
            this.authorTxt.TabIndex = 1;
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(111, 29);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(100, 20);
            this.titleTxt.TabIndex = 1;
            // 
            // bookListGroup
            // 
            this.bookListGroup.Controls.Add(this.returnBttn);
            this.bookListGroup.Controls.Add(this.checkOutBttn);
            this.bookListGroup.Controls.Add(this.detailsBttn);
            this.bookListGroup.Controls.Add(this.BookList);
            this.bookListGroup.Location = new System.Drawing.Point(247, 29);
            this.bookListGroup.Name = "bookListGroup";
            this.bookListGroup.Size = new System.Drawing.Size(210, 194);
            this.bookListGroup.TabIndex = 12;
            this.bookListGroup.TabStop = false;
            this.bookListGroup.Text = "Your Library Books";
            // 
            // returnBttn
            // 
            this.returnBttn.Location = new System.Drawing.Point(147, 156);
            this.returnBttn.Name = "returnBttn";
            this.returnBttn.Size = new System.Drawing.Size(57, 23);
            this.returnBttn.TabIndex = 3;
            this.returnBttn.Text = "Return";
            this.returnBttn.UseVisualStyleBackColor = true;
            this.returnBttn.Click += new System.EventHandler(this.returnBttn_Click);
            // 
            // checkOutBttn
            // 
            this.checkOutBttn.Location = new System.Drawing.Point(72, 156);
            this.checkOutBttn.Name = "checkOutBttn";
            this.checkOutBttn.Size = new System.Drawing.Size(70, 23);
            this.checkOutBttn.TabIndex = 2;
            this.checkOutBttn.Text = "Check out";
            this.checkOutBttn.UseVisualStyleBackColor = true;
            this.checkOutBttn.Click += new System.EventHandler(this.checkOutBttn_Click);
            // 
            // detailsBttn
            // 
            this.detailsBttn.Location = new System.Drawing.Point(6, 156);
            this.detailsBttn.Name = "detailsBttn";
            this.detailsBttn.Size = new System.Drawing.Size(60, 23);
            this.detailsBttn.TabIndex = 1;
            this.detailsBttn.Text = "Details";
            this.detailsBttn.UseVisualStyleBackColor = true;
            this.detailsBttn.Click += new System.EventHandler(this.detailsBttn_Click);
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(3, 16);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(201, 134);
            this.BookList.TabIndex = 0;
            // 
            // program4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 245);
            this.Controls.Add(this.bookListGroup);
            this.Controls.Add(this.groupBox1);
            this.Name = "program4";
            this.Text = "Program 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bookListGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox callnumTxt;
        private System.Windows.Forms.TextBox copyrightTxt;
        private System.Windows.Forms.TextBox publisherTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addBttn;
        private System.Windows.Forms.GroupBox bookListGroup;
        private System.Windows.Forms.Button returnBttn;
        private System.Windows.Forms.Button checkOutBttn;
        private System.Windows.Forms.Button detailsBttn;
        private System.Windows.Forms.ListBox BookList;
    }
}

