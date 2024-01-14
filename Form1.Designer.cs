namespace KomponentovaTvorba
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnConvert = new Button();
            cmbFromCurrency = new ComboBox();
            cmbToCurrency = new ComboBox();
            txtFromCurrencyAmount = new TextBox();
            txtToCurrencyAmount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bckgImage = new Panel();
            lblExit = new Label();
            pictureBox1 = new PictureBox();
            lblDate = new Label();
            lblTime = new Label();
            timer = new System.Windows.Forms.Timer(components);
            bckgImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Cursor = Cursors.Hand;
            btnConvert.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = Color.FromArgb(56, 14, 87);
            btnConvert.Location = new Point(272, 360);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(156, 45);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click_1;
            // 
            // cmbFromCurrency
            // 
            cmbFromCurrency.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cmbFromCurrency.ForeColor = Color.FromArgb(56, 14, 87);
            cmbFromCurrency.FormattingEnabled = true;
            cmbFromCurrency.Location = new Point(400, 234);
            cmbFromCurrency.Name = "cmbFromCurrency";
            cmbFromCurrency.Size = new Size(121, 27);
            cmbFromCurrency.TabIndex = 1;
            // 
            // cmbToCurrency
            // 
            cmbToCurrency.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            cmbToCurrency.ForeColor = Color.FromArgb(56, 14, 87);
            cmbToCurrency.FormattingEnabled = true;
            cmbToCurrency.Location = new Point(400, 284);
            cmbToCurrency.Name = "cmbToCurrency";
            cmbToCurrency.Size = new Size(121, 27);
            cmbToCurrency.TabIndex = 2;
            // 
            // txtFromCurrencyAmount
            // 
            txtFromCurrencyAmount.Location = new Point(144, 237);
            txtFromCurrencyAmount.Multiline = true;
            txtFromCurrencyAmount.Name = "txtFromCurrencyAmount";
            txtFromCurrencyAmount.Size = new Size(128, 23);
            txtFromCurrencyAmount.TabIndex = 3;
            // 
            // txtToCurrencyAmount
            // 
            txtToCurrencyAmount.ForeColor = SystemColors.WindowText;
            txtToCurrencyAmount.Location = new Point(144, 284);
            txtToCurrencyAmount.Multiline = true;
            txtToCurrencyAmount.Name = "txtToCurrencyAmount";
            txtToCurrencyAmount.Size = new Size(128, 24);
            txtToCurrencyAmount.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(56, 14, 87);
            label1.Location = new Point(144, 214);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 5;
            label1.Text = "From Currency";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(56, 14, 87);
            label2.Location = new Point(144, 264);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 6;
            label2.Text = "To Currency";
            // 
            // bckgImage
            // 
            bckgImage.AutoSize = true;
            bckgImage.BackgroundImage = (Image)resources.GetObject("bckgImage.BackgroundImage");
            bckgImage.BackgroundImageLayout = ImageLayout.Stretch;
            bckgImage.BorderStyle = BorderStyle.FixedSingle;
            bckgImage.Controls.Add(lblExit);
            bckgImage.Controls.Add(pictureBox1);
            bckgImage.Controls.Add(lblDate);
            bckgImage.Controls.Add(lblTime);
            bckgImage.Controls.Add(btnConvert);
            bckgImage.Controls.Add(label1);
            bckgImage.Controls.Add(label2);
            bckgImage.Controls.Add(txtFromCurrencyAmount);
            bckgImage.Controls.Add(cmbToCurrency);
            bckgImage.Controls.Add(cmbFromCurrency);
            bckgImage.Controls.Add(txtToCurrencyAmount);
            bckgImage.ForeColor = Color.White;
            bckgImage.Location = new Point(-8, -11);
            bckgImage.Margin = new Padding(0);
            bckgImage.Name = "bckgImage";
            bckgImage.Size = new Size(722, 602);
            bckgImage.TabIndex = 8;
            bckgImage.MouseDown += bckgImage_MouseDown;
            bckgImage.MouseMove += bckgImage_MouseMove;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.FromArgb(121, 143, 200);
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExit.ForeColor = Color.White;
            lblExit.Location = new Point(693, 11);
            lblExit.Margin = new Padding(0, 0, 3, 0);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(24, 24);
            lblExit.TabIndex = 10;
            lblExit.Text = "X";
            lblExit.TextAlign = ContentAlignment.MiddleCenter;
            lblExit.Click += lblExit_Click;
            lblExit.MouseEnter += lblExit_MouseEnter;
            lblExit.MouseLeave += lblExit_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.FromArgb(121, 143, 200);
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(144, 11);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.FromArgb(121, 143, 200);
            lblDate.Font = new Font("Segoe UI", 12F);
            lblDate.ForeColor = Color.FromArgb(56, 14, 87);
            lblDate.Location = new Point(254, 57);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(42, 21);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.FromArgb(121, 143, 200);
            lblTime.Font = new Font("Segoe UI", 12F);
            lblTime.ForeColor = Color.FromArgb(56, 14, 87);
            lblTime.Location = new Point(252, 19);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(44, 21);
            lblTime.TabIndex = 7;
            lblTime.Text = "Time";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(709, 589);
            Controls.Add(bckgImage);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Load += Form1_Load;
            bckgImage.ResumeLayout(false);
            bckgImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private ComboBox cmbFromCurrency;
        private ComboBox cmbToCurrency;
        private TextBox txtFromCurrencyAmount;
        private TextBox txtToCurrencyAmount;
        private Label label1;
        private Label label2;
        private Panel bckgImage;
        private Label lblTime;
        private PictureBox pictureBox1;
        private Label lblDate;
        private System.Windows.Forms.Timer timer;
        private Label lblExit;
    }
}
