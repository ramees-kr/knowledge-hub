namespace knowlegde_hub
{
    partial class AdminDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatronsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPatronsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatronsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatronsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxInventoryStats = new System.Windows.Forms.GroupBox();
            this.textBoxFines = new System.Windows.Forms.TextBox();
            this.labelFines = new System.Windows.Forms.Label();
            this.labelCheckedOutCount = new System.Windows.Forms.Label();
            this.textBoxCheckedOutCount = new System.Windows.Forms.TextBox();
            this.textBoxBooksCount = new System.Windows.Forms.TextBox();
            this.labelBooksCount = new System.Windows.Forms.Label();
            this.textBoxPatronsCount = new System.Windows.Forms.TextBox();
            this.labelPatronsInventory = new System.Windows.Forms.Label();
            this.listBoxBooksCatalog = new System.Windows.Forms.ListBox();
            this.labelBooksCatalog = new System.Windows.Forms.Label();
            this.labelPatrons = new System.Windows.Forms.Label();
            this.listBoxPatrons = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.comboBoxFilterAttribute = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFilterType = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxInventoryStats.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1038, 485);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.patronsToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1152, 28);
            this.menuStrip1.TabIndex = 1;
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
            this.addBooksToolStripMenuItem,
            this.updateBooksToolStripMenuItem,
            this.viewBooksToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.booksToolStripMenuItem.Text = "&Books";
            // 
            // addBooksToolStripMenuItem
            // 
            this.addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            this.addBooksToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.addBooksToolStripMenuItem.Text = "&Add";
            // 
            // updateBooksToolStripMenuItem
            // 
            this.updateBooksToolStripMenuItem.Name = "updateBooksToolStripMenuItem";
            this.updateBooksToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.updateBooksToolStripMenuItem.Text = "&Update";
            // 
            // viewBooksToolStripMenuItem
            // 
            this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.viewBooksToolStripMenuItem.Text = "&View";
            // 
            // patronsToolStripMenuItem
            // 
            this.patronsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatronsToolStripMenuItem,
            this.editPatronsToolStripMenuItem,
            this.deletePatronsToolStripMenuItem,
            this.viewPatronsToolStripMenuItem});
            this.patronsToolStripMenuItem.Name = "patronsToolStripMenuItem";
            this.patronsToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.patronsToolStripMenuItem.Text = "&Patrons";
            // 
            // addPatronsToolStripMenuItem
            // 
            this.addPatronsToolStripMenuItem.Name = "addPatronsToolStripMenuItem";
            this.addPatronsToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.addPatronsToolStripMenuItem.Text = "&Add";
            // 
            // editPatronsToolStripMenuItem
            // 
            this.editPatronsToolStripMenuItem.Name = "editPatronsToolStripMenuItem";
            this.editPatronsToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.editPatronsToolStripMenuItem.Text = "&Edit";
            // 
            // deletePatronsToolStripMenuItem
            // 
            this.deletePatronsToolStripMenuItem.Name = "deletePatronsToolStripMenuItem";
            this.deletePatronsToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.deletePatronsToolStripMenuItem.Text = "&Delete";
            // 
            // viewPatronsToolStripMenuItem
            // 
            this.viewPatronsToolStripMenuItem.Name = "viewPatronsToolStripMenuItem";
            this.viewPatronsToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.viewPatronsToolStripMenuItem.Text = "&View";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Pr&ofile";
            // 
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.updateProfileToolStripMenuItem.Text = "&Update";
            // 
            // groupBoxInventoryStats
            // 
            this.groupBoxInventoryStats.Controls.Add(this.textBoxFines);
            this.groupBoxInventoryStats.Controls.Add(this.labelFines);
            this.groupBoxInventoryStats.Controls.Add(this.labelCheckedOutCount);
            this.groupBoxInventoryStats.Controls.Add(this.textBoxCheckedOutCount);
            this.groupBoxInventoryStats.Controls.Add(this.textBoxBooksCount);
            this.groupBoxInventoryStats.Controls.Add(this.labelBooksCount);
            this.groupBoxInventoryStats.Controls.Add(this.textBoxPatronsCount);
            this.groupBoxInventoryStats.Controls.Add(this.labelPatronsInventory);
            this.groupBoxInventoryStats.Location = new System.Drawing.Point(14, 45);
            this.groupBoxInventoryStats.Name = "groupBoxInventoryStats";
            this.groupBoxInventoryStats.Size = new System.Drawing.Size(1117, 87);
            this.groupBoxInventoryStats.TabIndex = 2;
            this.groupBoxInventoryStats.TabStop = false;
            this.groupBoxInventoryStats.Text = "Inventory";
            // 
            // textBoxFines
            // 
            this.textBoxFines.Location = new System.Drawing.Point(352, 37);
            this.textBoxFines.Name = "textBoxFines";
            this.textBoxFines.Size = new System.Drawing.Size(112, 24);
            this.textBoxFines.TabIndex = 7;
            // 
            // labelFines
            // 
            this.labelFines.AutoSize = true;
            this.labelFines.Location = new System.Drawing.Point(271, 40);
            this.labelFines.Name = "labelFines";
            this.labelFines.Size = new System.Drawing.Size(75, 18);
            this.labelFines.TabIndex = 6;
            this.labelFines.Text = "Fines Due";
            // 
            // labelCheckedOutCount
            // 
            this.labelCheckedOutCount.AutoSize = true;
            this.labelCheckedOutCount.Location = new System.Drawing.Point(800, 37);
            this.labelCheckedOutCount.Name = "labelCheckedOutCount";
            this.labelCheckedOutCount.Size = new System.Drawing.Size(95, 18);
            this.labelCheckedOutCount.TabIndex = 5;
            this.labelCheckedOutCount.Text = "Checked Out";
            // 
            // textBoxCheckedOutCount
            // 
            this.textBoxCheckedOutCount.Location = new System.Drawing.Point(901, 37);
            this.textBoxCheckedOutCount.Name = "textBoxCheckedOutCount";
            this.textBoxCheckedOutCount.Size = new System.Drawing.Size(157, 24);
            this.textBoxCheckedOutCount.TabIndex = 4;
            // 
            // textBoxBooksCount
            // 
            this.textBoxBooksCount.Location = new System.Drawing.Point(613, 37);
            this.textBoxBooksCount.Name = "textBoxBooksCount";
            this.textBoxBooksCount.Size = new System.Drawing.Size(132, 24);
            this.textBoxBooksCount.TabIndex = 3;
            // 
            // labelBooksCount
            // 
            this.labelBooksCount.AutoSize = true;
            this.labelBooksCount.Location = new System.Drawing.Point(518, 40);
            this.labelBooksCount.Name = "labelBooksCount";
            this.labelBooksCount.Size = new System.Drawing.Size(89, 18);
            this.labelBooksCount.TabIndex = 2;
            this.labelBooksCount.Text = "Total Books";
            // 
            // textBoxPatronsCount
            // 
            this.textBoxPatronsCount.Location = new System.Drawing.Point(87, 37);
            this.textBoxPatronsCount.Name = "textBoxPatronsCount";
            this.textBoxPatronsCount.Size = new System.Drawing.Size(129, 24);
            this.textBoxPatronsCount.TabIndex = 1;
            // 
            // labelPatronsInventory
            // 
            this.labelPatronsInventory.AutoSize = true;
            this.labelPatronsInventory.Location = new System.Drawing.Point(20, 37);
            this.labelPatronsInventory.Name = "labelPatronsInventory";
            this.labelPatronsInventory.Size = new System.Drawing.Size(60, 18);
            this.labelPatronsInventory.TabIndex = 0;
            this.labelPatronsInventory.Text = "Patrons";
            // 
            // listBoxBooksCatalog
            // 
            this.listBoxBooksCatalog.FormattingEnabled = true;
            this.listBoxBooksCatalog.ItemHeight = 18;
            this.listBoxBooksCatalog.Location = new System.Drawing.Point(19, 289);
            this.listBoxBooksCatalog.Name = "listBoxBooksCatalog";
            this.listBoxBooksCatalog.Size = new System.Drawing.Size(580, 184);
            this.listBoxBooksCatalog.TabIndex = 3;
            // 
            // labelBooksCatalog
            // 
            this.labelBooksCatalog.AutoSize = true;
            this.labelBooksCatalog.Location = new System.Drawing.Point(16, 265);
            this.labelBooksCatalog.Name = "labelBooksCatalog";
            this.labelBooksCatalog.Size = new System.Drawing.Size(59, 18);
            this.labelBooksCatalog.TabIndex = 4;
            this.labelBooksCatalog.Text = "Catalog";
            // 
            // labelPatrons
            // 
            this.labelPatrons.AutoSize = true;
            this.labelPatrons.Location = new System.Drawing.Point(622, 264);
            this.labelPatrons.Name = "labelPatrons";
            this.labelPatrons.Size = new System.Drawing.Size(60, 18);
            this.labelPatrons.TabIndex = 5;
            this.labelPatrons.Text = "Patrons";
            // 
            // listBoxPatrons
            // 
            this.listBoxPatrons.FormattingEnabled = true;
            this.listBoxPatrons.ItemHeight = 18;
            this.listBoxPatrons.Location = new System.Drawing.Point(625, 289);
            this.listBoxPatrons.Name = "listBoxPatrons";
            this.listBoxPatrons.Size = new System.Drawing.Size(506, 184);
            this.listBoxPatrons.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 24);
            this.textBox1.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(928, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 33);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(26, 37);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(55, 18);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "Search";
            // 
            // comboBoxFilterAttribute
            // 
            this.comboBoxFilterAttribute.FormattingEnabled = true;
            this.comboBoxFilterAttribute.Location = new System.Drawing.Point(770, 33);
            this.comboBoxFilterAttribute.Name = "comboBoxFilterAttribute";
            this.comboBoxFilterAttribute.Size = new System.Drawing.Size(136, 26);
            this.comboBoxFilterAttribute.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFilterType);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.comboBoxFilterAttribute);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelSearch);
            this.groupBox1.Location = new System.Drawing.Point(14, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 85);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.FormattingEnabled = true;
            this.comboBoxFilterType.Location = new System.Drawing.Point(611, 32);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(132, 26);
            this.comboBoxFilterType.TabIndex = 11;
            // 
            // AdminDashboard
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1152, 535);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxPatrons);
            this.Controls.Add(this.labelPatrons);
            this.Controls.Add(this.labelBooksCatalog);
            this.Controls.Add(this.listBoxBooksCatalog);
            this.Controls.Add(this.groupBoxInventoryStats);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxInventoryStats.ResumeLayout(false);
            this.groupBoxInventoryStats.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxInventoryStats;
        private System.Windows.Forms.TextBox textBoxFines;
        private System.Windows.Forms.Label labelFines;
        private System.Windows.Forms.Label labelCheckedOutCount;
        private System.Windows.Forms.TextBox textBoxCheckedOutCount;
        private System.Windows.Forms.TextBox textBoxBooksCount;
        private System.Windows.Forms.Label labelBooksCount;
        private System.Windows.Forms.TextBox textBoxPatronsCount;
        private System.Windows.Forms.Label labelPatronsInventory;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxBooksCatalog;
        private System.Windows.Forms.ToolStripMenuItem addPatronsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPatronsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePatronsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatronsToolStripMenuItem;
        private System.Windows.Forms.Label labelBooksCatalog;
        private System.Windows.Forms.Label labelPatrons;
        private System.Windows.Forms.ListBox listBoxPatrons;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxFilterAttribute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxFilterType;
    }
}