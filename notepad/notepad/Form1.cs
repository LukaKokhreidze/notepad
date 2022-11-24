using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult OpenFile = openFileDialog.ShowDialog();
            if (OpenFile == DialogResult.OK)
            {
                try
                {
                    listBox1.Text = File.ReadAllText(openFileDialog.FileName);
                    Text = openFileDialog.SafeFileName + " - " + Application.ProductName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "DefaultOutputName.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                foreach (var item in listBox1.Items)
                {
                    writer.WriteLine(listBox1.Items.ToString());
                }
                writer.Dispose();
                writer.Close();

            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
