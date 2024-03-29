namespace knowledge_hub
{
    partial class UserDashboard
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
            this.btnClose = new System.Windows.Forms.Button();
            this.listBoxCheckedOutBooks = new System.Windows.Forms.ListBox();
            this.listBoxOverdueBooks = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payFineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tansactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCheckedOutBooks = new System.Windows.Forms.Label();
            this.labelBooksOverdueNextWeek = new System.Windows.Forms.Label();
            this.labelAccBalance = new System.Windows.Forms.Label();
            this.textBoxAccBalance = new System.Windows.Forms.TextBox();
            this.groupBoxProfile = new System.Windows.Forms.GroupBox();
            this.textBoxWelcomeMessage = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(370, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 66);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listBoxCheckedOutBooks
            // 
            this.listBoxCheckedOutBooks.FormattingEnabled = true;
            this.listBoxCheckedOutBooks.ItemHeight = 16;
            this.listBoxCheckedOutBooks.Location = new System.Drawing.Point(22, 74);
            this.listBoxCheckedOutBooks.Name = "listBoxCheckedOutBooks";
            this.listBoxCheckedOutBooks.Size = new System.Drawing.Size(630, 132);
            this.listBoxCheckedOutBooks.TabIndex = 1;
            // 
            // listBoxOverdueBooks
            // 
            this.listBoxOverdueBooks.FormattingEnabled = true;
            this.listBoxOverdueBooks.ItemHeight = 16;
            this.listBoxOverdueBooks.Location = new System.Drawing.Point(22, 250);
            this.listBoxOverdueBooks.Name = "listBoxOverdueBooks";
            this.listBoxOverdueBooks.Size = new System.Drawing.Size(630, 116);
            this.listBoxOverdueBooks.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutToolStripMenuItem.Text = "&Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBooksToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // searchBooksToolStripMenuItem
            // 
            this.searchBooksToolStripMenuItem.Name = "searchBooksToolStripMenuItem";
            this.searchBooksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.searchBooksToolStripMenuItem.Text = "&Search";
            this.searchBooksToolStripMenuItem.Click += new System.EventHandler(this.searchBooksToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.returnBookToolStripMenuItem.Text = "&Return Book";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.updateProfileToolStripMenuItem.Text = "Update";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMoneyToolStripMenuItem,
            this.payFineToolStripMenuItem,
            this.tansactionsToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // addMoneyToolStripMenuItem
            // 
            this.addMoneyToolStripMenuItem.Name = "addMoneyToolStripMenuItem";
            this.addMoneyToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.addMoneyToolStripMenuItem.Text = "Add Money";
            // 
            // payFineToolStripMenuItem
            // 
            this.payFineToolStripMenuItem.Name = "payFineToolStripMenuItem";
            this.payFineToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.payFineToolStripMenuItem.Text = "Pay Fine";
            // 
            // tansactionsToolStripMenuItem
            // 
            this.tansactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allTransactionsToolStripMenuItem,
            this.cardDetailsToolStripMenuItem});
            this.tansactionsToolStripMenuItem.Name = "tansactionsToolStripMenuItem";
            this.tansactionsToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.tansactionsToolStripMenuItem.Text = "View";
            // 
            // allTransactionsToolStripMenuItem
            // 
            this.allTransactionsToolStripMenuItem.Name = "allTransactionsToolStripMenuItem";
            this.allTransactionsToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.allTransactionsToolStripMenuItem.Text = "All Transactions";
            // 
            // cardDetailsToolStripMenuItem
            // 
            this.cardDetailsToolStripMenuItem.Name = "cardDetailsToolStripMenuItem";
            this.cardDetailsToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.cardDetailsToolStripMenuItem.Text = "Card Details";
            // 
            // labelCheckedOutBooks
            // 
            this.labelCheckedOutBooks.AutoSize = true;
            this.labelCheckedOutBooks.Location = new System.Drawing.Point(22, 52);
            this.labelCheckedOutBooks.Name = "labelCheckedOutBooks";
            this.labelCheckedOutBooks.Size = new System.Drawing.Size(126, 16);
            this.labelCheckedOutBooks.TabIndex = 4;
            this.labelCheckedOutBooks.Text = "Checked Out Books";
            // 
            // labelBooksOverdueNextWeek
            // 
            this.labelBooksOverdueNextWeek.AutoSize = true;
            this.labelBooksOverdueNextWeek.Location = new System.Drawing.Point(22, 228);
            this.labelBooksOverdueNextWeek.Name = "labelBooksOverdueNextWeek";
            this.labelBooksOverdueNextWeek.Size = new System.Drawing.Size(170, 16);
            this.labelBooksOverdueNextWeek.TabIndex = 5;
            this.labelBooksOverdueNextWeek.Text = "Books Overdue Next Week";
            // 
            // labelAccBalance
            // 
            this.labelAccBalance.AutoSize = true;
            this.labelAccBalance.Location = new System.Drawing.Point(25, 77);
            this.labelAccBalance.Name = "labelAccBalance";
            this.labelAccBalance.Size = new System.Drawing.Size(108, 16);
            this.labelAccBalance.TabIndex = 6;
            this.labelAccBalance.Text = "Account Balance";
            // 
            // textBoxAccBalance
            // 
            this.textBoxAccBalance.Location = new System.Drawing.Point(28, 96);
            this.textBoxAccBalance.Name = "textBoxAccBalance";
            this.textBoxAccBalance.ReadOnly = true;
            this.textBoxAccBalance.Size = new System.Drawing.Size(140, 22);
            this.textBoxAccBalance.TabIndex = 7;
            // 
            // groupBoxProfile
            // 
            this.groupBoxProfile.Controls.Add(this.textBoxWelcomeMessage);
            this.groupBoxProfile.Controls.Add(this.textBoxAccBalance);
            this.groupBoxProfile.Controls.Add(this.labelAccBalance);
            this.groupBoxProfile.Location = new System.Drawing.Point(684, 74);
            this.groupBoxProfile.Name = "groupBoxProfile";
            this.groupBoxProfile.Size = new System.Drawing.Size(193, 292);
            this.groupBoxProfile.TabIndex = 8;
            this.groupBoxProfile.TabStop = false;
            // 
            // textBoxWelcomeMessage
            // 
            this.textBoxWelcomeMessage.Location = new System.Drawing.Point(23, 22);
            this.textBoxWelcomeMessage.Name = "textBoxWelcomeMessage";
            this.textBoxWelcomeMessage.ReadOnly = true;
            this.textBoxWelcomeMessage.Size = new System.Drawing.Size(145, 22);
            this.textBoxWelcomeMessage.TabIndex = 8;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 480);
            this.Controls.Add(this.groupBoxProfile);
            this.Controls.Add(this.labelBooksOverdueNextWeek);
            this.Controls.Add(this.labelCheckedOutBooks);
            this.Controls.Add(this.listBoxOverdueBooks);
            this.Controls.Add(this.listBoxCheckedOutBooks);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserDashboard";
            this.Text = "User Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxProfile.ResumeLayout(false);
            this.groupBoxProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listBoxCheckedOutBooks;
        private System.Windows.Forms.ListBox listBoxOverdueBooks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBooksToolStripMenuItem;
        private System.Windows.Forms.Label labelCheckedOutBooks;
        private System.Windows.Forms.Label labelBooksOverdueNextWeek;
        private System.Windows.Forms.Label labelAccBalance;
        private System.Windows.Forms.TextBox textBoxAccBalance;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tansactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payFineToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxProfile;
        private System.Windows.Forms.TextBox textBoxWelcomeMessage;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
    }
}