
namespace Paint
{
    partial class F_Menu
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
            this.ok_bt = new System.Windows.Forms.Button();
            this.num_width = new System.Windows.Forms.NumericUpDown();
            this.num_heigth = new System.Windows.Forms.NumericUpDown();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.label_width = new System.Windows.Forms.Label();
            this.label_heigth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_heigth)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_bt
            // 
            this.ok_bt.Location = new System.Drawing.Point(87, 89);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(75, 23);
            this.ok_bt.TabIndex = 0;
            this.ok_bt.Text = "ОК";
            this.ok_bt.UseVisualStyleBackColor = true;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // num_width
            // 
            this.num_width.Location = new System.Drawing.Point(58, 46);
            this.num_width.Maximum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.num_width.Minimum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.num_width.Name = "num_width";
            this.num_width.Size = new System.Drawing.Size(120, 20);
            this.num_width.TabIndex = 1;
            this.num_width.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // num_heigth
            // 
            this.num_heigth.Location = new System.Drawing.Point(245, 46);
            this.num_heigth.Maximum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.num_heigth.Minimum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.num_heigth.Name = "num_heigth";
            this.num_heigth.Size = new System.Drawing.Size(120, 20);
            this.num_heigth.TabIndex = 2;
            this.num_heigth.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(245, 89);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 23);
            this.cancel_bt.TabIndex = 3;
            this.cancel_bt.Text = "Отмена";
            this.cancel_bt.UseVisualStyleBackColor = true;
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(84, 30);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(46, 13);
            this.label_width.TabIndex = 4;
            this.label_width.Text = "Ширина";
            // 
            // label_heigth
            // 
            this.label_heigth.AutoSize = true;
            this.label_heigth.Location = new System.Drawing.Point(275, 30);
            this.label_heigth.Name = "label_heigth";
            this.label_heigth.Size = new System.Drawing.Size(45, 13);
            this.label_heigth.TabIndex = 5;
            this.label_heigth.Text = "Высота";
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 124);
            this.Controls.Add(this.label_heigth);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.num_heigth);
            this.Controls.Add(this.num_width);
            this.Controls.Add(this.ok_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_Menu";
            this.Text = "F_Menu";
            this.Load += new System.EventHandler(this.F_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_heigth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.NumericUpDown num_width;
        private System.Windows.Forms.NumericUpDown num_heigth;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_heigth;
    }
}