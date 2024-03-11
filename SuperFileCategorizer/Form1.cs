using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Cryptography;


namespace SuperFileCategorizer
{
    

    public partial class Form1 : Form
    {
        string str_input = "";
        string str_output = "";
        string file_dest = "";
        int counter = 0;

        private static readonly Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        }

                
        public static string RandomString(int size, bool lowerCase = false)
        {


            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.

            // char is a single Unicode character
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }
            Application.DoEvents();
            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }


        private void cmdSelectInput_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            DialogResult result = folderBInput.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBInput.SelectedPath))
            {
                str_input = folderBInput.SelectedPath;
                MessageBox.Show(str_input + " selected as input directory");

            }
        }

        private void cmdSelectOutput_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            DialogResult result = folderBOutput.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBOutput.SelectedPath))
            {
                str_output = folderBOutput.SelectedPath;
                MessageBox.Show(str_output + " selected as output directory");
            }

        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            try
            {

                List<string> extensions_list = new List<string>();

                //Console.WriteLine("Give input path without ending \\");
                //str_input = Console.ReadLine();

                //Console.WriteLine("Give output path without ending \\");
                //str_output = Console.ReadLine();

                // Recursive get all extensions of all files
                foreach (string file in Directory.EnumerateFiles(str_input, "*.*", SearchOption.AllDirectories))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    extensions_list.Add(fileInfo.Extension);
                    counter++;
                    Application.DoEvents();
                }

                progressBar1.Maximum = counter;
                progressBar1.Value = 0;
                label1.Visible = true;
                label1.Text = "Processing file " + progressBar1.Value.ToString() + " out of "+ counter.ToString();
                label1.Refresh();

                //sort start list
                extensions_list.Sort();

                //make a list with unique items with extensions
                List<string> d_list = new List<string>();

                d_list = extensions_list.Distinct().ToList();

                foreach (string extension in d_list)
                {
                    //create directory for every single unique extension
                    Directory.CreateDirectory(str_output + "\\" + extension);
                    Application.DoEvents();
                }



                // For each file in collection move it one by one in appropriate directory
                foreach (string file_src in Directory.EnumerateFiles(str_input, "*.*", SearchOption.AllDirectories))
                {
                    try { 
                        FileInfo fileInfo1 = new FileInfo(file_src);

                        string file_ex_dest = fileInfo1.Extension;

                        file_dest = str_output + "\\" + file_ex_dest + "\\" + fileInfo1.Name;

                        if (File.Exists(file_dest))
                        {
                            string rnds = RandomString(3, true);

                            file_dest = str_output + "\\" + file_ex_dest + "\\" + rnds + fileInfo1.Name;
                        }

                        File.Copy(file_src, file_dest, true);

                        if (progressBar1.Value < progressBar1.Maximum)
                            progressBar1.Value++; 

                        label1.Text = "Processing file " + progressBar1.Value.ToString() + " out of " + counter.ToString();
                        label1.Refresh();

                        Application.DoEvents();
                            //Console.WriteLine("Copying to " + file_dest + " OK");

                        //counter++;
                    }
                    catch (Exception ex)
                    {
                        Debug.Print(ex.Message);
                        MessageBox.Show(file_src + "\n" + "might not copied succesfully, please check.....");
                        if (progressBar1.Value < progressBar1.Maximum)
                            progressBar1.Value++;
                    }

                }
                MessageBox.Show("Operation OK Categorization of " + counter.ToString() + " files OK");
                label1.Text = "";
                label1.Visible = false;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                MessageBox.Show("Something stated as error, please check.....");
            }

        }
    }
}
