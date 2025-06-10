namespace Library
{
    partial class LibraristsInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraristsInfo));
            this.LibraristsDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LibraristsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // LibraristsDgv
            // 
            this.LibraristsDgv.AllowUserToAddRows = false;
            this.LibraristsDgv.AllowUserToDeleteRows = false;
            this.LibraristsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LibraristsDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.LibraristsDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.LibraristsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibraristsDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibraristsDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.LibraristsDgv.Location = new System.Drawing.Point(0, 0);
            this.LibraristsDgv.MultiSelect = false;
            this.LibraristsDgv.Name = "LibraristsDgv";
            this.LibraristsDgv.ReadOnly = true;
            this.LibraristsDgv.Size = new System.Drawing.Size(514, 275);
            this.LibraristsDgv.TabIndex = 0;
            // 
            // LibraristsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(514, 275);
            this.Controls.Add(this.LibraristsDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 314);
            this.Name = "LibraristsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Библиотекари";
            this.Load += new System.EventHandler(this.LibraristsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibraristsDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LibraristsDgv;
    }
}