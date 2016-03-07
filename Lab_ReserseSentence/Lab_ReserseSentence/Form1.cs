using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_ReserseSentence
{
    public partial class ReverseSentence : Form
    {
        public ReverseSentence()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string input = txbInput.Text;
            StringReverter reverter = new StringReverter(input);
            lblResult.Text = reverter.RevertContent();
        }
        

           

    }
}
