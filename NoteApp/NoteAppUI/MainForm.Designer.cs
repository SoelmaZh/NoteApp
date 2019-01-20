namespace NoteAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyAddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyRemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyEditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ShowCategory = new System.Windows.Forms.Label();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.DateOfLastEditTextBox = new System.Windows.Forms.DateTimePicker();
            this.DateOfCreationTextBox = new System.Windows.Forms.DateTimePicker();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.Modified = new System.Windows.Forms.Label();
            this.Created = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MyExitToolStripMenuItem
            // 
            this.MyExitToolStripMenuItem.Name = "MyExitToolStripMenuItem";
            this.MyExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.MyExitToolStripMenuItem.Text = "Exit";
            this.MyExitToolStripMenuItem.Click += new System.EventHandler(this.MyExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyAddNoteToolStripMenuItem,
            this.MyRemoveNoteToolStripMenuItem,
            this.MyEditNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // MyAddNoteToolStripMenuItem
            // 
            this.MyAddNoteToolStripMenuItem.Name = "MyAddNoteToolStripMenuItem";
            this.MyAddNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.MyAddNoteToolStripMenuItem.Text = "Add Note";
            this.MyAddNoteToolStripMenuItem.Click += new System.EventHandler(this.MyAddNoteToolStripMenuItem_Click);
            // 
            // MyRemoveNoteToolStripMenuItem
            // 
            this.MyRemoveNoteToolStripMenuItem.Name = "MyRemoveNoteToolStripMenuItem";
            this.MyRemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.MyRemoveNoteToolStripMenuItem.Text = "Remove Note";
            this.MyRemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.MyRemoveNoteToolStripMenuItem_Click);
            // 
            // MyEditNoteToolStripMenuItem
            // 
            this.MyEditNoteToolStripMenuItem.Name = "MyEditNoteToolStripMenuItem";
            this.MyEditNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.MyEditNoteToolStripMenuItem.Text = "Edit Note";
            this.MyEditNoteToolStripMenuItem.Click += new System.EventHandler(this.MyEditNoteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MyAboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MyAboutToolStripMenuItem
            // 
            this.MyAboutToolStripMenuItem.Name = "MyAboutToolStripMenuItem";
            this.MyAboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.MyAboutToolStripMenuItem.Text = "About";
            this.MyAboutToolStripMenuItem.Click += new System.EventHandler(this.MyAboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EditNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.NotesListBox);
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategory);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ContentTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.NoteNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.DateOfLastEditTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.DateOfCreationTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.Modified);
            this.splitContainer1.Panel2.Controls.Add(this.Created);
            this.splitContainer1.Size = new System.Drawing.Size(573, 395);
            this.splitContainer1.SplitterDistance = 189;
            this.splitContainer1.TabIndex = 1;
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.Image")));
            this.EditNoteButton.Location = new System.Drawing.Point(75, 362);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(30, 30);
            this.EditNoteButton.TabIndex = 5;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveNoteButton.Image")));
            this.RemoveNoteButton.Location = new System.Drawing.Point(39, 362);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(30, 30);
            this.RemoveNoteButton.TabIndex = 4;
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.Image")));
            this.AddNoteButton.Location = new System.Drawing.Point(3, 362);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(30, 30);
            this.AddNoteButton.TabIndex = 3;
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.Location = new System.Drawing.Point(6, 30);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(180, 329);
            this.NotesListBox.TabIndex = 2;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(85, 3);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(71, 21);
            this.CategoryComboBox.TabIndex = 1;
            // 
            // ShowCategory
            // 
            this.ShowCategory.AutoSize = true;
            this.ShowCategory.Location = new System.Drawing.Point(3, 3);
            this.ShowCategory.Name = "ShowCategory";
            this.ShowCategory.Size = new System.Drawing.Size(79, 13);
            this.ShowCategory.TabIndex = 0;
            this.ShowCategory.Text = "Show Category";
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Location = new System.Drawing.Point(3, 6);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(33, 13);
            this.NoteNameLabel.TabIndex = 7;
            this.NoteNameLabel.Text = "Note:";
            // 
            // DateOfLastEditTextBox
            // 
            this.DateOfLastEditTextBox.Location = new System.Drawing.Point(53, 44);
            this.DateOfLastEditTextBox.Name = "DateOfLastEditTextBox";
            this.DateOfLastEditTextBox.Size = new System.Drawing.Size(120, 20);
            this.DateOfLastEditTextBox.TabIndex = 5;
            // 
            // DateOfCreationTextBox
            // 
            this.DateOfCreationTextBox.Location = new System.Drawing.Point(53, 20);
            this.DateOfCreationTextBox.Name = "DateOfCreationTextBox";
            this.DateOfCreationTextBox.Size = new System.Drawing.Size(118, 20);
            this.DateOfCreationTextBox.TabIndex = 4;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(61, 6);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Category";
            // 
            // Modified
            // 
            this.Modified.AutoSize = true;
            this.Modified.Location = new System.Drawing.Point(0, 44);
            this.Modified.Name = "Modified";
            this.Modified.Size = new System.Drawing.Size(47, 13);
            this.Modified.TabIndex = 2;
            this.Modified.Text = "Modified";
            // 
            // Created
            // 
            this.Created.AutoSize = true;
            this.Created.Location = new System.Drawing.Point(3, 26);
            this.Created.Name = "Created";
            this.Created.Size = new System.Drawing.Size(44, 13);
            this.Created.TabIndex = 1;
            this.Created.Text = "Created";
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentTextBox.Location = new System.Drawing.Point(6, 72);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(371, 320);
            this.ContentTextBox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 419);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyAddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyRemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyEditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MyAboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label ShowCategory;
        private System.Windows.Forms.DateTimePicker DateOfLastEditTextBox;
        private System.Windows.Forms.DateTimePicker DateOfCreationTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label Modified;
        private System.Windows.Forms.Label Created;
        private System.Windows.Forms.Label NoteNameLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox ContentTextBox;
    }
}