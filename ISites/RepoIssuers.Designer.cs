
namespace ISites
{
    partial class RepoIssuers
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
            this.dataGridViewIssuers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIssuers
            // 
            this.dataGridViewIssuers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssuers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIssuers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewIssuers.Name = "dataGridViewIssuers";
            this.dataGridViewIssuers.RowTemplate.Height = 25;
            this.dataGridViewIssuers.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewIssuers.TabIndex = 1;
            // 
            // RepoIssuers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewIssuers);
            this.Name = "RepoIssuers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник Эмитентов";
            this.Load += new System.EventHandler(this.RepoIssuers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIssuers;
    }
}