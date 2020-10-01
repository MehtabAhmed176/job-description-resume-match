using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumeScanner
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            drawChart(20,50);
            uploadedFileNameLabel.Text = "";

        }

        JobMatch jobMatch = new JobMatch();


        //Button for opening File dialog
        private void upload_resume_btn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var filename = string.Empty;
            //setting the content of inputfile to  jobMatch class

         //   JobMatch jobMatch = new JobMatch();
            jobMatch.resumeContent = "I am the resume content";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    //Get the uplaoded file name
                    filename = openFileDialog.SafeFileName;

                    using (System.IO.StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            // MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

            //  label1.Text = job_description_txtBox.Text;

            printFinalResult(filePath);

            //Change the upload button text after uploading the text

            if (filename != null)
            {
                Console.WriteLine("File name" + filename);
                uploadedFileNameLabel.Text = filename.ToString();
            }




        }



        private void printFinalResult(string filepath)
        {


            //Reading from word file
           string totaltext= readWordFile(filepath);



            string words = job_description_txtBox.Text.ToString();

          
            string wordsfix = cleanString(words);
           string resume = cleanString(totaltext);

            string[] resume_data = resume.Split().Select(x => x.TrimEnd(",.;:".ToCharArray())).ToArray();
            string[] words_data = wordsfix.Split().Select(x => x.TrimEnd(",.;:".ToCharArray())).ToArray();

          

            ArrayList cleanresumeFinal = new ArrayList();
            ArrayList words_dataFinal = new ArrayList();

            for (int i=0;i< resume_data.Length;i++)
            {

              

                if (resume_data[i] != "")
                {
                    cleanresumeFinal.Add(resume_data[i]);
                }

            }

            for (int i=0;i<words_data.Length;i++)
            {
                if (words_data[i] != "")
                {
                    words_dataFinal.Add(words_data[i]);
                }
            }



            //Final the common words between two Lists


            object[] resumeList = cleanresumeFinal.ToArray();
            object[] wordsList = words_dataFinal.ToArray();

            var common = wordsList.Intersect(resumeList);
            var uncommon= wordsList.Except(resumeList);
          

 

            if (uncommon.Count()==0)
            {
                jdLabel.Text += " : "+ "100 %";
            }
            else if(common.Count()==0)
            {
                jdLabel.Text += " : " + "No Match";
            }

            else
            {
                double perectange = ((double)wordsList.Length - (double)uncommon.Count());// / (double)wordsList.Length;

                if (resumeList.Count()> wordsList.Length)
                {
                    double percentValue = perectange / resumeList.Count();
                    jdLabel.Text += " : " + (percentValue * 100).ToString("#.000") + "%";

                    //passing the common and uncommon words into chart
                    drawChart(common.Count(), uncommon.Count());

                }
                else
                {
                    double percentValue = perectange / resumeList.Length;
                    jdLabel.Text += " : " + (percentValue * 100).ToString("#.000") + "%";
                }
                

               
            }


            overalljbLabel.Text = "Common words:" + common.Count().ToString() + "\nUncommon words:"+ uncommon.Count().ToString() + "  \nResume Words" +resumeList.Length.ToString() + " \nWords in Job Description "+wordsList.Length.ToString();//+ wordleght.ToString();
           
        }

        private String cleanString(string text)
        {
            return Regex.Replace(text, @"^\s*$\n", string.Empty, RegexOptions.Multiline);
        }


        private String[] arrayOfString(string text)
        {
            string[] stringOfArray = text.Split().Select(x => x.TrimEnd(",.;:".ToCharArray())).ToArray();
            return stringOfArray;
        }

     

        private void drawChart(int matchwords,int unmatchwords)
        {
            
            int match = matchwords;
           int unmatch = unmatchwords;
            int resumeWords = 20;
            int jd_words = 15;
            chart1.Titles.Add("Pie Chart");
            chart1.Series["s1"].Points.AddXY("Match", match.ToString());
            chart1.Series["s1"].Points.AddXY("Unmatch",unmatch.ToString());
            chart1.Series["s1"].Points.AddXY("Total words in resume", resumeWords.ToString());
            chart1.Series["s1"].Points.AddXY("Total Words in JD", jd_words.ToString());
            /// chart1.Series["s1"].Points.AddXY("Words in JD", "34");
            // chart1.Series["s1"].Points.AddXY("Words in Resume", "34");


            chart1.Series["s1"].Points.RemoveAt(0);
            chart1.Series["s1"].Points.RemoveAt(1);
          //  chart1.Series["s1"].Points.RemoveAt(2);
           // chart1.Series["s1"].Points.RemoveAt(3);
        }

        private void shutdoew_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shuttonDownButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string readWordFile(string FilePath)
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            object miss = System.Reflection.Missing.Value;
            //object path = @"C:\DOC\myDocument.docx";
            object path = FilePath;
            object readOnly = true;
            Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
            string totaltext = "";
            for (int i = 0; i < docs.Paragraphs.Count; i++)
            {
                totaltext += " \r\n " + docs.Paragraphs[i + 1].Range.Text.ToString();

            }

            docs.Close();
            word.Quit();

            return totaltext;

        }
    }
}
