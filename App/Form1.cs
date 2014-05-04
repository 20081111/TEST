using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Farmland.Validation;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string s=null;

            Argument.Validate(s != null, "字符串", "字符串不能为空");
            //Argument.ThrowIfNull<string>(s, "字符串");
        }
    }
}
