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
    public partial class resultShow : Form
    {
        
        public resultShow()
        {
            InitializeComponent();
        }
        public resultShow(string result)
        {
            InitializeComponent();
            txtResult.Text = result;
        }

    }
}
