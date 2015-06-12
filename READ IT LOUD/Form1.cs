using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace READ_IT_LOUD
{
    public partial class Form1 : Form
    {
        public bool interrupt = false;
        public System.Speech.Synthesis.SpeechSynthesizer ss = new System.Speech.Synthesis.SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Browsebutton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.ToString() == "OK")
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void readbutton_Click(object sender, EventArgs e)
        {
            string filepath = textBox1.Text;
            
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string line = string.Empty;
            while((line= sw.ReadLine()) != null)
            {
               // HTMLParser htmlparserobj = new HTMLParser();
                //string body = htmlparserobj.HTMLParserFucnion("www.google.co.in/search?q=what+is+web+scaper&oq=what+is+web+scaper&aqs=chrome..69i57.5455j0j7&sourceid=chrome&es_sm=122&ie=UTF-8");
                ss.Speak(line);
                //ss.Speak(body);
                //ss.Pause();
                //MessageBox.Show("continue");
                //ss.SelectVoice("sanjeev gupta");
               // ss.Resume();
                //spausebutton.BeginInvoke(pausebutton_Click(object se,EventArgs e));

            }
        }

        private void pausebutton_Click(object sender, EventArgs e)
        {
            interrupt = true;

           // ss.Pause();
            //MessageBox.Show("inerrupt");
            
        }
        public void check()
        {
            
        }
         
        private void cancelbuton_click()
        {
            Application.Exit();
        }
    }
}
