namespace QuanLy_DoAn_TNTH
{
    partial class US_dsHoaChat
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
            this.dataGridView_HoaChat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaChat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_HoaChat
            // 
            this.dataGridView_HoaChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HoaChat.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_HoaChat.Name = "dataGridView_HoaChat";
            this.dataGridView_HoaChat.Size = new System.Drawing.Size(620, 483);
            this.dataGridView_HoaChat.TabIndex = 0;
            // 
            // US_dsHoaChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_HoaChat);
            this.Name = "US_dsHoaChat";
            this.Size = new System.Drawing.Size(626, 489);
            this.Load += new System.EventHandler(this.US_dsHoaChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_HoaChat;
    }
}
