
namespace Paint
{
    partial class FImage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.X_bt = new System.Windows.Forms.Label();
            this.Y_bt = new System.Windows.Forms.Label();
            this.X_textBox = new System.Windows.Forms.TextBox();
            this.Y_textBox = new System.Windows.Forms.TextBox();
            this.Timer_Paint = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down_bt);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up_bt);
            // 
            // X_bt
            // 
            this.X_bt.AutoSize = true;
            this.X_bt.Location = new System.Drawing.Point(64, 57);
            this.X_bt.Name = "X_bt";
            this.X_bt.Size = new System.Drawing.Size(14, 13);
            this.X_bt.TabIndex = 1;
            this.X_bt.Text = "X";
            // 
            // Y_bt
            // 
            this.Y_bt.AutoSize = true;
            this.Y_bt.Location = new System.Drawing.Point(64, 129);
            this.Y_bt.Name = "Y_bt";
            this.Y_bt.Size = new System.Drawing.Size(14, 13);
            this.Y_bt.TabIndex = 2;
            this.Y_bt.Text = "Y";
            // 
            // X_textBox
            // 
            this.X_textBox.Location = new System.Drawing.Point(21, 73);
            this.X_textBox.Name = "X_textBox";
            this.X_textBox.Size = new System.Drawing.Size(100, 20);
            this.X_textBox.TabIndex = 3;
            // 
            // Y_textBox
            // 
            this.Y_textBox.Location = new System.Drawing.Point(21, 145);
            this.Y_textBox.Name = "Y_textBox";
            this.Y_textBox.Size = new System.Drawing.Size(100, 20);
            this.Y_textBox.TabIndex = 4;
            // 
            // Timer_Paint
            // 
            this.Timer_Paint.Interval = 10;
            this.Timer_Paint.Tick += new System.EventHandler(this.Timer_Paint_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(136, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 360);
            this.panel1.TabIndex = 5;
            // 
            // FImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Y_textBox);
            this.Controls.Add(this.X_textBox);
            this.Controls.Add(this.Y_bt);
            this.Controls.Add(this.X_bt);
            this.Name = "FImage";
            this.Text = "FImage";
            this.Load += new System.EventHandler(this.FImage_Load);
            this.Shown += new System.EventHandler(this.F_Image_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.F_Image_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label X_bt;
        private System.Windows.Forms.Label Y_bt;
        private System.Windows.Forms.TextBox X_textBox;
        private System.Windows.Forms.TextBox Y_textBox;
        private System.Windows.Forms.Timer Timer_Paint;
        private System.Windows.Forms.Panel panel1;
    }
}