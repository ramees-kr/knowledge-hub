namespace knowledge_hub
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addBooksToolStripMenuItem = new ToolStripMenuItem();
            updateBooksToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            patronsToolStripMenuItem = new ToolStripMenuItem();
            addPatronsToolStripMenuItem = new ToolStripMenuItem();
            editPatronsToolStripMenuItem = new ToolStripMenuItem();
            deletePatronsToolStripMenuItem = new ToolStripMenuItem();
            viewPatronsToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            updateProfileToolStripMenuItem = new ToolStripMenuItem();
            groupBoxInventoryStats = new GroupBox();
            textBoxFines = new TextBox();
            labelFines = new Label();
            labelCheckedOutCount = new Label();
            textBoxCheckedOutCount = new TextBox();
            textBoxBooksCount = new TextBox();
            labelBooksCount = new Label();
            textBoxPatronsCount = new TextBox();
            labelPatronsInventory = new Label();
            textBoxSearch = new TextBox();
            btnSearch = new Button();
            labelSearch = new Label();
            comboBoxFilterAttribute = new ComboBox();
            groupBox1 = new GroupBox();
            comboBoxFilterType = new ComboBox();
            dataGridViewPatrons = new DataGridView();
            groupBoxPatrons = new GroupBox();
            groupBoxBooks = new GroupBox();
            dataGridViewBooks = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBoxInventoryStats.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatrons).BeginInit();
            groupBoxPatrons.SuspendLayout();
            groupBoxBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, booksToolStripMenuItem, patronsToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(12, 3, 0, 3);
            menuStrip1.Size = new Size(1582, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, helpToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(124, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(124, 26);
            helpToolStripMenuItem.Text = "&Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBooksToolStripMenuItem, updateBooksToolStripMenuItem, deleteToolStripMenuItem, viewBooksToolStripMenuItem });
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(63, 24);
            booksToolStripMenuItem.Text = "&Books";
            // 
            // addBooksToolStripMenuItem
            // 
            addBooksToolStripMenuItem.Name = "addBooksToolStripMenuItem";
            addBooksToolStripMenuItem.Size = new Size(141, 26);
            addBooksToolStripMenuItem.Text = "&Add";
            addBooksToolStripMenuItem.Click += addBooksToolStripMenuItem_Click;
            // 
            // updateBooksToolStripMenuItem
            // 
            updateBooksToolStripMenuItem.Name = "updateBooksToolStripMenuItem";
            updateBooksToolStripMenuItem.Size = new Size(141, 26);
            updateBooksToolStripMenuItem.Text = "&Update";
            updateBooksToolStripMenuItem.Click += updateBooksToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(141, 26);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(141, 26);
            viewBooksToolStripMenuItem.Text = "&View";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // patronsToolStripMenuItem
            // 
            patronsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addPatronsToolStripMenuItem, editPatronsToolStripMenuItem, deletePatronsToolStripMenuItem, viewPatronsToolStripMenuItem });
            patronsToolStripMenuItem.Name = "patronsToolStripMenuItem";
            patronsToolStripMenuItem.Size = new Size(52, 24);
            patronsToolStripMenuItem.Text = "&User";
            // 
            // addPatronsToolStripMenuItem
            // 
            addPatronsToolStripMenuItem.Name = "addPatronsToolStripMenuItem";
            addPatronsToolStripMenuItem.Size = new Size(136, 26);
            addPatronsToolStripMenuItem.Text = "&Add";
            addPatronsToolStripMenuItem.Click += addPatronsToolStripMenuItem_Click;
            // 
            // editPatronsToolStripMenuItem
            // 
            editPatronsToolStripMenuItem.Name = "editPatronsToolStripMenuItem";
            editPatronsToolStripMenuItem.Size = new Size(136, 26);
            editPatronsToolStripMenuItem.Text = "&Edit";
            editPatronsToolStripMenuItem.Click += editPatronsToolStripMenuItem_Click;
            // 
            // deletePatronsToolStripMenuItem
            // 
            deletePatronsToolStripMenuItem.Name = "deletePatronsToolStripMenuItem";
            deletePatronsToolStripMenuItem.Size = new Size(136, 26);
            deletePatronsToolStripMenuItem.Text = "&Delete";
            deletePatronsToolStripMenuItem.Click += deletePatronsToolStripMenuItem_Click;
            // 
            // viewPatronsToolStripMenuItem
            // 
            viewPatronsToolStripMenuItem.Name = "viewPatronsToolStripMenuItem";
            viewPatronsToolStripMenuItem.Size = new Size(136, 26);
            viewPatronsToolStripMenuItem.Text = "&View";
            viewPatronsToolStripMenuItem.Click += viewPatronsToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateProfileToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 24);
            profileToolStripMenuItem.Text = "&Profile";
            // 
            // updateProfileToolStripMenuItem
            // 
            updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            updateProfileToolStripMenuItem.Size = new Size(124, 26);
            updateProfileToolStripMenuItem.Text = "&View";
            updateProfileToolStripMenuItem.Click += updateProfileToolStripMenuItem_Click;
            // 
            // groupBoxInventoryStats
            // 
            groupBoxInventoryStats.Controls.Add(textBoxFines);
            groupBoxInventoryStats.Controls.Add(labelFines);
            groupBoxInventoryStats.Controls.Add(labelCheckedOutCount);
            groupBoxInventoryStats.Controls.Add(textBoxCheckedOutCount);
            groupBoxInventoryStats.Controls.Add(textBoxBooksCount);
            groupBoxInventoryStats.Controls.Add(labelBooksCount);
            groupBoxInventoryStats.Controls.Add(textBoxPatronsCount);
            groupBoxInventoryStats.Controls.Add(labelPatronsInventory);
            groupBoxInventoryStats.Location = new Point(19, 62);
            groupBoxInventoryStats.Margin = new Padding(4);
            groupBoxInventoryStats.Name = "groupBoxInventoryStats";
            groupBoxInventoryStats.Padding = new Padding(4);
            groupBoxInventoryStats.Size = new Size(1538, 121);
            groupBoxInventoryStats.TabIndex = 2;
            groupBoxInventoryStats.TabStop = false;
            groupBoxInventoryStats.Text = "Inventory";
            // 
            // textBoxFines
            // 
            textBoxFines.Location = new Point(521, 51);
            textBoxFines.Margin = new Padding(4);
            textBoxFines.Name = "textBoxFines";
            textBoxFines.Size = new Size(148, 30);
            textBoxFines.TabIndex = 7;
            // 
            // labelFines
            // 
            labelFines.AutoSize = true;
            labelFines.Location = new Point(413, 56);
            labelFines.Margin = new Padding(4, 0, 4, 0);
            labelFines.Name = "labelFines";
            labelFines.Size = new Size(101, 25);
            labelFines.TabIndex = 6;
            labelFines.Text = "Fines Due";
            // 
            // labelCheckedOutCount
            // 
            labelCheckedOutCount.AutoSize = true;
            labelCheckedOutCount.Location = new Point(1155, 51);
            labelCheckedOutCount.Margin = new Padding(4, 0, 4, 0);
            labelCheckedOutCount.Name = "labelCheckedOutCount";
            labelCheckedOutCount.Size = new Size(128, 25);
            labelCheckedOutCount.TabIndex = 5;
            labelCheckedOutCount.Text = "Checked Out";
            // 
            // textBoxCheckedOutCount
            // 
            textBoxCheckedOutCount.Location = new Point(1289, 51);
            textBoxCheckedOutCount.Margin = new Padding(4);
            textBoxCheckedOutCount.Name = "textBoxCheckedOutCount";
            textBoxCheckedOutCount.Size = new Size(208, 30);
            textBoxCheckedOutCount.TabIndex = 4;
            // 
            // textBoxBooksCount
            // 
            textBoxBooksCount.Location = new Point(905, 51);
            textBoxBooksCount.Margin = new Padding(4);
            textBoxBooksCount.Name = "textBoxBooksCount";
            textBoxBooksCount.Size = new Size(175, 30);
            textBoxBooksCount.TabIndex = 3;
            // 
            // labelBooksCount
            // 
            labelBooksCount.AutoSize = true;
            labelBooksCount.Location = new Point(779, 56);
            labelBooksCount.Margin = new Padding(4, 0, 4, 0);
            labelBooksCount.Name = "labelBooksCount";
            labelBooksCount.Size = new Size(116, 25);
            labelBooksCount.TabIndex = 2;
            labelBooksCount.Text = "Total Books";
            // 
            // textBoxPatronsCount
            // 
            textBoxPatronsCount.Location = new Point(116, 51);
            textBoxPatronsCount.Margin = new Padding(4);
            textBoxPatronsCount.Name = "textBoxPatronsCount";
            textBoxPatronsCount.Size = new Size(171, 30);
            textBoxPatronsCount.TabIndex = 1;
            // 
            // labelPatronsInventory
            // 
            labelPatronsInventory.AutoSize = true;
            labelPatronsInventory.Location = new Point(27, 51);
            labelPatronsInventory.Margin = new Padding(4, 0, 4, 0);
            labelPatronsInventory.Name = "labelPatronsInventory";
            labelPatronsInventory.Size = new Size(79, 25);
            labelPatronsInventory.TabIndex = 0;
            labelPatronsInventory.Text = "Patrons";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(116, 47);
            textBoxSearch.Margin = new Padding(4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(663, 30);
            textBoxSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1321, 39);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(177, 46);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(35, 51);
            labelSearch.Margin = new Padding(4, 0, 4, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(75, 25);
            labelSearch.TabIndex = 9;
            labelSearch.Text = "Search";
            // 
            // comboBoxFilterAttribute
            // 
            comboBoxFilterAttribute.FormattingEnabled = true;
            comboBoxFilterAttribute.Location = new Point(1065, 44);
            comboBoxFilterAttribute.Margin = new Padding(4);
            comboBoxFilterAttribute.Name = "comboBoxFilterAttribute";
            comboBoxFilterAttribute.Size = new Size(215, 33);
            comboBoxFilterAttribute.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxFilterType);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(comboBoxFilterAttribute);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Controls.Add(labelSearch);
            groupBox1.Location = new Point(19, 208);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1538, 118);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // comboBoxFilterType
            // 
            comboBoxFilterType.FormattingEnabled = true;
            comboBoxFilterType.Items.AddRange(new object[] { "Users", "Books" });
            comboBoxFilterType.Location = new Point(819, 44);
            comboBoxFilterType.Margin = new Padding(4);
            comboBoxFilterType.Name = "comboBoxFilterType";
            comboBoxFilterType.Size = new Size(209, 33);
            comboBoxFilterType.TabIndex = 11;
            comboBoxFilterType.SelectedIndexChanged += comboBoxFilterType_SelectedIndexChanged;
            // 
            // dataGridViewPatrons
            // 
            dataGridViewPatrons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPatrons.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPatrons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPatrons.Dock = DockStyle.Fill;
            dataGridViewPatrons.Location = new Point(4, 27);
            dataGridViewPatrons.Margin = new Padding(4);
            dataGridViewPatrons.Name = "dataGridViewPatrons";
            dataGridViewPatrons.RowHeadersWidth = 51;
            dataGridViewPatrons.RowTemplate.Height = 24;
            dataGridViewPatrons.Size = new Size(1522, 173);
            dataGridViewPatrons.TabIndex = 12;
            dataGridViewPatrons.SelectionChanged += dataGridViewPatrons_SelectionChanged;
            // 
            // groupBoxPatrons
            // 
            groupBoxPatrons.Controls.Add(dataGridViewPatrons);
            groupBoxPatrons.Location = new Point(25, 675);
            groupBoxPatrons.Margin = new Padding(4);
            groupBoxPatrons.Name = "groupBoxPatrons";
            groupBoxPatrons.Padding = new Padding(4);
            groupBoxPatrons.Size = new Size(1530, 204);
            groupBoxPatrons.TabIndex = 13;
            groupBoxPatrons.TabStop = false;
            groupBoxPatrons.Text = "Patrons";
            // 
            // groupBoxBooks
            // 
            groupBoxBooks.Controls.Add(dataGridViewBooks);
            groupBoxBooks.Location = new Point(21, 348);
            groupBoxBooks.Margin = new Padding(4);
            groupBoxBooks.Name = "groupBoxBooks";
            groupBoxBooks.Padding = new Padding(4);
            groupBoxBooks.Size = new Size(1538, 305);
            groupBoxBooks.TabIndex = 14;
            groupBoxBooks.TabStop = false;
            groupBoxBooks.Text = "Books Catalog";
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Dock = DockStyle.Fill;
            dataGridViewBooks.Location = new Point(4, 27);
            dataGridViewBooks.Margin = new Padding(4);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.RowTemplate.Height = 24;
            dataGridViewBooks.Size = new Size(1530, 274);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.SelectionChanged += dataGridViewBooks_SelectionChanged;
            // 
            // AdminDashboard
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 903);
            Controls.Add(groupBoxBooks);
            Controls.Add(groupBoxPatrons);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxInventoryStats);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxInventoryStats.ResumeLayout(false);
            groupBoxInventoryStats.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatrons).EndInit();
            groupBoxPatrons.ResumeLayout(false);
            groupBoxBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem addPatronsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPatronsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePatronsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatronsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ComboBox comboBoxFilterAttribute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxFilterType;
        private System.Windows.Forms.DataGridView dataGridViewPatrons;
        private System.Windows.Forms.GroupBox groupBoxPatrons;
        private System.Windows.Forms.GroupBox groupBoxBooks;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}