namespace Painter
{
   partial class Painter
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
         this.menuStrip = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.paintPanel = new System.Windows.Forms.Panel();
         this.buttonPanel = new System.Windows.Forms.Panel();
         this.colorButton = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.toolFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
         this.colorGroupBox = new System.Windows.Forms.GroupBox();
         this.greenRadioButton = new System.Windows.Forms.RadioButton();
         this.purpleRadioButton = new System.Windows.Forms.RadioButton();
         this.blueRadioButton = new System.Windows.Forms.RadioButton();
         this.redRadioButton = new System.Windows.Forms.RadioButton();
         this.brushSizeGroupBox = new System.Windows.Forms.GroupBox();
         this.largeRadioButton = new System.Windows.Forms.RadioButton();
         this.mediumRadioButton = new System.Windows.Forms.RadioButton();
         this.smallRadioButton = new System.Windows.Forms.RadioButton();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip.SuspendLayout();
         this.paintPanel.SuspendLayout();
         this.buttonPanel.SuspendLayout();
         this.toolFlowLayout.SuspendLayout();
         this.colorGroupBox.SuspendLayout();
         this.brushSizeGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip
         // 
         this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
         this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.aboutToolStripMenuItem});
         this.menuStrip.Location = new System.Drawing.Point(0, 0);
         this.menuStrip.Name = "menuStrip";
         this.menuStrip.Size = new System.Drawing.Size(1060, 24);
         this.menuStrip.TabIndex = 0;
         this.menuStrip.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // newToolStripMenuItem
         // 
         this.newToolStripMenuItem.Name = "newToolStripMenuItem";
         this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
         this.newToolStripMenuItem.Text = "New";
         this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.exitToolStripMenuItem.Text = "Exit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
         // 
         // formatToolStripMenuItem
         // 
         this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.sizeToolStripMenuItem});
         this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
         this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
         this.formatToolStripMenuItem.Text = "Format";
         // 
         // colorToolStripMenuItem
         // 
         this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueToolStripMenuItem,
            this.redToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.greenToolStripMenuItem});
         this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
         this.colorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
         this.colorToolStripMenuItem.Text = "Color";
         // 
         // blueToolStripMenuItem
         // 
         this.blueToolStripMenuItem.Checked = true;
         this.blueToolStripMenuItem.CheckOnClick = true;
         this.blueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
         this.blueToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
         this.blueToolStripMenuItem.Text = "Blue";
         this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
         // 
         // redToolStripMenuItem
         // 
         this.redToolStripMenuItem.CheckOnClick = true;
         this.redToolStripMenuItem.Name = "redToolStripMenuItem";
         this.redToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
         this.redToolStripMenuItem.Text = "Red";
         this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
         // 
         // purpleToolStripMenuItem
         // 
         this.purpleToolStripMenuItem.CheckOnClick = true;
         this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
         this.purpleToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
         this.purpleToolStripMenuItem.Text = "Purple";
         this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
         // 
         // greenToolStripMenuItem
         // 
         this.greenToolStripMenuItem.CheckOnClick = true;
         this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
         this.greenToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
         this.greenToolStripMenuItem.Text = "Green";
         this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
         // 
         // sizeToolStripMenuItem
         // 
         this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem});
         this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
         this.sizeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
         this.sizeToolStripMenuItem.Text = "Size";
         // 
         // smallToolStripMenuItem
         // 
         this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
         this.smallToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
         this.smallToolStripMenuItem.Text = "Small";
         this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
         // 
         // mediumToolStripMenuItem
         // 
         this.mediumToolStripMenuItem.Checked = true;
         this.mediumToolStripMenuItem.CheckOnClick = true;
         this.mediumToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
         this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
         this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
         this.mediumToolStripMenuItem.Text = "Medium";
         this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
         // 
         // largeToolStripMenuItem
         // 
         this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
         this.largeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
         this.largeToolStripMenuItem.Text = "Large";
         this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
         this.aboutToolStripMenuItem.Text = "About";
         this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
         // 
         // paintPanel
         // 
         this.paintPanel.BackColor = System.Drawing.SystemColors.ControlLight;
         this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.paintPanel.Controls.Add(this.buttonPanel);
         this.paintPanel.Controls.Add(this.toolFlowLayout);
         this.paintPanel.Location = new System.Drawing.Point(0, 27);
         this.paintPanel.Name = "paintPanel";
         this.paintPanel.Size = new System.Drawing.Size(122, 628);
         this.paintPanel.TabIndex = 5;
         // 
         // buttonPanel
         // 
         this.buttonPanel.BackColor = System.Drawing.SystemColors.ControlDark;
         this.buttonPanel.Controls.Add(this.colorButton);
         this.buttonPanel.Controls.Add(this.button2);
         this.buttonPanel.Location = new System.Drawing.Point(8, 7);
         this.buttonPanel.Name = "buttonPanel";
         this.buttonPanel.Size = new System.Drawing.Size(106, 273);
         this.buttonPanel.TabIndex = 5;
         // 
         // colorButton
         // 
         this.colorButton.Location = new System.Drawing.Point(5, 5);
         this.colorButton.Name = "colorButton";
         this.colorButton.Size = new System.Drawing.Size(45, 40);
         this.colorButton.TabIndex = 1;
         this.colorButton.Text = "Color";
         this.colorButton.UseVisualStyleBackColor = true;
         this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(55, 5);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(45, 40);
         this.button2.TabIndex = 2;
         this.button2.Text = "Brush";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.brushSizeButton_Click);
         // 
         // toolFlowLayout
         // 
         this.toolFlowLayout.BackColor = System.Drawing.SystemColors.ControlDark;
         this.toolFlowLayout.Controls.Add(this.colorGroupBox);
         this.toolFlowLayout.Controls.Add(this.brushSizeGroupBox);
         this.toolFlowLayout.Location = new System.Drawing.Point(8, 286);
         this.toolFlowLayout.Name = "toolFlowLayout";
         this.toolFlowLayout.Size = new System.Drawing.Size(104, 333);
         this.toolFlowLayout.TabIndex = 0;
         // 
         // colorGroupBox
         // 
         this.colorGroupBox.Controls.Add(this.greenRadioButton);
         this.colorGroupBox.Controls.Add(this.purpleRadioButton);
         this.colorGroupBox.Controls.Add(this.blueRadioButton);
         this.colorGroupBox.Controls.Add(this.redRadioButton);
         this.colorGroupBox.Location = new System.Drawing.Point(3, 3);
         this.colorGroupBox.Name = "colorGroupBox";
         this.colorGroupBox.Size = new System.Drawing.Size(91, 113);
         this.colorGroupBox.TabIndex = 0;
         this.colorGroupBox.TabStop = false;
         this.colorGroupBox.Text = "Colors";
         this.colorGroupBox.Visible = false;
         // 
         // greenRadioButton
         // 
         this.greenRadioButton.AutoSize = true;
         this.greenRadioButton.Location = new System.Drawing.Point(7, 91);
         this.greenRadioButton.Name = "greenRadioButton";
         this.greenRadioButton.Size = new System.Drawing.Size(54, 17);
         this.greenRadioButton.TabIndex = 3;
         this.greenRadioButton.Text = "Green";
         this.greenRadioButton.UseVisualStyleBackColor = true;
         this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
         // 
         // purpleRadioButton
         // 
         this.purpleRadioButton.AutoSize = true;
         this.purpleRadioButton.Location = new System.Drawing.Point(7, 67);
         this.purpleRadioButton.Name = "purpleRadioButton";
         this.purpleRadioButton.Size = new System.Drawing.Size(55, 17);
         this.purpleRadioButton.TabIndex = 2;
         this.purpleRadioButton.Text = "Purple";
         this.purpleRadioButton.UseVisualStyleBackColor = true;
         this.purpleRadioButton.CheckedChanged += new System.EventHandler(this.purpleRadioButton_CheckedChanged);
         // 
         // blueRadioButton
         // 
         this.blueRadioButton.AutoSize = true;
         this.blueRadioButton.Checked = true;
         this.blueRadioButton.Location = new System.Drawing.Point(6, 20);
         this.blueRadioButton.Name = "blueRadioButton";
         this.blueRadioButton.Size = new System.Drawing.Size(46, 17);
         this.blueRadioButton.TabIndex = 1;
         this.blueRadioButton.TabStop = true;
         this.blueRadioButton.Text = "Blue";
         this.blueRadioButton.UseVisualStyleBackColor = true;
         this.blueRadioButton.CheckedChanged += new System.EventHandler(this.blueRadioButton_CheckedChanged);
         // 
         // redRadioButton
         // 
         this.redRadioButton.AutoSize = true;
         this.redRadioButton.Location = new System.Drawing.Point(6, 43);
         this.redRadioButton.Name = "redRadioButton";
         this.redRadioButton.Size = new System.Drawing.Size(45, 17);
         this.redRadioButton.TabIndex = 0;
         this.redRadioButton.Text = "Red";
         this.redRadioButton.UseVisualStyleBackColor = true;
         this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
         // 
         // brushSizeGroupBox
         // 
         this.brushSizeGroupBox.Controls.Add(this.largeRadioButton);
         this.brushSizeGroupBox.Controls.Add(this.mediumRadioButton);
         this.brushSizeGroupBox.Controls.Add(this.smallRadioButton);
         this.brushSizeGroupBox.Location = new System.Drawing.Point(3, 122);
         this.brushSizeGroupBox.Name = "brushSizeGroupBox";
         this.brushSizeGroupBox.Size = new System.Drawing.Size(91, 141);
         this.brushSizeGroupBox.TabIndex = 1;
         this.brushSizeGroupBox.TabStop = false;
         this.brushSizeGroupBox.Text = "Brush Size";
         this.brushSizeGroupBox.Visible = false;
         // 
         // largeRadioButton
         // 
         this.largeRadioButton.AutoSize = true;
         this.largeRadioButton.Location = new System.Drawing.Point(7, 68);
         this.largeRadioButton.Name = "largeRadioButton";
         this.largeRadioButton.Size = new System.Drawing.Size(52, 17);
         this.largeRadioButton.TabIndex = 2;
         this.largeRadioButton.TabStop = true;
         this.largeRadioButton.Text = "Large";
         this.largeRadioButton.UseVisualStyleBackColor = true;
         this.largeRadioButton.CheckedChanged += new System.EventHandler(this.largeRadioButton_CheckedChanged);
         // 
         // mediumRadioButton
         // 
         this.mediumRadioButton.AutoSize = true;
         this.mediumRadioButton.Checked = true;
         this.mediumRadioButton.Location = new System.Drawing.Point(7, 44);
         this.mediumRadioButton.Name = "mediumRadioButton";
         this.mediumRadioButton.Size = new System.Drawing.Size(62, 17);
         this.mediumRadioButton.TabIndex = 1;
         this.mediumRadioButton.TabStop = true;
         this.mediumRadioButton.Text = "Medium";
         this.mediumRadioButton.UseVisualStyleBackColor = true;
         this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.mediumRadioButton_CheckedChanged);
         // 
         // smallRadioButton
         // 
         this.smallRadioButton.AutoSize = true;
         this.smallRadioButton.Location = new System.Drawing.Point(7, 20);
         this.smallRadioButton.Name = "smallRadioButton";
         this.smallRadioButton.Size = new System.Drawing.Size(50, 17);
         this.smallRadioButton.TabIndex = 0;
         this.smallRadioButton.Text = "Small";
         this.smallRadioButton.UseVisualStyleBackColor = true;
         this.smallRadioButton.CheckedChanged += new System.EventHandler(this.smallRadioButton_CheckedChanged);
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Enabled = false;
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.saveToolStripMenuItem.Text = "Save";
         this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
         // 
         // Painter
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1060, 658);
         this.Controls.Add(this.paintPanel);
         this.Controls.Add(this.menuStrip);
         this.IsMdiContainer = true;
         this.MainMenuStrip = this.menuStrip;
         this.Name = "Painter";
         this.Text = "Painter";
         this.menuStrip.ResumeLayout(false);
         this.menuStrip.PerformLayout();
         this.paintPanel.ResumeLayout(false);
         this.buttonPanel.ResumeLayout(false);
         this.toolFlowLayout.ResumeLayout(false);
         this.colorGroupBox.ResumeLayout(false);
         this.colorGroupBox.PerformLayout();
         this.brushSizeGroupBox.ResumeLayout(false);
         this.brushSizeGroupBox.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
      private System.Windows.Forms.Panel paintPanel;
      private System.Windows.Forms.Panel buttonPanel;
      private System.Windows.Forms.Button colorButton;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.FlowLayoutPanel toolFlowLayout;
      private System.Windows.Forms.GroupBox colorGroupBox;
      private System.Windows.Forms.RadioButton greenRadioButton;
      private System.Windows.Forms.RadioButton purpleRadioButton;
      private System.Windows.Forms.RadioButton blueRadioButton;
      private System.Windows.Forms.RadioButton redRadioButton;
      private System.Windows.Forms.GroupBox brushSizeGroupBox;
      private System.Windows.Forms.RadioButton largeRadioButton;
      private System.Windows.Forms.RadioButton mediumRadioButton;
      private System.Windows.Forms.RadioButton smallRadioButton;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
   }
}

