using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testConvertOrPresentJson
{
    public partial class EntirePassage : Form
    {
        public EntirePassage(string text)
        {
            InitializeComponent();
            entirePassageBox.Text = text;
        }
    }
}
