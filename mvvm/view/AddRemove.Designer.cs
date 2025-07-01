namespace LibraryManagement.View
{
    partial class AddRemove
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
            backButton = new Button();
            optionPanel = new Panel();
            authorPanel = new Panel();
            authorDOBDatePicker = new DateTimePicker();
            addRemoveViewModelBindingSource = new BindingSource(components);
            authorLastNameLabel = new Label();
            authorLastNameText = new TextBox();
            authorFirstNameLabel = new Label();
            authorFirstNameText = new TextBox();
            authorDOBLabel = new Label();
            authorDelete = new Button();
            authorInsert = new Button();
            label3 = new Label();
            customerPanel = new Panel();
            customer = new Label();
            customerLastNameLabel = new Label();
            customerLastNameText = new TextBox();
            customerFirstNameLabel = new Label();
            customerFirstNameText = new TextBox();
            customerPhoneNumberLabel = new Label();
            customerPhoneNumberText = new TextBox();
            customerAddressLabel = new Label();
            customerAddressText = new TextBox();
            customerEmailLabel = new Label();
            customerEmailText = new TextBox();
            customerImageLabel = new Label();
            customerImagePath = new TextBox();
            customerPicture = new PictureBox();
            customerDeleteButton = new Button();
            customerInsertButton = new Button();
            bookPanel = new Panel();
            Book = new Label();
            titleLabel = new Label();
            titleText = new TextBox();
            genreLabel = new Label();
            genreText = new TextBox();
            yearLabel = new Label();
            yearText = new TextBox();
            imageLabel = new Label();
            bookImagePath = new TextBox();
            bookPicture = new PictureBox();
            bookDeleteButton = new Button();
            bookInsertButton = new Button();
            customerButton = new Button();
            bookButton = new Button();
            authorButton = new Button();
            openFileDialog = new OpenFileDialog();
            optionPanel.SuspendLayout();
            authorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addRemoveViewModelBindingSource).BeginInit();
            customerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerPicture).BeginInit();
            bookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookPicture).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.FlatAppearance.BorderColor = Color.Red;
            backButton.FlatAppearance.BorderSize = 2;
            backButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(17, 15);
            backButton.Margin = new Padding(17, 15, 17, 15);
            backButton.Name = "backButton";
            backButton.Size = new Size(82, 46);
            backButton.TabIndex = 2;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Visible = false;
            backButton.Click += backButton_Click;
            // 
            // optionPanel
            // 
            optionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            optionPanel.Controls.Add(customerPanel);
            optionPanel.Controls.Add(authorPanel);
            optionPanel.Controls.Add(bookPanel);
            optionPanel.Controls.Add(customerButton);
            optionPanel.Controls.Add(bookButton);
            optionPanel.Controls.Add(authorButton);
            optionPanel.Location = new Point(0, 0);
            optionPanel.Margin = new Padding(5);
            optionPanel.Name = "optionPanel";
            optionPanel.Size = new Size(876, 396);
            optionPanel.TabIndex = 4;
            // 
            // authorPanel
            // 
            authorPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            authorPanel.Controls.Add(authorDOBDatePicker);
            authorPanel.Controls.Add(authorLastNameLabel);
            authorPanel.Controls.Add(authorLastNameText);
            authorPanel.Controls.Add(authorFirstNameLabel);
            authorPanel.Controls.Add(authorFirstNameText);
            authorPanel.Controls.Add(authorDOBLabel);
            authorPanel.Controls.Add(authorDelete);
            authorPanel.Controls.Add(authorInsert);
            authorPanel.Controls.Add(label3);
            authorPanel.Location = new Point(0, 0);
            authorPanel.Margin = new Padding(5);
            authorPanel.Name = "authorPanel";
            authorPanel.Size = new Size(876, 396);
            authorPanel.TabIndex = 4;
            authorPanel.Visible = false;
            // 
            // authorDOBDatePicker
            // 
            authorDOBDatePicker.DataBindings.Add(new Binding("Value", addRemoveViewModelBindingSource, "AuthorDOB", true, DataSourceUpdateMode.OnPropertyChanged));
            authorDOBDatePicker.Location = new Point(164, 213);
            authorDOBDatePicker.Name = "authorDOBDatePicker";
            authorDOBDatePicker.Size = new Size(257, 29);
            authorDOBDatePicker.TabIndex = 30;
            authorDOBDatePicker.Value = new DateTime(2025, 6, 30, 11, 32, 24, 0);
            // 
            // addRemoveViewModelBindingSource
            // 
            addRemoveViewModelBindingSource.DataSource = typeof(mvvm.viewModel.AddRemoveViewModel);
            // 
            // authorLastNameLabel
            // 
            authorLastNameLabel.AutoSize = true;
            authorLastNameLabel.Location = new Point(54, 123);
            authorLastNameLabel.Margin = new Padding(5, 0, 5, 0);
            authorLastNameLabel.Name = "authorLastNameLabel";
            authorLastNameLabel.Size = new Size(86, 19);
            authorLastNameLabel.TabIndex = 17;
            authorLastNameLabel.Text = "Last Name:";
            // 
            // authorLastNameText
            // 
            authorLastNameText.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "AuthorLastName", true, DataSourceUpdateMode.OnPropertyChanged));
            authorLastNameText.Location = new Point(150, 120);
            authorLastNameText.Margin = new Padding(5);
            authorLastNameText.Name = "authorLastNameText";
            authorLastNameText.Size = new Size(271, 29);
            authorLastNameText.TabIndex = 15;
            // 
            // authorFirstNameLabel
            // 
            authorFirstNameLabel.AutoSize = true;
            authorFirstNameLabel.Location = new Point(460, 123);
            authorFirstNameLabel.Margin = new Padding(5, 0, 5, 0);
            authorFirstNameLabel.Name = "authorFirstNameLabel";
            authorFirstNameLabel.Size = new Size(88, 19);
            authorFirstNameLabel.TabIndex = 16;
            authorFirstNameLabel.Text = "First Name:";
            // 
            // authorFirstNameText
            // 
            authorFirstNameText.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "AuthorFirstName", true, DataSourceUpdateMode.OnPropertyChanged));
            authorFirstNameText.Location = new Point(558, 120);
            authorFirstNameText.Margin = new Padding(5);
            authorFirstNameText.Name = "authorFirstNameText";
            authorFirstNameText.Size = new Size(247, 29);
            authorFirstNameText.TabIndex = 13;
            // 
            // authorDOBLabel
            // 
            authorDOBLabel.AutoSize = true;
            authorDOBLabel.Location = new Point(54, 220);
            authorDOBLabel.Margin = new Padding(5, 0, 5, 0);
            authorDOBLabel.Name = "authorDOBLabel";
            authorDOBLabel.Size = new Size(102, 19);
            authorDOBLabel.TabIndex = 18;
            authorDOBLabel.Text = "Date Of Birth:";
            // 
            // authorDelete
            // 
            authorDelete.AutoEllipsis = true;
            authorDelete.BackColor = Color.FromArgb(255, 192, 192);
            authorDelete.FlatStyle = FlatStyle.Flat;
            authorDelete.ForeColor = Color.Red;
            authorDelete.Location = new Point(472, 337);
            authorDelete.Margin = new Padding(4);
            authorDelete.Name = "authorDelete";
            authorDelete.Size = new Size(141, 37);
            authorDelete.TabIndex = 29;
            authorDelete.Text = "Delete";
            authorDelete.UseVisualStyleBackColor = false;
            authorDelete.Click += authorDelete_Click;
            // 
            // authorInsert
            // 
            authorInsert.AutoEllipsis = true;
            authorInsert.BackColor = Color.FromArgb(192, 255, 192);
            authorInsert.FlatStyle = FlatStyle.Flat;
            authorInsert.ForeColor = Color.FromArgb(0, 192, 0);
            authorInsert.Location = new Point(688, 337);
            authorInsert.Margin = new Padding(4);
            authorInsert.Name = "authorInsert";
            authorInsert.Size = new Size(141, 37);
            authorInsert.TabIndex = 28;
            authorInsert.Text = "Insert";
            authorInsert.UseVisualStyleBackColor = false;
            authorInsert.Click += authorInsert_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(121, 29);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 32);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // customerPanel
            // 
            customerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerPanel.Controls.Add(customer);
            customerPanel.Controls.Add(customerLastNameLabel);
            customerPanel.Controls.Add(customerLastNameText);
            customerPanel.Controls.Add(customerFirstNameLabel);
            customerPanel.Controls.Add(customerFirstNameText);
            customerPanel.Controls.Add(customerPhoneNumberLabel);
            customerPanel.Controls.Add(customerPhoneNumberText);
            customerPanel.Controls.Add(customerAddressLabel);
            customerPanel.Controls.Add(customerAddressText);
            customerPanel.Controls.Add(customerEmailLabel);
            customerPanel.Controls.Add(customerEmailText);
            customerPanel.Controls.Add(customerImageLabel);
            customerPanel.Controls.Add(customerImagePath);
            customerPanel.Controls.Add(customerPicture);
            customerPanel.Controls.Add(customerDeleteButton);
            customerPanel.Controls.Add(customerInsertButton);
            customerPanel.Location = new Point(0, 0);
            customerPanel.Margin = new Padding(5);
            customerPanel.Name = "customerPanel";
            customerPanel.Size = new Size(876, 396);
            customerPanel.TabIndex = 3;
            customerPanel.Visible = false;
            // 
            // customer
            // 
            customer.AutoSize = true;
            customer.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer.Location = new Point(121, 29);
            customer.Margin = new Padding(5, 0, 5, 0);
            customer.Name = "customer";
            customer.Size = new Size(138, 32);
            customer.TabIndex = 0;
            customer.Text = "Customer";
            // 
            // customerLastNameLabel
            // 
            customerLastNameLabel.AutoSize = true;
            customerLastNameLabel.Location = new Point(54, 115);
            customerLastNameLabel.Margin = new Padding(5, 0, 5, 0);
            customerLastNameLabel.Name = "customerLastNameLabel";
            customerLastNameLabel.Size = new Size(90, 19);
            customerLastNameLabel.TabIndex = 1;
            customerLastNameLabel.Text = " Last Name:";
            // 
            // customerLastNameText
            // 
            customerLastNameText.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "CustomerLastName", true));
            customerLastNameText.Location = new Point(154, 112);
            customerLastNameText.Margin = new Padding(5);
            customerLastNameText.Name = "customerLastNameText";
            customerLastNameText.Size = new Size(267, 29);
            customerLastNameText.TabIndex = 2;
            // 
            // customerFirstNameLabel
            // 
            customerFirstNameLabel.AutoSize = true;
            customerFirstNameLabel.Location = new Point(472, 115);
            customerFirstNameLabel.Margin = new Padding(5, 0, 5, 0);
            customerFirstNameLabel.Name = "customerFirstNameLabel";
            customerFirstNameLabel.Size = new Size(88, 19);
            customerFirstNameLabel.TabIndex = 3;
            customerFirstNameLabel.Text = "First Name:";
            // 
            // customerFirstNameText
            // 
            customerFirstNameText.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "CustomerFirstName", true));
            customerFirstNameText.Location = new Point(570, 112);
            customerFirstNameText.Margin = new Padding(5);
            customerFirstNameText.Name = "customerFirstNameText";
            customerFirstNameText.Size = new Size(269, 29);
            customerFirstNameText.TabIndex = 4;
            // 
            // customerPhoneNumberLabel
            // 
            customerPhoneNumberLabel.AutoSize = true;
            customerPhoneNumberLabel.Location = new Point(54, 162);
            customerPhoneNumberLabel.Margin = new Padding(5, 0, 5, 0);
            customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            customerPhoneNumberLabel.Size = new Size(118, 19);
            customerPhoneNumberLabel.TabIndex = 5;
            customerPhoneNumberLabel.Text = "Phone Number:";
            // 
            // customerPhoneNumberText
            // 
            customerPhoneNumberText.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "CustomerPhoneNumber", true));
            customerPhoneNumberText.Location = new Point(182, 159);
            customerPhoneNumberText.Margin = new Padding(5);
            customerPhoneNumberText.Name = "customerPhoneNumberText";
            customerPhoneNumberText.Size = new Size(239, 29);
            customerPhoneNumberText.TabIndex = 6;
            // 
            // customerAddressLabel
            // 
            customerAddressLabel.AutoSize = true;
            customerAddressLabel.Location = new Point(472, 162);
            customerAddressLabel.Margin = new Padding(5, 0, 5, 0);
            customerAddressLabel.Name = "customerAddressLabel";
            customerAddressLabel.Size = new Size(68, 19);
            customerAddressLabel.TabIndex = 7;
            customerAddressLabel.Text = "Address:";
            // 
            // customerAddressText
            // 
            customerAddressText.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "CustomerAddress", true));
            customerAddressText.Location = new Point(550, 159);
            customerAddressText.Margin = new Padding(5);
            customerAddressText.Name = "customerAddressText";
            customerAddressText.Size = new Size(289, 29);
            customerAddressText.TabIndex = 8;
            // 
            // customerEmailLabel
            // 
            customerEmailLabel.AutoSize = true;
            customerEmailLabel.Location = new Point(54, 217);
            customerEmailLabel.Margin = new Padding(5, 0, 5, 0);
            customerEmailLabel.Name = "customerEmailLabel";
            customerEmailLabel.Size = new Size(110, 19);
            customerEmailLabel.TabIndex = 9;
            customerEmailLabel.Text = "Email Address:";
            // 
            // customerEmailText
            // 
            customerEmailText.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "CustomerEmail", true));
            customerEmailText.Location = new Point(174, 214);
            customerEmailText.Margin = new Padding(5);
            customerEmailText.Name = "customerEmailText";
            customerEmailText.Size = new Size(247, 29);
            customerEmailText.TabIndex = 10;
            // 
            // customerImageLabel
            // 
            customerImageLabel.AutoSize = true;
            customerImageLabel.Location = new Point(54, 319);
            customerImageLabel.Margin = new Padding(5, 0, 5, 0);
            customerImageLabel.Name = "customerImageLabel";
            customerImageLabel.Size = new Size(55, 19);
            customerImageLabel.TabIndex = 11;
            customerImageLabel.Text = "Image:";
            // 
            // customerImagePath
            // 
            customerImagePath.BackColor = Color.FromArgb(224, 224, 224);
            customerImagePath.BorderStyle = BorderStyle.FixedSingle;
            customerImagePath.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "CustomerImage", true));
            customerImagePath.Location = new Point(119, 317);
            customerImagePath.Margin = new Padding(5);
            customerImagePath.Name = "customerImagePath";
            customerImagePath.ReadOnly = true;
            customerImagePath.Size = new Size(302, 29);
            customerImagePath.TabIndex = 12;
            customerImagePath.Click += ImagePath_Click;
            customerImagePath.TextChanged += customerImagePath_TextChanged;
            // 
            // customerPicture
            // 
            customerPicture.BorderStyle = BorderStyle.FixedSingle;
            customerPicture.Location = new Point(550, 197);
            customerPicture.Margin = new Padding(4);
            customerPicture.Name = "customerPicture";
            customerPicture.Size = new Size(142, 177);
            customerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            customerPicture.TabIndex = 13;
            customerPicture.TabStop = false;
            // 
            // customerDeleteButton
            // 
            customerDeleteButton.AutoEllipsis = true;
            customerDeleteButton.BackColor = Color.FromArgb(255, 192, 192);
            customerDeleteButton.FlatStyle = FlatStyle.Flat;
            customerDeleteButton.ForeColor = Color.Red;
            customerDeleteButton.Location = new Point(720, 275);
            customerDeleteButton.Margin = new Padding(4);
            customerDeleteButton.Name = "customerDeleteButton";
            customerDeleteButton.Size = new Size(119, 37);
            customerDeleteButton.TabIndex = 15;
            customerDeleteButton.Text = "Delete";
            customerDeleteButton.UseVisualStyleBackColor = false;
            customerDeleteButton.Click += customerDeleteButton_Click;
            // 
            // customerInsertButton
            // 
            customerInsertButton.AutoEllipsis = true;
            customerInsertButton.BackColor = Color.FromArgb(192, 255, 192);
            customerInsertButton.FlatStyle = FlatStyle.Flat;
            customerInsertButton.ForeColor = Color.FromArgb(0, 192, 0);
            customerInsertButton.Location = new Point(720, 337);
            customerInsertButton.Margin = new Padding(4);
            customerInsertButton.Name = "customerInsertButton";
            customerInsertButton.Size = new Size(119, 37);
            customerInsertButton.TabIndex = 14;
            customerInsertButton.Text = "Insert";
            customerInsertButton.UseVisualStyleBackColor = false;
            customerInsertButton.Click += customerInsertButton_Click;
            // 
            // bookPanel
            // 
            bookPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bookPanel.Controls.Add(Book);
            bookPanel.Controls.Add(titleLabel);
            bookPanel.Controls.Add(titleText);
            bookPanel.Controls.Add(genreLabel);
            bookPanel.Controls.Add(genreText);
            bookPanel.Controls.Add(yearLabel);
            bookPanel.Controls.Add(yearText);
            bookPanel.Controls.Add(imageLabel);
            bookPanel.Controls.Add(bookImagePath);
            bookPanel.Controls.Add(bookPicture);
            bookPanel.Controls.Add(bookDeleteButton);
            bookPanel.Controls.Add(bookInsertButton);
            bookPanel.Location = new Point(0, 0);
            bookPanel.Margin = new Padding(5);
            bookPanel.Name = "bookPanel";
            bookPanel.Size = new Size(876, 397);
            bookPanel.TabIndex = 2;
            bookPanel.Visible = false;
            // 
            // Book
            // 
            Book.AutoSize = true;
            Book.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Book.Location = new Point(121, 29);
            Book.Margin = new Padding(5, 0, 5, 0);
            Book.Name = "Book";
            Book.Size = new Size(80, 32);
            Book.TabIndex = 1;
            Book.Text = "Book";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(101, 111);
            titleLabel.Margin = new Padding(5, 0, 5, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(41, 19);
            titleLabel.TabIndex = 19;
            titleLabel.Text = "Title:";
            // 
            // titleText
            // 
            titleText.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "Title", true));
            titleText.Location = new Point(152, 108);
            titleText.Margin = new Padding(5);
            titleText.Name = "titleText";
            titleText.Size = new Size(370, 29);
            titleText.TabIndex = 15;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(101, 172);
            genreLabel.Margin = new Padding(5, 0, 5, 0);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(54, 19);
            genreLabel.TabIndex = 21;
            genreLabel.Text = "Genre:";
            // 
            // genreText
            // 
            genreText.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "Genre", true));
            genreText.Location = new Point(165, 169);
            genreText.Margin = new Padding(5);
            genreText.Name = "genreText";
            genreText.Size = new Size(187, 29);
            genreText.TabIndex = 17;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(378, 172);
            yearLabel.Margin = new Padding(5, 0, 5, 0);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(43, 19);
            yearLabel.TabIndex = 20;
            yearLabel.Text = "Year:";
            // 
            // yearText
            // 
            yearText.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "Year", true));
            yearText.Location = new Point(431, 169);
            yearText.Margin = new Padding(5);
            yearText.Name = "yearText";
            yearText.Size = new Size(91, 29);
            yearText.TabIndex = 16;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new Point(101, 302);
            imageLabel.Margin = new Padding(5, 0, 5, 0);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(55, 19);
            imageLabel.TabIndex = 23;
            imageLabel.Text = "Image:";
            // 
            // bookImagePath
            // 
            bookImagePath.BackColor = Color.FromArgb(224, 224, 224);
            bookImagePath.BorderStyle = BorderStyle.FixedSingle;
            bookImagePath.DataBindings.Add(new Binding("Text", addRemoveViewModelBindingSource, "Image", true));
            bookImagePath.Location = new Point(166, 299);
            bookImagePath.Margin = new Padding(5);
            bookImagePath.Name = "bookImagePath";
            bookImagePath.ReadOnly = true;
            bookImagePath.Size = new Size(356, 29);
            bookImagePath.TabIndex = 24;
            bookImagePath.Click += ImagePath_Click;
            // 
            // bookPicture
            // 
            bookPicture.BorderStyle = BorderStyle.FixedSingle;
            bookPicture.Location = new Point(671, 107);
            bookPicture.Margin = new Padding(4);
            bookPicture.Name = "bookPicture";
            bookPicture.Size = new Size(181, 221);
            bookPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            bookPicture.TabIndex = 14;
            bookPicture.TabStop = false;
            // 
            // bookDeleteButton
            // 
            bookDeleteButton.AutoEllipsis = true;
            bookDeleteButton.BackColor = Color.FromArgb(255, 192, 192);
            bookDeleteButton.FlatStyle = FlatStyle.Flat;
            bookDeleteButton.ForeColor = Color.Red;
            bookDeleteButton.Location = new Point(548, 346);
            bookDeleteButton.Margin = new Padding(4);
            bookDeleteButton.Name = "bookDeleteButton";
            bookDeleteButton.Size = new Size(132, 37);
            bookDeleteButton.TabIndex = 27;
            bookDeleteButton.Text = "Delete";
            bookDeleteButton.UseVisualStyleBackColor = false;
            bookDeleteButton.Click += bookDeleteButton_Click;
            // 
            // bookInsertButton
            // 
            bookInsertButton.AutoEllipsis = true;
            bookInsertButton.BackColor = Color.FromArgb(192, 255, 192);
            bookInsertButton.FlatStyle = FlatStyle.Flat;
            bookInsertButton.ForeColor = Color.FromArgb(0, 192, 0);
            bookInsertButton.Location = new Point(720, 346);
            bookInsertButton.Margin = new Padding(4);
            bookInsertButton.Name = "bookInsertButton";
            bookInsertButton.Size = new Size(132, 37);
            bookInsertButton.TabIndex = 26;
            bookInsertButton.Text = "Insert";
            bookInsertButton.UseVisualStyleBackColor = false;
            bookInsertButton.Click += bookInsertButton_Click;
            // 
            // customerButton
            // 
            customerButton.Anchor = AnchorStyles.None;
            customerButton.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            customerButton.Location = new Point(78, 147);
            customerButton.Margin = new Padding(5);
            customerButton.Name = "customerButton";
            customerButton.Size = new Size(194, 111);
            customerButton.TabIndex = 0;
            customerButton.Text = "Customer";
            customerButton.UseVisualStyleBackColor = true;
            customerButton.Click += customerButton_Click;
            // 
            // bookButton
            // 
            bookButton.Anchor = AnchorStyles.None;
            bookButton.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            bookButton.Location = new Point(312, 131);
            bookButton.Margin = new Padding(5);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(236, 143);
            bookButton.TabIndex = 0;
            bookButton.Text = "Book";
            bookButton.UseVisualStyleBackColor = true;
            bookButton.Click += bookButton_Click;
            // 
            // authorButton
            // 
            authorButton.Anchor = AnchorStyles.None;
            authorButton.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            authorButton.Location = new Point(590, 148);
            authorButton.Margin = new Padding(5);
            authorButton.Name = "authorButton";
            authorButton.Size = new Size(194, 108);
            authorButton.TabIndex = 0;
            authorButton.Text = "Author";
            authorButton.UseVisualStyleBackColor = true;
            authorButton.Click += authorButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            openFileDialog.Title = "Choose Image";
            // 
            // AddRemove
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(backButton);
            Controls.Add(optionPanel);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AddRemove";
            Size = new Size(876, 396);
            optionPanel.ResumeLayout(false);
            authorPanel.ResumeLayout(false);
            authorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addRemoveViewModelBindingSource).EndInit();
            customerPanel.ResumeLayout(false);
            customerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerPicture).EndInit();
            bookPanel.ResumeLayout(false);
            bookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private Panel optionPanel;
        private Panel customerPanel;
        private PictureBox customerPicture;
        private TextBox customerImagePath;
        private Label customerImageLabel;
        private TextBox customerEmailText;
        private Label customerEmailLabel;
        private TextBox customerAddressText;
        private Label customerAddressLabel;
        private TextBox customerPhoneNumberText;
        private Label customerPhoneNumberLabel;
        private TextBox customerFirstNameText;
        private Label customerFirstNameLabel;
        private TextBox customerLastNameText;
        private Label customerLastNameLabel;
        private Label customer;
        private Panel bookPanel;
        private TextBox bookImagePath;
        private Label imageLabel;
        private Label genreLabel;
        private Label yearLabel;
        private Label titleLabel;
        private TextBox genreText;
        private TextBox yearText;
        private TextBox titleText;
        private PictureBox bookPicture;
        private Label Book;
        private Panel authorPanel;
        private Label authorDOBLabel;
        private Label authorLastNameLabel;
        private Label authorFirstNameLabel;
        private TextBox authorLastNameText;
        private TextBox authorFirstNameText;
        private Label label3;
        private Button authorButton;
        private Button bookButton;
        private Button customerButton;
        private OpenFileDialog openFileDialog;
        private Button customerInsertButton;
        private Button bookDeleteButton;
        private Button bookInsertButton;
        private Button customerDeleteButton;
        private Button authorInsert;
        private Button authorDelete;
        private BindingSource addRemoveViewModelBindingSource;
        private DateTimePicker authorDOBDatePicker;
    }
}
