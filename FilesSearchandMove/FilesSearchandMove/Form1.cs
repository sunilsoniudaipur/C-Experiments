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
namespace FilesSearchandMove
{
    public partial class Form1 : Form
    {
        string destinationPath;
        public Form1()
        {
            InitializeComponent();
        }

        string selectedPath = "";
        string[] FileNameArray;
        string[] SourceFileNameArray;
        List<String> DestCopiedFiles = new List<string>();
        List<String> DestFailedTOCOPYFiles = new List<string>();
        public void LoadListOfName(string filename)
        {
            try
            {

                if (File.Exists(filename))
                {
                    FileNameArray = File.ReadAllLines(filename);
                    label1.Text = "Total files to be process :" + FileNameArray.Length;

                }

               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open txt file which contains the list of file names";
            dialog.Multiselect = false;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadListOfName(dialog.FileName);
            }
        }
        public void getFiles(string path)
        {
            try
            {
                SourceFileNameArray = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

                foreach(string name in SourceFileNameArray){

                    listBoxSource.Items.Add(name);
                }


            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    getFiles(dialog.SelectedPath);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    destinationPath=(dialog.SelectedPath);
                }

            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        int Cindex = -1;
        public bool isContains(string name)
        {
            for(int i=0;i<SourceFileNameArray.Length;i++)
            {
                string fname = SourceFileNameArray[i];
                if (fname.Contains(name))
                {
                    Cindex = i;
                    return true;
                }

            }
            return false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string newFileName = "sandy_";
                int index = 0;
                foreach(string name in FileNameArray)
                {

                    if (isContains(name)) {

                        try
                        {
                            string ext = Path.GetExtension(SourceFileNameArray[Cindex]);
                            File.Copy(SourceFileNameArray[Cindex], destinationPath+"/"+newFileName+index+ext);
                            
                        }catch(Exception exx)
                        {
                            MessageBox.Show(exx.Message);
                        }
                        index++;
                    }

                }
                MessageBox.Show("TOTAL FILE COPIED" + index);
            }
            catch(Exception er)
            {

            }
        }
    }
}
