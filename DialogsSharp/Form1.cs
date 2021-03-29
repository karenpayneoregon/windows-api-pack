using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DialogCustomLibrary;
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

            var response = MessageBoxEx.ShowCenterOnParent(
                "Hello", 
                "Would you like to continue?", 
                MessageBoxButtons.YesNo,this);

            if (response == DialogResult.Yes)
            {
                Console.WriteLine("Yes");
            }else if (response == DialogResult.No)
            {
                Console.WriteLine("No");
            }
        }
    }
}
