namespace Dijkstra
{
    partial class frmViewAdjMatrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAdjMatrix));
            this.lvwAdjMatrix = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvwAdjMatrix
            // 
            this.lvwAdjMatrix.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwAdjMatrix.Location = new System.Drawing.Point(13, 13);
            this.lvwAdjMatrix.Name = "lvwAdjMatrix";
            this.lvwAdjMatrix.Size = new System.Drawing.Size(173, 28);
            this.lvwAdjMatrix.TabIndex = 0;
            this.lvwAdjMatrix.UseCompatibleStateImageBehavior = false;
            this.lvwAdjMatrix.View = System.Windows.Forms.View.Details;
            // 
            // frmViewAdjMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(198, 50);
            this.Controls.Add(this.lvwAdjMatrix);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewAdjMatrix";
            this.Text = "Distance Matrix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwAdjMatrix;
    }
}