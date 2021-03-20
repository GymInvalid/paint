using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public struct CrNewDialogRes
    {
        public int width;
        public int heidth;
        public bool ready;
    }
    public partial class Form1 : Form
    {
        FImage imageField = null;
        public static bool ImageFieldOpened = false;

        public static ImageEditor imageEditor = new ImageEditor();
        public static CrNewDialogRes diagRes = new CrNewDialogRes();

        public Form1()
        {
            InitializeComponent();

            Color_Panel.BackColor = Color.White;
            CreateField();
            OpenImageDialog.Filter = "All files (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";
            SaveImageDiolog.Filter = "All files (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";
        }

        public void CreateField()
        {
            imageField = new FImage();
            imageField.MdiParent = this;
            imageField.Show();
            ImageFieldOpened = true;
        }

        private void Radius_Click(object sender, EventArgs e)
        {

        }

        private void create_Bt_Click(object sender, EventArgs e)
        {
            F_Menu createNewBitmap = new F_Menu();
            createNewBitmap.ShowDialog();
            if (diagRes.ready)
            {
                imageEditor = new ImageEditor(diagRes.width, diagRes.heidth);
                imageField.Refresh();
                Color_Panel.BackColor = Color.White;
                NumericUp.Value = 30;
            }
        }

        private void Download_bt_Click(object sender, EventArgs e)
        {
            if (OpenImageDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = OpenImageDialog.FileName;
                imageEditor.LoadImage(filePath);
                imageField.Refresh();
            }
        }

        private void SaveAs_bt_Click(object sender, EventArgs e)
        {
            if (SaveImageDiolog.ShowDialog() == DialogResult.OK)
            {
                string filePath = SaveImageDiolog.FileName;
                imageField.savePbImage(SaveImageDiolog.FileName);
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color_Panel.BackColor = colorDialog.Color;
                imageEditor.SetBrushColor(colorDialog.Color);
            }
        }

        private void Color_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            imageEditor.SetBrushRadius(Convert.ToInt32(NumericUp.Value));
        }
    }
}
