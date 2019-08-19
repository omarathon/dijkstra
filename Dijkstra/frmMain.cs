using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Dijkstra
{
    public partial class frmMain: Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            string nodeName = Interaction.InputBox("Enter Node Name: ", "Add Node");
            if (nodeName != "")
            {
                bool duplicate = false;
                foreach (object node in olvNodes.Objects)
                {
                    if (((clsNode)node).name == nodeName)
                    {
                        duplicate = true;
                    }
                }
                if (!duplicate)
                {
                    olvNodes.AddObject(new clsNode(nodeName));
                }
                else
                {
                    MessageBox.Show("Node already exists!", "Error");
                }
            }
        }

        object[] selectedObjects = new object[2];

        private bool CheckPathExists(object[] selectedObjects)
        {
            foreach (object path in olvPaths.Objects)
            {
                clsNode[] selectedPath = new clsNode[] { (clsNode)selectedObjects[0], (clsNode)selectedObjects[1] };
                if (Enumerable.SequenceEqual(((clsPath)path).GetPath(), selectedObjects))
                {
                    return true;
                }
            }
            return false;
        }

        private void olvNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (olvNodes.SelectedObjects.Count > 0)
            {
                btnRemoveNode.Enabled = true;
                if (olvNodes.SelectedObjects.Count == 1)
                {
                    selectedObjects[0] = olvNodes.SelectedObject;
                    btnAddPath.Enabled = false;
                    txtFrom.Text = ((clsNode)selectedObjects[0]).name;
                }
                else if (olvNodes.SelectedObjects.Count == 2)
                {
                    if (selectedObjects[0] == olvNodes.SelectedObjects[1])
                    {
                        selectedObjects[1] = olvNodes.SelectedObjects[0];
                    }
                    else
                    {
                        selectedObjects[1] = olvNodes.SelectedObjects[1];
                    }
                    txtTo.Text = ((clsNode)selectedObjects[1]).name;
                    if (!CheckPathExists(selectedObjects))
                    {
                        btnAddPath.Enabled = true;
                        if (olvPaths.Items.Count > 0)
                        {
                            btnCalculate.Enabled = true;
                        }
                        else
                        {
                            btnCalculate.Enabled = false;
                        }
                        if (!CheckPathExists(new object[] {selectedObjects[1], selectedObjects[0]}))
                        {
                            chkbBothWays.Enabled = true;
                        }
                        else
                        {
                            chkbBothWays.Checked = false;
                            chkbBothWays.Enabled = false;
                        }
                    }
                    else
                    {
                        btnAddPath.Enabled = false;
                        btnCalculate.Enabled = false;
                        MessageBox.Show("Path already exists!", "Error");
                    }
                }
                else
                {
                    btnAddPath.Enabled = false;
                    btnCalculate.Enabled = false;
                }
            }
            else
            {
                txtFrom.Text = "";
                txtTo.Text = "";
                btnRemoveNode.Enabled = false;
                btnAddPath.Enabled = false;
                btnCalculate.Enabled = false;
            }
        }

        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            foreach (object selectedNode in olvNodes.SelectedObjects)
            {
                olvNodes.RemoveObject(selectedNode);
                List<object> relatedPathObjects = new List<object>();
                foreach (object path in olvPaths.Objects)
                {
                    if ( ((clsPath)path).nodeFrom == (clsNode)selectedNode || ((clsPath)path).nodeTo == (clsNode)selectedNode)
                    {
                        relatedPathObjects.Add(path);
                    }
                }
                olvPaths.RemoveObjects(relatedPathObjects);
            }
            btnAddPath.Enabled = false;
            btnCalculate.Enabled = false;
            btnRemoveNode.Enabled = false;
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            string weight = Interaction.InputBox("Enter Weight: ", "Add Path");
            if (weight != "")
            {
                if (IsDigitsOnly(weight))
                {
                    try
                    {
                        olvPaths.AddObject(new clsPath(
                                                            (clsNode)(selectedObjects[0]),
                                                            (clsNode)(selectedObjects[1]),
                                                            Convert.ToInt32(weight)
                                                            ));
                        if (chkbBothWays.Checked)
                        {
                            olvPaths.AddObject(new clsPath(
                                        (clsNode)(selectedObjects[1]),
                                        (clsNode)(selectedObjects[0]),
                                        Convert.ToInt32(weight)
                                        ));
                        }
                    }
                    catch (System.OverflowException)
                    {
                        MessageBox.Show("The weight is too large. Maximum weight is 2,147,483,646!", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("The weight must be a positive integer.", "Error");
                }
            }
            chkbBothWays.Checked = false;
            chkbBothWays.Enabled = false;
            btnAddPath.Enabled = false;
            btnCalculate.Enabled = false;
        }

        private void olvPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (olvPaths.SelectedObjects.Count > 0)
            {
                btnRemovePath.Enabled = true;
            }
            else
            {
                btnRemovePath.Enabled = false;
            }
        }

        private void btnRemovePath_Click(object sender, EventArgs e)
        {
            foreach (object path in olvPaths.SelectedObjects)
            {
                olvPaths.RemoveObject(path);
            }
            btnRemovePath.Enabled = false;
        }

        private void btnViewAdjMatrix_Click(object sender, EventArgs e)
        {
            frmViewAdjMatrix frm = new frmViewAdjMatrix();
            frm.MakeAdjMatrix(olvNodes.Objects.Cast<object>().ToArray(), olvPaths.Objects.Cast<object>().ToArray());
            frm.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            foreach (clsNode node in olvNodes.Objects.Cast<clsNode>().ToArray())
            {
                node.Reset();
            }
            List<clsNode> foundNodes = new List<clsNode>();
            foreach (object path in olvPaths.Objects)
            {
                clsNode from = ((clsPath)path).nodeFrom;
                clsNode to = ((clsPath)path).nodeTo;
                if (!(foundNodes.Contains(from)))
                {
                    foundNodes.Add(from);
                }
                if (!(foundNodes.Contains(to)))
                {
                    foundNodes.Add(to);
                }
            }
            if (foundNodes.Count != olvNodes.Objects.Cast<object>().Count())
            {
                MessageBox.Show("There are nodes that aren't connected, please remove them.", "Error");
            }
            else
            {
                ApplyDijkstra(olvNodes.Objects.Cast<clsNode>().ToArray(), olvPaths.Objects.Cast<clsPath>().ToArray());
            }
            btnCalculate.Enabled = false;
        }

        private void ApplyDijkstra(clsNode[] nodes, clsPath[] paths)
        {
            clsNode end = (clsNode)selectedObjects[1];
            clsNode start = (clsNode)selectedObjects[0];
            clsNode currentNode = start;
            currentNode.workingValue = 0;
            currentNode.orderOfLabelling = 1;
            int labelCount = 2;
            int nodeCount = nodes.Count();
            bool loop = true;
            while (loop)
            {
                foreach (clsPath path in paths)
                {
                    if (path.nodeFrom == currentNode)
                    {
                        if (path.nodeTo.workingValue > (currentNode.workingValue + path.pathWeight))
                        {
                            path.nodeTo.workingValue = currentNode.workingValue + path.pathWeight;
                        }
                    }
                }
                int minWorkingValue = int.MaxValue;
                clsNode nextNode = currentNode;
                foreach (clsNode node in nodes)
                {
                    if (node.workingValue < minWorkingValue && node.orderOfLabelling == null)
                    {
                        minWorkingValue = node.workingValue;
                        nextNode = node;
                    }
                }
                currentNode = nextNode;
                nextNode.orderOfLabelling = labelCount;
                if (labelCount == nodeCount)
                {
                    loop = false;
                }
                labelCount++;
            }
            GetPath(nodes, paths, start, end);
        }

        private void GetPath(clsNode[] nodes, clsPath[] paths, clsNode start, clsNode end)
        {
            clsNode currentNode = end;
            bool loop = true;
            List<clsNode> finalPath = new List<clsNode>();
            finalPath.Add(currentNode);
            int totalWeight = 0;

            while (loop)
            {
                List<clsPath> relatedPaths = new List<clsPath>();
                bool found = false;
                int pathCount = 0;
                while (!found)
                {
                    clsPath currentPath = paths[pathCount];
                    if (currentPath.nodeTo == currentNode)
                    {
                        if (currentNode.workingValue - currentPath.pathWeight == currentPath.nodeFrom.workingValue)
                        {
                            finalPath.Add(currentPath.nodeFrom);
                            totalWeight += currentPath.pathWeight;
                            currentNode = currentPath.nodeFrom;
                            found = true;
                        }
                        else
                        {
                            pathCount++;
                        }
                    }
                    else
                    {
                        pathCount++;
                    }
                }
                if (currentNode == start)
                {
                    loop = false;
                }
            }
            finalPath.Reverse();
            string[] finalPathStrings = new string[finalPath.Count];
            for (int n = 0; n < finalPath.Count; n++)
            {
                finalPathStrings[n] = finalPath[n].name;
            }
            DialogResult viewAnalysis = MessageBox.Show("Dijkstra Completed.\r\nFastest Route: " + string.Join(" -> ", finalPathStrings) + "\r\nPath Weight: " + totalWeight.ToString() +
                "\r\n\r\nView Analysis?", "Success", MessageBoxButtons.YesNo);
            if (viewAnalysis == DialogResult.Yes)
            {
                frmAnalysis frm = new frmAnalysis();
                frm.SetNodes(nodes);
                frm.Show();
            }
        }
    }
}
