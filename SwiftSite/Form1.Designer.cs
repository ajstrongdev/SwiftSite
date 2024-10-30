namespace SwiftSite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            flpControls = new FlowLayoutPanel();
            btnGenerate = new Button();
            btnAdd = new Button();
            flpSidebar = new FlowLayoutPanel();
            labelHome = new Label();
            btnTitle = new Button();
            btnSection = new Button();
            btnImage = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelTitle = new Label();
            tbxTitle = new TextBox();
            labelContent = new Label();
            rtbContent = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            flpControls.SuspendLayout();
            flpSidebar.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(241, 245, 249);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.5216284F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.47837F));
            tableLayoutPanel1.Controls.Add(flpControls, 1, 1);
            tableLayoutPanel1.Controls.Add(flpSidebar, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.76509F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.23491F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1209, 613);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flpControls
            // 
            flpControls.Controls.Add(btnGenerate);
            flpControls.Controls.Add(btnAdd);
            flpControls.Dock = DockStyle.Fill;
            flpControls.Location = new Point(190, 541);
            flpControls.Name = "flpControls";
            flpControls.RightToLeft = RightToLeft.Yes;
            flpControls.Size = new Size(1016, 69);
            flpControls.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 16F);
            btnGenerate.Location = new Point(777, 3);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(236, 57);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate Page";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 16F);
            btnAdd.Location = new Point(616, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(155, 57);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // flpSidebar
            // 
            flpSidebar.BackColor = Color.FromArgb(241, 245, 249);
            flpSidebar.Controls.Add(labelHome);
            flpSidebar.Controls.Add(btnTitle);
            flpSidebar.Controls.Add(btnSection);
            flpSidebar.Controls.Add(btnImage);
            flpSidebar.Dock = DockStyle.Fill;
            flpSidebar.FlowDirection = FlowDirection.TopDown;
            flpSidebar.Location = new Point(3, 3);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Size = new Size(181, 532);
            flpSidebar.TabIndex = 1;
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.FlatStyle = FlatStyle.Flat;
            labelHome.Font = new Font("Segoe UI", 16F);
            labelHome.Location = new Point(3, 0);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(119, 37);
            labelHome.TabIndex = 1;
            labelHome.Text = "SwiftSite";
            labelHome.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnTitle
            // 
            btnTitle.Location = new Point(3, 40);
            btnTitle.Name = "btnTitle";
            btnTitle.Size = new Size(174, 29);
            btnTitle.TabIndex = 2;
            btnTitle.Text = "Title";
            btnTitle.UseVisualStyleBackColor = true;
            btnTitle.Click += btnTitle_Click;
            // 
            // btnSection
            // 
            btnSection.Location = new Point(3, 75);
            btnSection.Name = "btnSection";
            btnSection.Size = new Size(174, 29);
            btnSection.TabIndex = 0;
            btnSection.Text = "Section";
            btnSection.UseVisualStyleBackColor = true;
            btnSection.Click += btnSection_Click;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(3, 110);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(174, 29);
            btnImage.TabIndex = 3;
            btnImage.Text = "Image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(226, 232, 240);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(labelTitle, 0, 1);
            tableLayoutPanel2.Controls.Add(tbxTitle, 0, 2);
            tableLayoutPanel2.Controls.Add(labelContent, 0, 3);
            tableLayoutPanel2.Controls.Add(rtbContent, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(190, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 84F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0325813F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 86.9674149F));
            tableLayoutPanel2.Size = new Size(1016, 532);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F);
            labelTitle.Location = new Point(3, 8);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(68, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // tbxTitle
            // 
            tbxTitle.Dock = DockStyle.Fill;
            tbxTitle.Font = new Font("Segoe UI", 16F);
            tbxTitle.Location = new Point(3, 52);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(990, 43);
            tbxTitle.TabIndex = 1;
            // 
            // labelContent
            // 
            labelContent.AutoSize = true;
            labelContent.Font = new Font("Segoe UI", 16F);
            labelContent.Location = new Point(3, 133);
            labelContent.Name = "labelContent";
            labelContent.Size = new Size(112, 37);
            labelContent.TabIndex = 2;
            labelContent.Text = "Content";
            // 
            // rtbContent
            // 
            rtbContent.BorderStyle = BorderStyle.None;
            rtbContent.Dock = DockStyle.Fill;
            rtbContent.Font = new Font("Segoe UI", 16F);
            rtbContent.Location = new Point(3, 188);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(990, 341);
            rtbContent.TabIndex = 3;
            rtbContent.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 613);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "SwiftSite";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flpControls.ResumeLayout(false);
            flpSidebar.ResumeLayout(false);
            flpSidebar.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpControls;
        private FlowLayoutPanel flpSidebar;
        private Button btnSection;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelTitle;
        private TextBox tbxTitle;
        private Label labelContent;
        private RichTextBox rtbContent;
        private Label labelHome;
        private Button btnAdd;
        private Button btnGenerate;
        private Button btnTitle;
        private Button btnImage;
    }
}
