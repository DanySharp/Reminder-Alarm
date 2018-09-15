using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reminder_Alarm
{
   
    public partial class ringfrm : Form
    {
        static mainfrm form;
        string _message;
        public ringfrm(mainfrm f)
        {
            InitializeComponent();
            form =f;
        }
        public void Message(string message)
        {
            _message = message;
        }

        private void ringfrm_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
            form.resume();
        }

        private void btnsnooze_Click(object sender, EventArgs e)
        {
            form.snooze();
            this.Close();
        }

        private void ringfrm_Shown(object sender, EventArgs e)
        {
            richTextBox1.Text = _message;
        }
    }
}
