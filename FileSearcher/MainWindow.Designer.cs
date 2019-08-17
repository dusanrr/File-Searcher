namespace FileSearcher
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchDirTextBox = new System.Windows.Forms.TextBox();
            this.selectSearchDirButton = new System.Windows.Forms.Button();
            this.containingTextBox = new System.Windows.Forms.TextBox();
            this.resultsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openContainingFolderContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextBox.Location = new System.Drawing.Point(172, 80);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(213, 20);
            this.fileNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Extensions or full filename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search directory:";
            // 
            // searchDirTextBox
            // 
            this.searchDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDirTextBox.Location = new System.Drawing.Point(99, 35);
            this.searchDirTextBox.Name = "searchDirTextBox";
            this.searchDirTextBox.Size = new System.Drawing.Size(345, 20);
            this.searchDirTextBox.TabIndex = 1;
            // 
            // selectSearchDirButton
            // 
            this.selectSearchDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectSearchDirButton.Location = new System.Drawing.Point(450, 34);
            this.selectSearchDirButton.Name = "selectSearchDirButton";
            this.selectSearchDirButton.Size = new System.Drawing.Size(24, 21);
            this.selectSearchDirButton.TabIndex = 2;
            this.selectSearchDirButton.Text = "...";
            this.selectSearchDirButton.UseVisualStyleBackColor = true;
            this.selectSearchDirButton.Click += new System.EventHandler(this.selectSearchDirButton_Click);
            // 
            // containingTextBox
            // 
            this.containingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containingTextBox.Location = new System.Drawing.Point(172, 126);
            this.containingTextBox.Name = "containingTextBox";
            this.containingTextBox.Size = new System.Drawing.Size(213, 20);
            this.containingTextBox.TabIndex = 5;
            // 
            // resultsList
            // 
            this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.resultsList.ContextMenuStrip = this.contextMenuStrip;
            this.resultsList.FullRowSelect = true;
            this.resultsList.Location = new System.Drawing.Point(12, 216);
            this.resultsList.MultiSelect = false;
            this.resultsList.Name = "resultsList";
            this.resultsList.ShowItemToolTips = true;
            this.resultsList.Size = new System.Drawing.Size(477, 220);
            this.resultsList.TabIndex = 0;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            this.resultsList.View = System.Windows.Forms.View.Details;
            this.resultsList.DoubleClick += new System.EventHandler(this.resultsList_DoubleClick);
            this.resultsList.Resize += new System.EventHandler(this.resultsList_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File path";
            this.columnHeader1.Width = 351;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Repetition of string";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 121;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openContainingFolderContextMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(198, 26);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // openContainingFolderContextMenuItem
            // 
            this.openContainingFolderContextMenuItem.Name = "openContainingFolderContextMenuItem";
            this.openContainingFolderContextMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openContainingFolderContextMenuItem.Text = "Open containing folder";
            this.openContainingFolderContextMenuItem.Click += new System.EventHandler(this.openContainingFolderContextMenuItem_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(235, 152);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Files containing the string";
            // 
            // MainWindow
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 586);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.containingTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.selectSearchDirButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchDirTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(519, 625);
            this.MinimumSize = new System.Drawing.Size(519, 625);
            this.Name = "MainWindow";
            this.Text = "File Searcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchDirTextBox;
        private System.Windows.Forms.Button selectSearchDirButton;
        private System.Windows.Forms.TextBox containingTextBox;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openContainingFolderContextMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

