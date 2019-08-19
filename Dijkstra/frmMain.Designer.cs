namespace Dijkstra
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.olvPaths = new BrightIdeasSoftware.FastObjectListView();
            this.from = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.to = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.weight = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvNodes = new BrightIdeasSoftware.FastObjectListView();
            this.node = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnAddNode = new System.Windows.Forms.Button();
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.Nodes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewAdjMatrix = new System.Windows.Forms.Button();
            this.chkbBothWays = new System.Windows.Forms.CheckBox();
            this.btnRemovePath = new System.Windows.Forms.Button();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.olvPaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvNodes)).BeginInit();
            this.Nodes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // olvPaths
            // 
            this.olvPaths.AllColumns.Add(this.from);
            this.olvPaths.AllColumns.Add(this.to);
            this.olvPaths.AllColumns.Add(this.weight);
            this.olvPaths.CellEditUseWholeCell = false;
            this.olvPaths.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.from,
            this.to,
            this.weight});
            this.olvPaths.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPaths.FullRowSelect = true;
            this.olvPaths.Location = new System.Drawing.Point(6, 19);
            this.olvPaths.Name = "olvPaths";
            this.olvPaths.ShowGroups = false;
            this.olvPaths.Size = new System.Drawing.Size(304, 494);
            this.olvPaths.TabIndex = 0;
            this.olvPaths.UseCompatibleStateImageBehavior = false;
            this.olvPaths.View = System.Windows.Forms.View.Details;
            this.olvPaths.VirtualMode = true;
            this.olvPaths.SelectedIndexChanged += new System.EventHandler(this.olvPaths_SelectedIndexChanged);
            // 
            // from
            // 
            this.from.AspectName = "fromNode";
            this.from.Text = "From Node";
            this.from.Width = 100;
            // 
            // to
            // 
            this.to.AspectName = "toNode";
            this.to.Text = "To Node";
            this.to.Width = 100;
            // 
            // weight
            // 
            this.weight.AspectName = "pathWeight";
            this.weight.Text = "Path Weight";
            this.weight.Width = 100;
            // 
            // olvNodes
            // 
            this.olvNodes.AllColumns.Add(this.node);
            this.olvNodes.CellEditUseWholeCell = false;
            this.olvNodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.node});
            this.olvNodes.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvNodes.FullRowSelect = true;
            this.olvNodes.Location = new System.Drawing.Point(6, 19);
            this.olvNodes.Name = "olvNodes";
            this.olvNodes.ShowGroups = false;
            this.olvNodes.Size = new System.Drawing.Size(104, 514);
            this.olvNodes.TabIndex = 0;
            this.olvNodes.UseCompatibleStateImageBehavior = false;
            this.olvNodes.View = System.Windows.Forms.View.Details;
            this.olvNodes.VirtualMode = true;
            this.olvNodes.SelectedIndexChanged += new System.EventHandler(this.olvNodes_SelectedIndexChanged);
            // 
            // node
            // 
            this.node.AspectName = "name";
            this.node.Text = "Node";
            this.node.Width = 100;
            // 
            // btnAddNode
            // 
            this.btnAddNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNode.Location = new System.Drawing.Point(6, 539);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(37, 29);
            this.btnAddNode.TabIndex = 1;
            this.btnAddNode.Text = "+";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.Enabled = false;
            this.btnRemoveNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveNode.Location = new System.Drawing.Point(73, 539);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(37, 29);
            this.btnRemoveNode.TabIndex = 2;
            this.btnRemoveNode.Text = "-";
            this.btnRemoveNode.UseVisualStyleBackColor = true;
            this.btnRemoveNode.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // Nodes
            // 
            this.Nodes.Controls.Add(this.olvNodes);
            this.Nodes.Controls.Add(this.btnRemoveNode);
            this.Nodes.Controls.Add(this.btnAddNode);
            this.Nodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nodes.Location = new System.Drawing.Point(12, 13);
            this.Nodes.Name = "Nodes";
            this.Nodes.Size = new System.Drawing.Size(116, 574);
            this.Nodes.TabIndex = 3;
            this.Nodes.TabStop = false;
            this.Nodes.Text = "Nodes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewAdjMatrix);
            this.groupBox1.Controls.Add(this.chkbBothWays);
            this.groupBox1.Controls.Add(this.btnRemovePath);
            this.groupBox1.Controls.Add(this.btnAddPath);
            this.groupBox1.Controls.Add(this.olvPaths);
            this.groupBox1.Location = new System.Drawing.Point(135, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 519);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paths";
            // 
            // btnViewAdjMatrix
            // 
            this.btnViewAdjMatrix.Location = new System.Drawing.Point(316, 467);
            this.btnViewAdjMatrix.Name = "btnViewAdjMatrix";
            this.btnViewAdjMatrix.Size = new System.Drawing.Size(106, 46);
            this.btnViewAdjMatrix.TabIndex = 6;
            this.btnViewAdjMatrix.Text = "View Distance Matrix";
            this.btnViewAdjMatrix.UseVisualStyleBackColor = true;
            this.btnViewAdjMatrix.Click += new System.EventHandler(this.btnViewAdjMatrix_Click);
            // 
            // chkbBothWays
            // 
            this.chkbBothWays.AutoSize = true;
            this.chkbBothWays.Enabled = false;
            this.chkbBothWays.Location = new System.Drawing.Point(344, 48);
            this.chkbBothWays.Name = "chkbBothWays";
            this.chkbBothWays.Size = new System.Drawing.Size(78, 17);
            this.chkbBothWays.TabIndex = 2;
            this.chkbBothWays.Text = "Both Ways";
            this.chkbBothWays.UseVisualStyleBackColor = true;
            // 
            // btnRemovePath
            // 
            this.btnRemovePath.Enabled = false;
            this.btnRemovePath.Location = new System.Drawing.Point(316, 72);
            this.btnRemovePath.Name = "btnRemovePath";
            this.btnRemovePath.Size = new System.Drawing.Size(106, 23);
            this.btnRemovePath.TabIndex = 1;
            this.btnRemovePath.Text = "Remove Path";
            this.btnRemovePath.UseVisualStyleBackColor = true;
            this.btnRemovePath.Click += new System.EventHandler(this.btnRemovePath_Click);
            // 
            // btnAddPath
            // 
            this.btnAddPath.Enabled = false;
            this.btnAddPath.Location = new System.Drawing.Point(317, 19);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(105, 23);
            this.btnAddPath.TabIndex = 1;
            this.btnAddPath.Text = "Add Path";
            this.btnAddPath.UseVisualStyleBackColor = true;
            this.btnAddPath.Click += new System.EventHandler(this.btnAddPath_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(451, 538);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 49);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Apply Dijkstra";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(45, 17);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(117, 20);
            this.txtFrom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "To:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(197, 19);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(108, 20);
            this.txtTo.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFrom);
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(134, 538);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 49);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 593);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Nodes);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Dijkstra\'s Algorithm - Omar Tanner";
            ((System.ComponentModel.ISupportInitialize)(this.olvPaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvNodes)).EndInit();
            this.Nodes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView olvPaths;
        private BrightIdeasSoftware.OLVColumn from;
        private BrightIdeasSoftware.OLVColumn to;
        private BrightIdeasSoftware.OLVColumn weight;
        private BrightIdeasSoftware.FastObjectListView olvNodes;
        private BrightIdeasSoftware.OLVColumn node;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Button btnRemoveNode;
        private System.Windows.Forms.GroupBox Nodes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemovePath;
        private System.Windows.Forms.Button btnAddPath;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkbBothWays;
        private System.Windows.Forms.Button btnViewAdjMatrix;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

