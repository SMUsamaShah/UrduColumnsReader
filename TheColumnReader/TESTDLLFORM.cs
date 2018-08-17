using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JangParser;

namespace TheColumnReader
{
    public partial class TESTDLLFORM : Form
    {
        public TESTDLLFORM()
        {
            InitializeComponent();
            JangColumns jc = new JangColumns();
            jc.ExtractTable("http://www.jang.com.pk/jang/dec2008-daily/29-12-2008/editorial.htm");
        }
    }
}
