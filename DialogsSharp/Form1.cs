using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DialogsSharp.Classes;

namespace DialogsSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CenterOnFormButton_Click(object sender, EventArgs e)
        {
            DialogHelpers.CenterOnParent();
        }
    }
}
