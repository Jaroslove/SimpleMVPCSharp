using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form, IForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Namee { get { return button1.Text; } }
        public event EventHandler buttonClick;

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += ButtonClick;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            //if(buttonClick != null) { buttonClick(sender, e); }
            buttonClick?.Invoke(sender, e);
        }
    }
}
