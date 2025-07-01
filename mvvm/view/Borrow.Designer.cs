using LibraryManagement.Data;
using LibraryManagement.mvvm.view.components;
using System.Drawing.Text;

namespace LibraryManagement.mvvm.view
{
    partial class Borrow
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
            components = new System.ComponentModel.Container();
            reportViewModelBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button(); 
            splitContainer1 = new SplitContainer();
            button2 = new Button();

            LibraryDb libraryDb = new LibraryDb();
            searchBar1 = new SearchBar(libraryDb.CustomerSearch);
            ((System.ComponentModel.ISupportInitialize)reportViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewModelBindingSource
            // 
            reportViewModelBindingSource.DataSource = typeof(viewModel.ReportViewModel);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 86);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "Select Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 33);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 0;
            label2.Text = "Borrow";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 33);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 0;
            label3.Text = "Return";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 135);
            label4.Name = "label4";
            label4.Size = new Size(98, 19);
            label4.TabIndex = 0;
            label4.Text = "Borrowed by";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 89);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 4;
            label5.Text = "Customer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 170);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 4;
            label6.Text = "Book";
            // 
            // button1
            // 
            button1.Location = new Point(190, 318);
            button1.Name = "button1";
            button1.Size = new Size(113, 37);
            button1.TabIndex = 6;
            button1.Text = "Borrow";
            button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(searchBar1);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Size = new Size(876, 396);
            splitContainer1.SplitterDistance = 413;
            splitContainer1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(275, 318);
            button2.Name = "button2";
            button2.Size = new Size(113, 37);
            button2.TabIndex = 6;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            // 
            // searchBar1
            // 
            searchBar1.Location = new Point(166, 89);
            searchBar1.Name = "searchBar1";
            searchBar1.Size = new Size(200, 278);
            searchBar1.TabIndex = 7;
            // 
            // Borrow
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Font = new Font("Gadugi", 12F);
            Margin = new Padding(4);
            Name = "Borrow";
            Size = new Size(876, 396);
            ((System.ComponentModel.ISupportInitialize)reportViewModelBindingSource).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource reportViewModelBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private SplitContainer splitContainer1;
        private Button button2;
        private components.SearchBar customerSearchBar;
        private components.SearchBar searchBar1;
    }
}
