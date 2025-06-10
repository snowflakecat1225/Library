namespace Library
{
    partial class ClassInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassInfo));
            this.ClassInfoDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClassInfoDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassInfoDgv
            // 
            this.ClassInfoDgv.AllowUserToAddRows = false;
            this.ClassInfoDgv.AllowUserToDeleteRows = false;
            this.ClassInfoDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassInfoDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ClassInfoDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.ClassInfoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassInfoDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassInfoDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ClassInfoDgv.Location = new System.Drawing.Point(0, 0);
            this.ClassInfoDgv.MultiSelect = false;
            this.ClassInfoDgv.Name = "ClassInfoDgv";
            this.ClassInfoDgv.ReadOnly = true;
            this.ClassInfoDgv.Size = new System.Drawing.Size(520, 337);
            this.ClassInfoDgv.TabIndex = 0;
            // 
            // ClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(520, 337);
            this.Controls.Add(this.ClassInfoDgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(536, 376);
            this.Name = "ClassInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ClassInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassInfoDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClassInfoDgv;
    }
}