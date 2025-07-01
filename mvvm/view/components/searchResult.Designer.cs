namespace LibraryManagement.mvvm.view.components
{
    partial class SearchResult
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title = new Label();
            subtitle = new Label();
            note = new Label();
            pictureBox = new PictureBox();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(57, 4);
            title.Margin = new Padding(4);
            title.Name = "title";
            title.Size = new Size(36, 17);
            title.TabIndex = 0;
            title.Text = "Title";
            // 
            // subtitle
            // 
            subtitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            subtitle.AutoSize = true;
            subtitle.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subtitle.Location = new Point(57, 30);
            subtitle.Margin = new Padding(4);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(47, 14);
            subtitle.TabIndex = 0;
            subtitle.Text = "Subtitle";
            // 
            // note
            // 
            note.AutoEllipsis = true;
            note.AutoSize = true;
            note.Dock = DockStyle.Right;
            note.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            note.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            note.Location = new Point(158, 0);
            note.Margin = new Padding(0);
            note.Name = "note";
            note.Padding = new Padding(0, 8, 8, 0);
            note.RightToLeft = RightToLeft.No;
            note.Size = new Size(40, 22);
            note.TabIndex = 0;
            note.Text = "Note";
            note.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(50, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(255, 224, 192);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(note);
            panel.Controls.Add(subtitle);
            panel.Controls.Add(title);
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(0);
            panel.Name = "panel";
            panel.Size = new Size(200, 50);
            panel.TabIndex = 2;
            // 
            // SearchResult
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Font = new Font("Gadugi", 12F);
            Margin = new Padding(0);
            Name = "SearchResult";
            Size = new Size(200, 50);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private Label subtitle;
        private Label note;
        private PictureBox pictureBox;
        private Panel panel;
    }
}
