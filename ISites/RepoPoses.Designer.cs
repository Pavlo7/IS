
namespace ISites
{
    partial class RepoPoses
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewPoses = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewPosIssuer = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewIssuerProduct = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoses)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosIssuer)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuerProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 594);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1148, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 570);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridViewPoses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(215, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 570);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewPoses
            // 
            this.dataGridViewPoses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPoses.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPoses.MultiSelect = false;
            this.dataGridViewPoses.Name = "dataGridViewPoses";
            this.dataGridViewPoses.ReadOnly = true;
            this.dataGridViewPoses.RowTemplate.Height = 25;
            this.dataGridViewPoses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPoses.Size = new System.Drawing.Size(600, 568);
            this.dataGridViewPoses.TabIndex = 0;
            this.dataGridViewPoses.SelectionChanged += new System.EventHandler(this.dataGridViewPoses_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridViewPosIssuer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(817, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 220);
            this.panel3.TabIndex = 4;
            // 
            // dataGridViewPosIssuer
            // 
            this.dataGridViewPosIssuer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosIssuer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPosIssuer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPosIssuer.Name = "dataGridViewPosIssuer";
            this.dataGridViewPosIssuer.RowTemplate.Height = 25;
            this.dataGridViewPosIssuer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPosIssuer.Size = new System.Drawing.Size(329, 218);
            this.dataGridViewPosIssuer.TabIndex = 1;
            this.dataGridViewPosIssuer.SelectionChanged += new System.EventHandler(this.dataGridViewPosIssuer_SelectionChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridViewIssuerProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(817, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 350);
            this.panel4.TabIndex = 5;
            // 
            // dataGridViewIssuerProduct
            // 
            this.dataGridViewIssuerProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssuerProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIssuerProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewIssuerProduct.Name = "dataGridViewIssuerProduct";
            this.dataGridViewIssuerProduct.RowTemplate.Height = 25;
            this.dataGridViewIssuerProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIssuerProduct.Size = new System.Drawing.Size(329, 348);
            this.dataGridViewIssuerProduct.TabIndex = 2;
            // 
            // RepoPoses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 616);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RepoPoses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник Станций";
            this.Load += new System.EventHandler(this.RepoPoses_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoses)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosIssuer)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuerProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewPoses;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewPosIssuer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewIssuerProduct;
    }
}