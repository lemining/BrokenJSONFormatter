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

namespace BrokenJsonFormatter.Win
{
    public partial class MainForm : Form
    {
        private string filePath;
        private StringBuilder outputString = new StringBuilder();

        private int _currentDepth;
        private int currentDepth
        {
            set
            {
                if (value >= 0)
                {
                    _currentDepth = value;
                }
            }

            get
            {
                return _currentDepth;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }


        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open broken JSON file";
            openFileDialog.Filter = "JSON Documents (.json)|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Unable to open file.");
                }
            }
        }

        private void formatAndSaveBtn_Click(object sender, EventArgs e)
        {
            if (filePath != null && !string.IsNullOrEmpty(filePath))
            {
                var inputFile = File.ReadAllText(filePath);
                currentDepth = 0;
                var soFar = new StringBuilder();

                for (int i = 0; i < inputFile.Length; i++)
                {
                    if (inputFile[i] == '{' || inputFile[i] == '[')
                    {
                        

                        if (soFar.Length > 0)
                        {
                            outputString.AppendLine(paddingWithDepth(soFar.ToString(), currentDepth));
                            soFar.Remove(0, soFar.Length);
                        }

                        outputString.AppendLine(paddingWithDepth(inputFile[i].ToString(), currentDepth));

                        currentDepth++;
                    }
                    else if (inputFile[i] == '}' || inputFile[i] == ']')
                    {
                        if (soFar.Length > 0)
                        {
                            outputString.AppendLine(paddingWithDepth(soFar.ToString(), currentDepth));
                            soFar.Remove(0, soFar.Length);
                        }

                        currentDepth--;

                        outputString.AppendLine(paddingWithDepth(inputFile[i].ToString(), currentDepth));
                    }
                    else if (inputFile[i] == ',')
                    {
                        soFar.Append(inputFile[i]);
                        soFar.Append(Environment.NewLine);
                        soFar.Append(paddingWithDepth(string.Empty, currentDepth));
                    }
                    else
                    {
                        soFar.Append(inputFile[i]);
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "Save formatted broken JSON file";
                saveFileDialog.Filter = "JSON Documents (.json)|*.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, outputString.ToString());
                }
            }else{
                MessageBox.Show("Please select broken file to open first.");
            }
        }

        private string paddingWithDepth(string characterSet, int depth)
        {
            var padding = new StringBuilder();

            for (int i = 0; i < depth; i++)
            {
                padding.Append('\t');
            }

            if (!string.IsNullOrEmpty(characterSet))
            {
                padding.Append(characterSet);
            }
            
            return padding.ToString();
        }
    }
}
