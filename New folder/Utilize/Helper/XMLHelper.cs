using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Utilize.Helper
{
    public static class XMLHelper
    {
        private const string RangeKey = "RANGE";
        public static bool RangeToXML(this TreeView treeView, string Component)
        {
            try
            {
                if (System.IO.File.Exists(Environment.CurrentDirectory + @"\Range.xml") == false)
                    System.IO.File.Create(Environment.CurrentDirectory + @"\Range.xml").Close();
                var dataTable = new DataTable(RangeKey);
                dataTable.Columns.Add("ComName");
                dataTable.Columns.Add("NodeText");
                dataTable.Columns.Add("NodeTag");
                try
                {
                    dataTable.ReadXml(Environment.CurrentDirectory + @"\Range.xml");
                }
                catch
                {

                }
                var rows = dataTable.Rows.Cast<DataRow>().Where(row => row["ComName"].Equals(Component)).ToArray();
                foreach (var row in rows)
                {
                    dataTable.Rows.Remove(row);
                }
                foreach (var node in treeView.Nodes.Cast<TreeNode>())
                {
                    dataTable.Rows.Add(new[] { Component, node.Text, node.Tag });
                }
                dataTable.WriteXml(Environment.CurrentDirectory + @"\Range.xml");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool XMLToRange(this TreeView treeView, string Component)
        {
            try
            {
                var dataTable = new DataTable(RangeKey);

                dataTable.Columns.Add("ComName");
                dataTable.Columns.Add("NodeText");
                dataTable.Columns.Add("NodeTag");
                dataTable.ReadXml(Environment.CurrentDirectory + @"\Range.xml");
                dataTable.Rows.Cast<DataRow>().Where(item => item["ComName"].Equals(Component)).ForEach(
                    item =>
                    treeView.Nodes.Add(new TreeNode { Text = item["NodeText"].ToString(), Tag = item["NodeTag"].ToString() }));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
