namespace QuanLy_DoAn_TNTH
{
    partial class US_dsGVHD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_GVHD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GVHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_GVHD
            // 
            this.dataGridView_GVHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GVHD.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_GVHD.Name = "dataGridView_GVHD";
            this.dataGridView_GVHD.Size = new System.Drawing.Size(620, 483);
            this.dataGridView_GVHD.TabIndex = 0;
            // 
            // US_dsGVHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_GVHD);
            this.Name = "US_dsGVHD";
            this.Size = new System.Drawing.Size(626, 489);
            this.Load += new System.EventHandler(this.US_dsGVHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GVHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_GVHD;
    }
}
