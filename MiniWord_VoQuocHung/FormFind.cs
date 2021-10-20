using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWord_VoQuocHung
{
    public partial class FormFind : Form
    {
        public RichTextBox rtxTimText;
        public FormFind(RichTextBox rtbGhi)
        {
            InitializeComponent();
            rtxTimText = rtbGhi;
        }
        
      
        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
