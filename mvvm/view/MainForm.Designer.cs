namespace LibraryManagement.View
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
            tabControl = new TabControl();
            Borrow = new TabPage();
            AddRemove = new TabPage();
            addRemovePage = new AddRemove();
            Report = new TabPage();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            borrowPage = new LibraryManagement.mvvm.view.Borrow();
            reportPage = new LibraryManagement.mvvm.view.Report();
            tabControl.SuspendLayout();
            Borrow.SuspendLayout();
            AddRemove.SuspendLayout();
            Report.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(Borrow);
            tabControl.Controls.Add(AddRemove);
            tabControl.Controls.Add(Report);
            tabControl.Location = new Point(0, 33);
            tabControl.Margin = new Padding(5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(884, 428);
            tabControl.TabIndex = 0;
            // 
            // Borrow
            // 
            Borrow.Controls.Add(borrowPage);
            Borrow.Location = new Point(4, 28);
            Borrow.Margin = new Padding(5);
            Borrow.Name = "Borrow";
            Borrow.Padding = new Padding(5);
            Borrow.Size = new Size(876, 396);
            Borrow.TabIndex = 0;
            Borrow.Text = "Borrow";
            Borrow.UseVisualStyleBackColor = true;
            // 
            // AddRemove
            // 
            AddRemove.Controls.Add(addRemovePage);
            AddRemove.Location = new Point(4, 28);
            AddRemove.Margin = new Padding(5);
            AddRemove.Name = "AddRemove";
            AddRemove.Padding = new Padding(5);
            AddRemove.Size = new Size(876, 396);
            AddRemove.TabIndex = 1;
            AddRemove.Text = "Add/Remove";
            AddRemove.UseVisualStyleBackColor = true;
            // 
            // addRemovePage
            // 
            addRemovePage.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addRemovePage.Location = new Point(0, 0);
            addRemovePage.Margin = new Padding(4);
            addRemovePage.Name = "addRemovePage";
            addRemovePage.Size = new Size(876, 396);
            addRemovePage.TabIndex = 0;
            // 
            // Report
            // 
            Report.Controls.Add(reportPage);
            Report.Location = new Point(4, 28);
            Report.Margin = new Padding(5);
            Report.Name = "Report";
            Report.Size = new Size(876, 396);
            Report.TabIndex = 2;
            Report.Text = "Report";
            Report.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // borrowPage
            // 
            borrowPage.Font = new Font("Gadugi", 12F);
            borrowPage.Location = new Point(0, 0);
            borrowPage.Margin = new Padding(4);
            borrowPage.Name = "borrowPage";
            borrowPage.Size = new Size(876, 396);
            borrowPage.TabIndex = 0;
            // 
            // reportPage
            // 
            reportPage.Font = new Font("Gadugi", 12F);
            reportPage.Location = new Point(0, 0);
            reportPage.Margin = new Padding(4);
            reportPage.Name = "reportPage";
            reportPage.Size = new Size(876, 396);
            reportPage.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(tabControl);
            Controls.Add(menuStrip1);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Library Management System";
            tabControl.ResumeLayout(false);
            Borrow.ResumeLayout(false);
            AddRemove.ResumeLayout(false);
            Report.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage Borrow;
        private TabPage AddRemove;
        private TabPage Report;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private AddRemove addRemovePage;
        private mvvm.view.Borrow borrowPage;
        private mvvm.view.Report reportPage;
    }
}