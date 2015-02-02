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
using System.Drawing.Imaging;

namespace Painter
{
   public partial class Painter : Form
   {
      private bool shouldDraw;
      private Color color;
      private int brushSize;
      private PaintForm paintFormMdi;
      private string fileName;
      Bitmap bmp;
      

      public Painter()
      {
         InitializeComponent();
         shouldDraw = false;
         color = Color.Blue;
         brushSize = 8;
         fileName = "myPicture";
         this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);
         
      }

      private void ClearColorChecks()
      {
         blueToolStripMenuItem.Checked = false;
         redToolStripMenuItem.Checked = false;
         purpleToolStripMenuItem.Checked = false;
         greenToolStripMenuItem.Checked = false;
      }

      private void ClearBrushSizeChecks()
      {
         smallToolStripMenuItem.Checked = false;
         mediumToolStripMenuItem.Checked = false;
         largeToolStripMenuItem.Checked = false;
      }

      private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Painter\n\n Created By Kyle Walter");
      }

      private void paintFormMdi_MouseDown(object sender, MouseEventArgs e)
      {
         shouldDraw = true;
      }

      private void paintFormMdi_MouseUp(object sender, MouseEventArgs e)
      {
         shouldDraw = false;
      }

      private void paintFormMdi_MouseMove(object sender, MouseEventArgs e)
      {
         if (shouldDraw)
         {
            
            using (Graphics g = Graphics.FromImage(bmp)) 
            {
               SolidBrush brush = new SolidBrush(color);
               g.FillEllipse(brush, e.X, e.Y, brushSize, brushSize); 
            }
            paintFormMdi.paintPanel.Invalidate();
         }
      }

      private void paintFormMdi_Paint(object sender, PaintEventArgs e)
      {
         e.Graphics.DrawImage(bmp, Point.Empty);
      }

      private void redToolStripMenuItem_Click(object sender, EventArgs e)
      {
         color = Color.Red;
         ClearColorChecks();
         redToolStripMenuItem.Checked = true;
         redRadioButton.Checked = true;
      }

      private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
      {
         color = Color.Purple;
         ClearColorChecks();
         purpleToolStripMenuItem.Checked = true;
         purpleRadioButton.Checked = true;
      }

      private void greenToolStripMenuItem_Click(object sender, EventArgs e)
      {
         color = Color.Green;
         ClearColorChecks();
         greenToolStripMenuItem.Checked = true;
         greenRadioButton.Checked = true;
      }

      private void blueToolStripMenuItem_Click(object sender, EventArgs e)
      {
         color = Color.Blue;
         ClearColorChecks();
         blueToolStripMenuItem.Checked = true;
         blueRadioButton.Checked = true;
      }

      private void newToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (paintFormMdi == null)
         {
            //Create Paint From Window
            paintFormMdi = new PaintForm();
            paintFormMdi.MdiParent = this;
            paintFormMdi.Show();
            paintFormMdi.paintPanel.MouseDown += new MouseEventHandler(this.paintFormMdi_MouseDown);
            paintFormMdi.paintPanel.MouseUp += new MouseEventHandler(this.paintFormMdi_MouseUp);
            paintFormMdi.paintPanel.MouseMove += new MouseEventHandler(this.paintFormMdi_MouseMove);
            paintFormMdi.paintPanel.Paint += new PaintEventHandler(this.paintFormMdi_Paint);
            paintFormMdi.Location = new System.Drawing.Point(125, 0);
            paintFormMdi.Size = new System.Drawing.Size(900, 628);
            paintFormMdi.FormClosed += new FormClosedEventHandler(this.paintForm_FormClosed);

            //Create Bitmap for drawing on
            bmp = new Bitmap(paintFormMdi.paintPanel.Width, paintFormMdi.paintPanel.Height);
            using(Graphics g = Graphics.FromImage(bmp))
            {
               SolidBrush brush = new SolidBrush(Color.White);
               Region r = new Region(new Rectangle(0,0,paintFormMdi.paintPanel.Width,paintFormMdi.paintPanel.Height));
               g.FillRegion(brush,r);
            }
         }
         else
            paintFormMdi.Activate();

         saveToolStripMenuItem.Enabled = true;
      }

      private void paintForm_FormClosed(object sender, EventArgs e)
      {
         paintFormMdi = null;
      }

      private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         color = Color.Blue;
         ClearColorChecks();
         blueToolStripMenuItem.Checked = true;
      }

      private void redRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         color = Color.Red;
         ClearColorChecks();
         redToolStripMenuItem.Checked = true;
      }

      private void purpleRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         color = Color.Purple;
         ClearColorChecks();
         purpleToolStripMenuItem.Checked = true;
      }

      private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         color = Color.Green;
         ClearColorChecks();
         greenToolStripMenuItem.Checked = true;
      }

      private void colorButton_Click(object sender, EventArgs e)
      {
         colorGroupBox.Visible = true;
         brushSizeGroupBox.Visible = false;
      }

      private void brushSizeButton_Click(object sender, EventArgs e)
      {
         brushSizeGroupBox.Visible = true;
         colorGroupBox.Visible = false;
      }

      private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
      {
         brushSize = 8;
         ClearBrushSizeChecks();
         mediumToolStripMenuItem.Checked = true;
         mediumRadioButton.Checked = true;
      }

      private void smallToolStripMenuItem_Click(object sender, EventArgs e)
      {
         brushSize = 4;
         ClearBrushSizeChecks();
         smallToolStripMenuItem.Checked = true;
         smallRadioButton.Checked = true;
      }

      private void largeToolStripMenuItem_Click(object sender, EventArgs e)
      {
         brushSize = 12;
         ClearBrushSizeChecks();
         largeToolStripMenuItem.Checked = true;
         largeRadioButton.Checked = true;
      }

      private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         brushSize = 4;
         ClearBrushSizeChecks();
         smallToolStripMenuItem.Checked = true;
      }

      private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         brushSize = 8;
         ClearBrushSizeChecks();
         mediumToolStripMenuItem.Checked = true;
      }

      private void largeRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         brushSize = 12;
         ClearBrushSizeChecks();
         largeToolStripMenuItem.Checked = true;
      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void saveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SaveFile();
      }

      private void SaveFile()
      {
         DialogResult result;

         using (SaveFileDialog save = new SaveFileDialog())
         {
            save.CheckFileExists = false;
            save.FileName = fileName;
            save.DefaultExt = "jpg";
            save.AddExtension = true;
            result = save.ShowDialog();
            fileName = save.FileName;
            
         }

         if (result == DialogResult.OK)
         {
            if (fileName == string.Empty)
            {
               MessageBox.Show("Invalid FIle Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               try
               {
                  FileStream outputStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                  bmp.Save(outputStream,ImageFormat.Jpeg);
                  outputStream.Close();
               }
               catch (IOException)
               {
                  MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
         }
         paintFormMdi.Text = fileName;
         
      }

      





   }
}
