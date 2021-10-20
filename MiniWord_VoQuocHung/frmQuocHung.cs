using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWord_VoQuocHung
{
    
    public partial class frmQuocHung : Form
    {
        
        public frmQuocHung()
        {
            InitializeComponent();
            loadFont();
            cbbFont.SelectedItem = "Times New Roman";
            cbbFontSize.SelectedItem = "15";
            chenIcon();

        }

        bool Ktra = false;
        String path = "";
        private bool checkFile = false;
        private string pathS = "";
        public void saveFile()
        {


           

                SaveFileDialog luu = new SaveFileDialog();
                luu.Filter = "Save File (*.rtf)|*.rtf| (*.txt)|*.txt";
           
                if (luu.ShowDialog() == DialogResult.OK)
                {


                    path = luu.FileName;
                    if (path != "")
                    {
                        richTb.SaveFile(path);
                        checkFile = true;
                        pathS = path;
                    }
                }
            
            
            
        }
        public void openFile()
        {
            OpenFileDialog mo = new OpenFileDialog();
            mo.ShowDialog();
            path = mo.FileName;
            if (path != "")
            {
                richTb.LoadFile(path);
                checkFile = true;
                pathS = path;
            }
           
        }
        public void newFile()
        {
            richTb.Text = String.Empty;
        }
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
                
                saveFile();
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            checkFile = false;
            pathS = "";
            pnlChinh.Enabled = true;
            richTb.Visible = true;
            newFile();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            pnlChinh.Enabled = false;
            richTb.Visible = false;
            checkFile = false;
            pathS = "";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            richTb.SelectionColor = c.Color;
            btnColor.FlatAppearance.BorderColor = c.Color;
        }

        private string fontName = "Times New Roman";
        float fontSize = 15;
        private void loadFont()
        {
            foreach (FontFamily f in FontFamily.Families)
            {
                cbbFont.Items.Add(f.Name);
            }
           
        }
        private void cbbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontName = cbbFont.SelectedItem.ToString();
            richTb.SelectionFont = new Font(fontName, fontSize);
        }

        private void cbbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontSize = float.Parse(cbbFontSize.SelectedItem.ToString());
            richTb.SelectionFont = new Font(fontName, fontSize);
        }

        private void btnNenChu_Click(object sender, EventArgs e)
        {
            ColorDialog mauNen = new ColorDialog();
            mauNen.ShowDialog();
            richTb.SelectionBackColor = mauNen.Color;
            btnNenChu.FlatAppearance.BorderColor = mauNen.Color;
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {

            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                richTb.Paste();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (richTb.SelectionLength > 0)
                richTb.Cut();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (richTb.SelectionLength > 0)
                richTb.Copy();
        }

      

        private void btnUndo_Click(object sender, EventArgs e)
        {
            richTb.Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            richTb.Redo();
        }
        public float zoomText = 1;
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (zoomText >= 64)
            {
                return;
            }
            else
            {
                richTb.ZoomFactor = zoomText;
                zoomText += 2;
            }
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            
            if(zoomText <= 1)
            {
                return;
            }
            else
            {
                richTb.ZoomFactor = zoomText;
                zoomText -= 2;
            }
        }

        private void btnChenAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog chenAnh = new OpenFileDialog();
            chenAnh.Filter = "Image|*.bmp;*.jpg;*.gif;*.png;*.tif";
            chenAnh.ShowDialog();
            string path = chenAnh.FileName;
            if(path != "")
            {
                Clipboard.SetImage(Image.FromFile(path));
                richTb.Paste();
            }
            
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            richTb.SelectionAlignment = HorizontalAlignment.Left;
            btnleft.FlatAppearance.BorderColor = Color.Black;
        }

        private void btncenter_Click(object sender, EventArgs e)
        {
            richTb.SelectionAlignment = HorizontalAlignment.Center;
            btncenter.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnrigth_Click(object sender, EventArgs e)
        {
            richTb.SelectionAlignment = HorizontalAlignment.Right;
            btnrigth.FlatAppearance.BorderColor = Color.Black;
        }


        

        private bool checkBold = false;
        private bool checkItalic = false;
        private bool checkUnder = false;
      
        private void btnTypeText_Click(object sender, EventArgs e)
        {
            try
            {
                Button s = (Button)sender; 
                if (s.Name == "btnBold")
                {
                    if (s.FlatAppearance.BorderColor == Color.White)
                    {
                       
                        richTb.SelectionFont = new Font(fontName, fontSize, (FontStyle.Bold | (checkItalic ? FontStyle.Italic : 0) | (checkUnder ? FontStyle.Underline : 0)  ));
                        s.FlatAppearance.BorderColor = Color.Black;
                        checkBold = true;
                    }
                    else
                    {
                        richTb.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular | (checkItalic ? FontStyle.Italic : 0) | (checkUnder ? FontStyle.Underline : 0) ));
                        s.FlatAppearance.BorderColor = Color.White;
                        checkBold = false;
                    }
                }
                else if (s.Name == "btnItalic")
                {
                    if (s.FlatAppearance.BorderColor == Color.White)
                    {

                        richTb.SelectionFont = new Font(fontName, fontSize, (FontStyle.Italic | (checkBold ? FontStyle.Bold : 0) | (checkUnder ? FontStyle.Underline : 0) ));
                        s.FlatAppearance.BorderColor = Color.Black;
                        checkItalic = true;
                    }
                    else
                    {
                        richTb.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular | (checkBold ? FontStyle.Bold : 0) | (checkUnder ? FontStyle.Underline : 0) ));
                        s.FlatAppearance.BorderColor = Color.White;
                        checkItalic = false;
                    }
                }
                else if (s.Name == "btnUnderline")
                {
                    if (s.FlatAppearance.BorderColor == Color.White)
                    {
                        richTb.SelectionFont = new Font(fontName, fontSize, (FontStyle.Underline | (checkItalic ? FontStyle.Italic : 0) | (checkBold ? FontStyle.Bold : 0) ));
                        s.FlatAppearance.BorderColor = Color.Black;
                        checkUnder = true;
                    }
                    else
                    {
                        richTb.SelectionFont = new Font(fontName, fontSize, (FontStyle.Regular | (checkItalic ? FontStyle.Italic : 0) | (checkBold ? FontStyle.Bold : 0) ));
                        s.FlatAppearance.BorderColor = Color.White;
                        checkUnder = false;
                    }
                }
            }
            catch
            {

            }
        }
            private void btnBold_Click(object sender, EventArgs e)
        {
           
            btnBold.FlatAppearance.BorderColor = Color.Black;
          
            richTb.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold);
           
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
           
            btnItalic.FlatAppearance.BorderColor = Color.Black;
            
            richTb.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic);

        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            
            btnUnderline.FlatAppearance.BorderColor = Color.Black;
           
            richTb.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline);

        }
        
        
        
        

        private void btnFind_Click(object sender, EventArgs e)
        {
         
        }
        private void chenIcon()
        {
            string duongDan = Environment.CurrentDirectory.ToString(); 
            var url = Directory.GetParent(Directory.GetParent(duongDan).ToString());
            string path = url + @"\Icon"; 
            string[] files = Directory.GetFiles(path); 
            foreach (String f in files)
            {
                Image img = Image.FromFile(f);  
                imageList1.Images.Add(img); 
            }
           
            this.listView1.LargeImageList = this.imageList1; 
            
            for (int i = 0; i < this.imageList1.Images.Count; i++)
            {
                this.listView1.Items.Add(" ", i);
            }

        }
        private int id = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedIndices.Count <= 0) return;
                if (listView1.FocusedItem == null) return;
                id = listView1.SelectedIndices[0];
                if (id < 0) return; 
                Clipboard.SetImage(imageList1.Images[id]); 
                richTb.Paste(); 
                listView1.Visible = false;
            }
            catch
            {

            }

        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            if(listView1.Visible == false)
            {
                listView1.Visible = true;
            }
            else
            {
                listView1.Visible = false;
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTb_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (richTb.SelectionFont != null)
                {
                    btnColor.FlatAppearance.BorderColor = richTb.SelectionColor;

                    btnNenChu.FlatAppearance.BorderColor = richTb.SelectionBackColor;
                }
               
            }
            catch 
            {

            }

            

        }

        private void listView1_MouseLeave(object sender, EventArgs e)
        {
            listView1.Visible = false;
        }

        private void frmQuocHung_Load(object sender, EventArgs e)
        {

        }
      

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkFile)
            {
                richTb.SaveFile(pathS);
            }
            else
            {
                saveFile();
            }
            
            
        }
    }
}
