using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class frmViewAdjMatrix : Form
    {
        public frmViewAdjMatrix()
        {
            InitializeComponent();
        }

        public void MakeAdjMatrix(object[] nodes, object[] paths)
        {
            lvwAdjMatrix.Clear();
            lvwAdjMatrix.Width = 0;
            lvwAdjMatrix.Columns.Add("");
            SetupFields(nodes);
            FillWeights(nodes, paths);
            lvwAdjMatrix.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            int headerSize = 0;
            foreach  (ColumnHeader header in lvwAdjMatrix.Columns)
            {
                headerSize += header.Width;
            }
            lvwAdjMatrix.Width = headerSize + 7;
            int height = 0;
            for (int n = 0; n < lvwAdjMatrix.Items.Count; n++)
            {
                height += lvwAdjMatrix.GetItemRect(n).Height;
            }
            lvwAdjMatrix.Height = height + 7;
        }

        private void FillWeights(object[] nodes, object[] paths)
        {
            foreach (object path in paths)
            {
                clsNode from = ((clsPath)path).nodeFrom;
                clsNode to = ((clsPath)path).nodeTo;
                int colNo = Array.IndexOf(nodes.Cast<clsNode>().ToArray(), from);
                int rowNo = Array.IndexOf(nodes.Cast<clsNode>().ToArray(), to);
                lvwAdjMatrix.Items[rowNo + 1].SubItems[colNo + 1].Text = ((clsPath)path).pathWeight.ToString();
            }
        }

        private void SetupFields(object[] nodes)
        {
            lvwAdjMatrix.Items.Add("");
            lvwAdjMatrix.Items[0].BackColor = Color.LightGray;
            foreach (object node in nodes)
            {
                string nodeName = ((clsNode)node).name;
                lvwAdjMatrix.Columns.Add("");
                lvwAdjMatrix.Items[0].SubItems.Add(nodeName);
                lvwAdjMatrix.Items.Add(nodeName);
                ListViewItem currentItem = lvwAdjMatrix.Items[lvwAdjMatrix.Items.Count - 1];
                currentItem.UseItemStyleForSubItems = false;
                currentItem.BackColor = Color.LightGray;
            }

            for (int n = 1; n < lvwAdjMatrix.Items.Count; n++)
            {
                for (int x = 0; x < lvwAdjMatrix.Columns.Count; x++)
                {
                    lvwAdjMatrix.Items[n].SubItems.Add(" – ");
                }
            }
        }
    }
}
