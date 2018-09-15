using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reminder_Alarm
{
    public partial class mainfrm : Form
    {
        PersianCalendar pc = new PersianCalendar();
        DateTime Dtime = new DateTime();
        string selectTime;
        string selectsnooz;
        string selectring;
        string selectmsg;

        bool alarmset = false;
        bool snoozeset = false;

        string wavPath = @"G:\11\";
        string snooztime;
        SoundPlayer sounplay;
        ringfrm ringclass;

        public mainfrm()
        {
            InitializeComponent();
            sounplay = new SoundPlayer();
            ringclass = new ringfrm(this);
        }
        private void updatedata()
        {
            for (int i = 0; i <= 12; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            for(int i=0; i <=59;i++)
            {
                if (i<10)
                {
                    comboBox2.Items.Add(0+i.ToString());
                }
                else
                {
                    comboBox2.Items.Add(i.ToString());
                }
               
            }
            comboBox3.Items.Add("AM");
            comboBox3.Items.Add("PM");

            comboBox4.Items.Add("1");
            comboBox4.Items.Add("5");
            comboBox4.Items.Add("10");

            string[] wavfile = Directory.GetFiles(wavPath,"*.wav");
            foreach (string item in wavfile)
            {
                string wavname = item.Replace(wavPath,string.Empty);
                wavname = wavname.Replace(".wav",string.Empty);
                listBox1.Items.Add(wavname);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mainfrm_Load(object sender, EventArgs e)
        {
            Dtime = DateTime.Now;
            textBox2.Text = pc.GetYear(Dtime) + "/" + pc.GetMonth(Dtime) + "/" + pc.GetDayOfMonth(Dtime);
            textBox1.Text = pc.GetYear(Dtime) + "/" + pc.GetMonth(Dtime) + "/" + pc.GetDayOfMonth(Dtime);
            textBox3.Text = DateTime.Now.ToString("h:mm tt");
            updatedata();
            txton();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dtime = DateTime.Now;
            textBox2.Text = pc.GetYear(Dtime) + "/" + pc.GetMonth(Dtime) + "/" + pc.GetDayOfMonth(Dtime);
            textBox3.Text = DateTime.Now.ToString("h:mm tt");

            if (alarmset)
            {
                if (textBox3.Text == selectTime && textBox1.Text == pc.GetYear(Dtime) + "/" + pc.GetMonth(Dtime) + "/" + pc.GetDayOfMonth(Dtime)) 
                {
                    alarmset = false;
                    sounplay.Play();
                    ringclass.ShowDialog();

                }
                
            }
            else if(snoozeset)
            {
                if(textBox3.Text==snooztime)
                {
                    snoozeset = false;
                    sounplay.Play();
                    ringclass.ShowDialog();
                }
            }
        }
        public void txton()
        {
            comboBox1.Text = "12";
            comboBox2.Text = "30";
            comboBox3.Text = "AM";
        }

        private void btnalarm_Click(object sender, EventArgs e)
        {
            selectTime = comboBox1.Text + ":" + comboBox2.Text + " " + comboBox3.Text;
            selectsnooz = comboBox4.Text;
            selectring = listBox1.Text;
            selectmsg = richTextBox1.Text;

            sounplay.SoundLocation = wavPath + selectring + ".wav";

            ringclass.Message(selectmsg);

            groupBox1.Enabled = false;
            alarmset = true;

        }

        public void resume()
        {
            try
            {
                sounplay.Stop();
            }
            catch 
            {

                
            }
            groupBox1.Enabled = true;
        }

        public void snooze()
        {
            try
            {
                sounplay.Stop();
            }
            catch 
            {
             }
            DateTime Dtime = DateTime.Now;
            TimeSpan span = new TimeSpan(0,Convert.ToInt32(selectsnooz),0);
            snooztime = Dtime.Add(span).ToString("h:mm tt");
            snoozeset = true;

        }
    }
}
