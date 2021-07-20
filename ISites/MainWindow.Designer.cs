
namespace ISites
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCountries = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemIssuers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemOwners = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPoses = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBooks});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemBooks
            // 
            this.toolStripMenuItemBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCountries,
            this.toolStripMenuItemIssuers,
            this.toolStripMenuItemProducts,
            this.toolStripSeparator1,
            this.toolStripMenuItemOwners,
            this.toolStripSeparator2,
            this.toolStripMenuItemPoses});
            this.toolStripMenuItemBooks.Name = "toolStripMenuItemBooks";
            this.toolStripMenuItemBooks.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItemBooks.Text = "Справочники";
            // 
            // toolStripMenuItemCountries
            // 
            this.toolStripMenuItemCountries.Name = "toolStripMenuItemCountries";
            this.toolStripMenuItemCountries.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemCountries.Text = "Страны";
            this.toolStripMenuItemCountries.Click += new System.EventHandler(this.toolStripMenuItemCountries_Click);
            // 
            // toolStripMenuItemIssuers
            // 
            this.toolStripMenuItemIssuers.Name = "toolStripMenuItemIssuers";
            this.toolStripMenuItemIssuers.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemIssuers.Text = "Эмитенты";
            this.toolStripMenuItemIssuers.Click += new System.EventHandler(this.toolStripMenuItemIssuers_Click);
            // 
            // toolStripMenuItemProducts
            // 
            this.toolStripMenuItemProducts.Name = "toolStripMenuItemProducts";
            this.toolStripMenuItemProducts.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemProducts.Text = "Продукты";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // toolStripMenuItemOwners
            // 
            this.toolStripMenuItemOwners.Name = "toolStripMenuItemOwners";
            this.toolStripMenuItemOwners.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemOwners.Text = "Владельцы";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // toolStripMenuItemPoses
            // 
            this.toolStripMenuItemPoses.Name = "toolStripMenuItemPoses";
            this.toolStripMenuItemPoses.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItemPoses.Text = "Станции";
            this.toolStripMenuItemPoses.Click += new System.EventHandler(this.toolStripMenuItemPoses_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 598);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBooks;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCountries;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIssuers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProducts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOwners;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPoses;
    }
}

