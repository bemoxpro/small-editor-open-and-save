using System;
using System.Windows.Forms;
using System.IO;

namespace test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
                
                if(save.ShowDialog() == DialogResult.OK)
                {
                    save.Filter = "Text Files | *.txt";
                    save.DefaultExt = "txt";
                    File.WriteAllText(save.FileName, text.Text);
                }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

                if(openFile.ShowDialog() == DialogResult.OK)
                text.Text = File.ReadAllText(openFile.FileName);

        }
    }
}
