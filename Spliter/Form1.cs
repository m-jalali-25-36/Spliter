using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spliter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource.Text) || string.IsNullOrEmpty(txtStart.Text) || string.IsNullOrEmpty(txtEnd.Text) || string.IsNullOrEmpty(txtFormat.Text))
            {
                MessageBox.Show("All fields must be set. Please check which elephant is empty and try again after filling it.", "Not Convert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            List<string> starts = txtStart.Text.Split(',').ToList();
            List<string> ends = txtEnd.Text.Split(',').ToList();
            if (starts.Count != ends.Count)
            {
                MessageBox.Show("The number of start and end separators must be equal and even.", "Not Convert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (starts.Count < ends.Count)
                    txtStart.Focus();
                else
                    txtEnd.Focus();
            }
            var split = Spliter(txtSource.Text, starts, ends);
            string result = "";
            string format = txtFormat.Text;
            format = format.Replace("\\n", Environment.NewLine);
            format = format.Replace("\\t", "\t");
            int indexFormat = 0;
            for (int i = 0; i < split.Count; i++)
            {
                string temp = format.Replace("#i#", indexFormat.ToString());
                temp = temp.Replace("#I#", (indexFormat+1).ToString());
                temp = temp.Replace("#1#", split[i]);
                temp = temp.Replace("#i1#", i.ToString());
                temp = temp.Replace("#I1#", (i+1).ToString());
                int j = 2;
                while (temp.Contains($"#{j}#"))
                {
                    string text = ++i < split.Count ? split[i] : "";
                    temp = temp.Replace($"#{j}#", text);
                    temp = temp.Replace($"#i{j}#", i.ToString());
                    temp = temp.Replace($"#I{j}#", (i+1).ToString());
                    j++;
                }
                result += temp;
                indexFormat++;
            }
            resultShow showForm = new resultShow(result);
            showForm.Show();
        }

        public List<string> Spliter(string source, string start, string end)
        {
            List<string> result = new List<string>();
            int firstIndex = 0, lastIndex = 0;
            while ((firstIndex = source.IndexOf(start, lastIndex)) != -1)
            {
                firstIndex += start.Length;
                if ((lastIndex = source.IndexOf(end, firstIndex)) != -1)
                {
                    result.Add(source.Substring(firstIndex, lastIndex - firstIndex));
                    lastIndex += end.Length;
                }
                else
                    lastIndex = firstIndex;
            }
            return result;
        }

        public List<string> Spliter(string source, List<string> start, List<string> end)
        {
            List<string> result = new List<string>();
            bool isFound = true;
            int firstIndex = 0, lastIndex = 0, spliterIndex = 0;
            while(true)
            {
                isFound = false;
                for (int i = 0; i < start.Count; i++)
                {
                    int n = source.IndexOf(start[i], lastIndex);
                    if (!isFound && n != -1)
                    {
                        isFound = true;
                        firstIndex = n;
                        spliterIndex = i;
                    }
                    else if (n != -1 && n < firstIndex)
                    {
                        firstIndex = n;
                        spliterIndex = i;
                    }
                }
                if (!isFound)
                    break;
                firstIndex += start[spliterIndex].Length;
                if ((lastIndex = source.IndexOf(end[spliterIndex], firstIndex)) != -1)
                {
                    result.Add(source.Substring(firstIndex, lastIndex - firstIndex));
                    lastIndex += end[spliterIndex].Length;
                }
                else
                    lastIndex = firstIndex;
            }
            return result;
        }

    }
}