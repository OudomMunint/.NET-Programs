namespace groupName_prtotypes_ass2
{
    partial class Form5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireASurfBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookALessonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOnToolStripMenuItem,
            this.hireASurfBoardToolStripMenuItem,
            this.bookALessonToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1600, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOnToolStripMenuItem
            // 
            this.logOnToolStripMenuItem.Name = "logOnToolStripMenuItem";
            this.logOnToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.logOnToolStripMenuItem.Text = "Log on";
            this.logOnToolStripMenuItem.Click += new System.EventHandler(this.LogOnToolStripMenuItem_Click);
            // 
            // hireASurfBoardToolStripMenuItem
            // 
            this.hireASurfBoardToolStripMenuItem.Name = "hireASurfBoardToolStripMenuItem";
            this.hireASurfBoardToolStripMenuItem.Size = new System.Drawing.Size(107, 19);
            this.hireASurfBoardToolStripMenuItem.Text = "Hire a surf board";
            this.hireASurfBoardToolStripMenuItem.Click += new System.EventHandler(this.HireASurfBoardToolStripMenuItem_Click);
            // 
            // bookALessonToolStripMenuItem
            // 
            this.bookALessonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginnersToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.bookALessonToolStripMenuItem.Name = "bookALessonToolStripMenuItem";
            this.bookALessonToolStripMenuItem.Size = new System.Drawing.Size(91, 19);
            this.bookALessonToolStripMenuItem.Text = "Book a lesson";
            // 
            // beginnersToolStripMenuItem
            // 
            this.beginnersToolStripMenuItem.Name = "beginnersToolStripMenuItem";
            this.beginnersToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.beginnersToolStripMenuItem.Text = "Beginners";
            this.beginnersToolStripMenuItem.Click += new System.EventHandler(this.BeginnersToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.advancedToolStripMenuItem.Text = "Advanced";
            this.advancedToolStripMenuItem.Click += new System.EventHandler(this.AdvancedToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.resultsToolStripMenuItem.Text = "Results";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.ResultsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 19);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(462, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form5";
            this.Text = "Navigation";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireASurfBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookALessonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beginnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}