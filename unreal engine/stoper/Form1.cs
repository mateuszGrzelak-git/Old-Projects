using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoper
{
    public partial class Form1 : Form
    {
        public EventHandler b()
        {
            return true
        }
        public Form1()
        {
            Button button1 = new Button();
            button1.DialogResult = DialogResult.OK;
            Controls.Add(button1);
            button1.Text="Stop";
            button1.Click += b();
            InitializeComponent();
        }

    }
}
