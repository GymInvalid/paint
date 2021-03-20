
namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_Bt = new System.Windows.Forms.ToolStripMenuItem();
            this.Download_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.create_Bt = new System.Windows.Forms.ToolStripMenuItem();
            this.File2_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWindowPaint_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseWindowPaint_bt = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.l_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel_Instruments = new System.Windows.Forms.Panel();
            this.GBox = new System.Windows.Forms.GroupBox();
            this.Color_Panel = new System.Windows.Forms.Panel();
            this.NumericUp = new System.Windows.Forms.NumericUpDown();
            this.Radius = new System.Windows.Forms.Label();
            this.Color_bt = new System.Windows.Forms.Label();
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveImageDiolog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Panel_Instruments.SuspendLayout();
            this.GBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUp)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_Bt,
            this.File2_bt});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_Bt
            // 
            this.File_Bt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Download_bt,
            this.SaveAs_bt,
            this.create_Bt});
            this.File_Bt.Name = "File_Bt";
            this.File_Bt.Size = new System.Drawing.Size(48, 20);
            this.File_Bt.Text = "Файл";
            // 
            // Download_bt
            // 
            this.Download_bt.Name = "Download_bt";
            this.Download_bt.Size = new System.Drawing.Size(180, 22);
            this.Download_bt.Text = "Загрузить";
            this.Download_bt.Click += new System.EventHandler(this.Download_bt_Click);
            // 
            // SaveAs_bt
            // 
            this.SaveAs_bt.Name = "SaveAs_bt";
            this.SaveAs_bt.Size = new System.Drawing.Size(180, 22);
            this.SaveAs_bt.Text = "Сохранить как ...";
            this.SaveAs_bt.Click += new System.EventHandler(this.SaveAs_bt_Click);
            // 
            // create_Bt
            // 
            this.create_Bt.Name = "create_Bt";
            this.create_Bt.Size = new System.Drawing.Size(180, 22);
            this.create_Bt.Text = "Создать новый";
            this.create_Bt.Click += new System.EventHandler(this.create_Bt_Click);
            // 
            // File2_bt
            // 
            this.File2_bt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenWindowPaint_bt,
            this.CloseWindowPaint_bt});
            this.File2_bt.Name = "File2_bt";
            this.File2_bt.Size = new System.Drawing.Size(39, 20);
            this.File2_bt.Text = "Вид";
            // 
            // OpenWindowPaint_bt
            // 
            this.OpenWindowPaint_bt.Name = "OpenWindowPaint_bt";
            this.OpenWindowPaint_bt.Size = new System.Drawing.Size(213, 22);
            this.OpenWindowPaint_bt.Text = "Открыть окно рисования";
            // 
            // CloseWindowPaint_bt
            // 
            this.CloseWindowPaint_bt.Name = "CloseWindowPaint_bt";
            this.CloseWindowPaint_bt.Size = new System.Drawing.Size(213, 22);
            this.CloseWindowPaint_bt.Text = "Закрыть окно рисования";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // l_Status
            // 
            this.l_Status.Name = "l_Status";
            this.l_Status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_Status.Size = new System.Drawing.Size(74, 17);
            this.l_Status.Text = "Инструмент";
            // 
            // Panel_Instruments
            // 
            this.Panel_Instruments.Controls.Add(this.GBox);
            this.Panel_Instruments.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Instruments.Location = new System.Drawing.Point(0, 24);
            this.Panel_Instruments.Name = "Panel_Instruments";
            this.Panel_Instruments.Size = new System.Drawing.Size(150, 322);
            this.Panel_Instruments.TabIndex = 3;
            // 
            // GBox
            // 
            this.GBox.Controls.Add(this.Color_Panel);
            this.GBox.Controls.Add(this.NumericUp);
            this.GBox.Controls.Add(this.Radius);
            this.GBox.Controls.Add(this.Color_bt);
            this.GBox.Location = new System.Drawing.Point(12, 3);
            this.GBox.Name = "GBox";
            this.GBox.Size = new System.Drawing.Size(125, 109);
            this.GBox.TabIndex = 0;
            this.GBox.TabStop = false;
            this.GBox.Text = "Кисть";
            // 
            // Color_Panel
            // 
            this.Color_Panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Color_Panel.Location = new System.Drawing.Point(6, 32);
            this.Color_Panel.Name = "Color_Panel";
            this.Color_Panel.Size = new System.Drawing.Size(50, 27);
            this.Color_Panel.TabIndex = 3;
            this.Color_Panel.Click += new System.EventHandler(this.Color_Click);
            this.Color_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Color_Panel_Paint);
            // 
            // NumericUp
            // 
            this.NumericUp.Location = new System.Drawing.Point(6, 78);
            this.NumericUp.Name = "NumericUp";
            this.NumericUp.Size = new System.Drawing.Size(67, 20);
            this.NumericUp.TabIndex = 2;
            this.NumericUp.ValueChanged += new System.EventHandler(this.num_ValueChanged);
            // 
            // Radius
            // 
            this.Radius.AutoSize = true;
            this.Radius.Location = new System.Drawing.Point(6, 62);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(43, 13);
            this.Radius.TabIndex = 1;
            this.Radius.Text = "Радиус";
            this.Radius.Click += new System.EventHandler(this.Radius_Click);
            // 
            // Color_bt
            // 
            this.Color_bt.AutoSize = true;
            this.Color_bt.Location = new System.Drawing.Point(6, 16);
            this.Color_bt.Name = "Color_bt";
            this.Color_bt.Size = new System.Drawing.Size(32, 13);
            this.Color_bt.TabIndex = 0;
            this.Color_bt.Text = "Цвет";
            // 
            // OpenImageDialog
            // 
            this.OpenImageDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.Panel_Instruments);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Panel_Instruments.ResumeLayout(false);
            this.GBox.ResumeLayout(false);
            this.GBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_Bt;
        private System.Windows.Forms.ToolStripMenuItem Download_bt;
        private System.Windows.Forms.ToolStripMenuItem SaveAs_bt;
        private System.Windows.Forms.ToolStripMenuItem create_Bt;
        private System.Windows.Forms.ToolStripMenuItem File2_bt;
        private System.Windows.Forms.ToolStripMenuItem OpenWindowPaint_bt;
        private System.Windows.Forms.ToolStripMenuItem CloseWindowPaint_bt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel l_Status;
        private System.Windows.Forms.Panel Panel_Instruments;
        private System.Windows.Forms.GroupBox GBox;
        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.Label Color_bt;
        private System.Windows.Forms.Panel Color_Panel;
        private System.Windows.Forms.NumericUpDown NumericUp;
        private System.Windows.Forms.OpenFileDialog OpenImageDialog;
        private System.Windows.Forms.SaveFileDialog SaveImageDiolog;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

