namespace Painter
{
   partial class PaintForm
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
         this.paintPanel = new System.Windows.Forms.Panel();
         this.SuspendLayout();
         // 
         // paintPanel
         // 
         this.paintPanel.Location = new System.Drawing.Point(3, 2);
         this.paintPanel.Name = "paintPanel";
         this.paintPanel.Size = new System.Drawing.Size(880, 584);
         this.paintPanel.TabIndex = 0;
         // 
         // PaintForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(884, 589);
         this.Controls.Add(this.paintPanel);
         this.Name = "PaintForm";
         this.Text = "Paint Form";
         this.ResumeLayout(false);

      }

      #endregion

      public System.Windows.Forms.Panel paintPanel;

   }
}