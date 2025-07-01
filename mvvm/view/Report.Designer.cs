namespace LibraryManagement.mvvm.view
{
    partial class Report
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
            label1 = new Label();
            reportViewModelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)reportViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.DataBindings.Add(new Binding("Text", reportViewModelBindingSource, "MyProperty", true));
            label1.Location = new Point(264, 186);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 0;
            label1.Text = "Report";
            // 
            // reportViewModelBindingSource
            // 
            reportViewModelBindingSource.DataSource = typeof(viewModel.ReportViewModel);
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Font = new Font("Gadugi", 12F);
            Margin = new Padding(4);
            Name = "Report";
            Size = new Size(876, 396);
            ((System.ComponentModel.ISupportInitialize)reportViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private BindingSource reportViewModelBindingSource;
    }
}
