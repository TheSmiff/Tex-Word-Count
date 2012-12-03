using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace TeX_Word_Count
{
    public partial class Form1 : Form
    {
        private string chosenFile = "";

        public string ChosenFile
        {
            get
            {
                return chosenFile;
            }
            set
            {
                chosenFile = value;
            }
        }

        int Count;
        char[] C = new char[1];
        bool first = true;
               

        public Form1()
        {
            InitializeComponent();
            openFD.Title = "Open Root TeX File";
            openFD.FileName = "";
            openFD.Title = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD.Filter = "TeX Files|*.tex";
            RunButton.Enabled = false;
            C[0] = ' ';
            
            Form1.ActiveForm.Name = "Tom's TeX Word Count";
           
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("cancel button clicked");
            }
            else
            {
                ChosenFile = openFD.FileName;
                FileName.Text = ChosenFile;
                RunButton.Enabled = true;
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Count = 0;
            string diagfile = ChosenFile.Remove(ChosenFile.LastIndexOf('\\'));
            if (File.Exists(diagfile + "WordCount.txt") == false)
            {
                File.Create(diagfile + "WordCount.txt");
                using (StreamWriter writer = File.AppendText(diagfile + "\\WordCount.txt"))
                {
                    writer.Write("*********************************************\r\n");
                    writer.Write("File Written By Tom's TeX Word Count\r\n");
                    writer.WriteLine("Contains wordcount log");
                    writer.WriteLine("Initial file creation " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
                    writer.WriteLine(ChosenFile);
                    writer.WriteLine("*********************************************");
                    

                }
                
            }
            List<string> MainFile = ReadFile(ChosenFile);
            first = true;
            CountMyWords(MainFile);

            if (Record.Checked == true)
            {
                using (StreamWriter writer = File.AppendText(diagfile + "\\WordCount.txt"))
                {
                    writer.WriteLine("\r\n\r\n****************************************************");
                    writer.WriteLine("Words recounted " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
                    writer.WriteLine(Count.ToString() + " Words Counted");

                    if (WriteDiagnostics.Checked == true)
                    {
                        writer.WriteLine("COMMENCE FILE DUMP!!!");
                        foreach (string s in DiagnosticPane.Items)
                        {
                            writer.WriteLine(s);
                        }
                        writer.WriteLine("DUMP COMPLETE");
                    }

                    writer.WriteLine("End of Entry\n******************************************************");
                }
            }

            Words.Visible = true;
            Words.Text = Count.ToString();
            Words.TextAlign = ContentAlignment.MiddleCenter;
        }

        private List<string> ReadFile(string FileName)
        {
            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader(FileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line); // Add to list.
                }
            }

            return list;
        }

        private void CountMyWords(List<string> CountFile)
        {
            foreach (string t in CountFile)
            {

                string[] a = t.Split(C, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in a)
                {

                    MatchCollection collection1 = Regex.Matches(s, @"[%{}\\-]", RegexOptions.Compiled);
                    if (collection1.Count < 1)
                    {
                        MatchCollection collection = Regex.Matches(s, @"[\S]+");
                        Count += collection.Count;
                        DiagnosticPane.Items.Add(Count.ToString()+". "+s);
                        DiagnosticPane.Update();
                    }
                    else if(s.Contains("input") == true)
                    {

                        string Directory = Modify(s);
                        DiagnosticPane.Items.Add("***********\nOpen "+Directory+".tex\n*****************");
                        DiagnosticPane.Update();
                        CountMyWords(ReadFile(ChosenFile+"\\"+Directory+".tex"));
                        
                    }
                    else
                    {
                        break;
                    }
                }
                

            }

        }

        private string Modify(string line)
        {
            string ti = "";
            int d = 0;
            if (first)
            {
                ChosenFile = ChosenFile.Remove(ChosenFile.LastIndexOf('\\'));
                first = false;
            }

            d = line.LastIndexOf('}');
            d -= 7;

            ti = line.Remove(0, 7);
            ti = ti.Remove(d);
            return ti;
        }


        private void Diagnostic_CheckedChanged(object sender, EventArgs e)
        {
            DiagnosticPane.Visible = !DiagnosticPane.Visible;
        }
    }
}
