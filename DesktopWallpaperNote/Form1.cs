using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.IO;

namespace DesktopWallpaperNote
{
    public partial class Form1 : Form
    {
        string gradientcolor1_r = null;
        string gradientcolor1_g = null;
        string gradientcolor1_b = null;
        string gradientcolor2_r = null;
        string gradientcolor2_g = null;
        string gradientcolor2_b = null;
        string textcolor_r = null;
        string textcolor_g = null;
        string textcolor_b = null;
        string txtcfull = null;
        string myfilepath = null;
        string cgfc1;
        string cgfc2;

        public Form1()
        {
            InitializeComponent();
        }

        private void gc1_butt_Click(object sender, EventArgs e)
        {
            if(cg1.ShowDialog() == DialogResult.OK){
                gradientcolor1_r = cg1.Color.R.ToString();
                gradientcolor1_g = cg1.Color.G.ToString();
                gradientcolor1_b = cg1.Color.B.ToString();
                cgfc1 = "\"" + gradientcolor1_r + "\" " + "\"" + gradientcolor1_g + "\" " + "\"" + gradientcolor1_b + "\" ";
            }
        }

        private void gc2_butt_Click(object sender, EventArgs e)
        {
            if(cg2.ShowDialog() == DialogResult.OK)
            {
                gradientcolor2_r = cg2.Color.R.ToString();
                gradientcolor2_g = cg2.Color.G.ToString();
                gradientcolor2_b = cg2.Color.B.ToString();
                cgfc2 = "\"" + gradientcolor2_r + "\" " + "\"" + gradientcolor2_g + "\" " + "\"" + gradientcolor2_b + "\" ";
            }
        }

        private void txtc_butt_Click(object sender, EventArgs e)
        {
            if(txtc.ShowDialog() == DialogResult.OK)
            {
                textcolor_r = txtc.Color.R.ToString();
                textcolor_g = txtc.Color.G.ToString();
                textcolor_b = txtc.Color.B.ToString();
                txtcfull = "\"" + textcolor_r + "\" " + "\"" + textcolor_g + "\" " + "\"" + textcolor_b + "\" ";
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            if(cgfc1 != null && cgfc2 != null && txtcfull != null && myfilepath != null)
            {
                Process p = new Process();
                //p.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
                //p.StartInfo.Arguments = 
                string pthonscriptpath = Application.StartupPath + "\\Background-Note.py";
                string full_command = (" \"" + myfilepath.ToString() + "\" " + cgfc1 + cgfc2 + txtcfull + "\"" + img_textbox.Text + "\" \"" + numupdownsize.Value + "\"");
                Clipboard.SetText(full_command);
                //p.StartInfo.UseShellExecute = false;
                System.Diagnostics.Process.Start(pthonscriptpath, full_command);
            }
        }

        private void filepath_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                myfilepath = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
