using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace Santal_Project
{

    public partial class AggiuntaLinguaggio : Form
    {
        List<FileStream> fileContent = new List<FileStream>();
        List<String> FilePath = new List<String>();
        public AggiuntaLinguaggio()
        {
            InitializeComponent();
        }
        public bool ErrorType()
        {
            int n = 0;
            bool valuereturn = false;
            if (textBox1.Text.Trim() == "")
            {
                n = 1;
            }
            if (textBox2.Text.Trim() == "")
            {
                n = n + 2;
            }
            if (!(textBox2.Text.ToLower().Contains("main")))
            {
                n = n + 5;
            }
            switch (n)
            {
                case 1:
                case 6:
                    MessageBox.Show("Inserire il nome linguaggio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valuereturn = true;
                    break;

                case 2:
                case 7:
                    MessageBox.Show("Inserire i file basilari del linguaggio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valuereturn = true;
                    break;
                case 3:
                case 8:
                    MessageBox.Show("Inserire i file e il nome del linguaggio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valuereturn = true;
                    break;
                case 5:
                    MessageBox.Show("Non è presente un file main", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valuereturn = true;
                    break;
                

            }
            return valuereturn;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (String file in openFileDialog.FileNames)
                    {
                        FilePath.Add(file);
                        fileContent.Add(File.Open(file, FileMode.Open));
                        textBox2.AppendText(file + Environment.NewLine);
                    }
                }
            }

            
        }

        private void AggiuntaLinguaggio_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ErrorType())
            {
                bool present=false;
                XDocument element = XDocument.Load("Setting.xml");
                var query = from lan in element.Descendants("language")
                            where lan.Attribute("name").Value.ToLower() == textBox1.Text.ToLower().Trim()
                            select present= true;
                foreach (var q in query)
                {
                    Debug.WriteLine($"Linguaggio presente: {present}");
                }
                
                if (!present)
                {
                    List<code> codeelement = new List<code>();
                    foreach (var item in fileContent)
                    {
                        var b = new byte[item.Length];
                        item.Read(b, 0, b.Length);
                        codeelement.Add(new code() { filename = Path.GetFileNameWithoutExtension(item.Name), extension = Path.GetExtension(item.Name), data = b });
                    }
                    language languageadd = new language() { Name = textBox1.Text, codes = codeelement };



                    XElement newelement = new XElement("language", new XAttribute("name", languageadd.Name.ToUpper()),
                        from item in languageadd.codes
                        select new XElement("code", new XAttribute("extension", item.extension), new XAttribute("filename", item.filename), BitConverter.ToString(item.data))
                        );

                    element.Root.Add(newelement);
                   // Debug.WriteLine(element);
                    element.Save(Path.Combine(Application.StartupPath, "Setting.xml"));
                    MessageBox.Show("Linguaggio aggiunto correttamente", "Aggiunto", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Linguaggio già esistente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
    public class code
    {
        public String filename { get; set; }
        public String extension { get; set; }
        public byte[] data { get; set; }
    }
    public class language
    {
        public String Name { get; set; }

        public List<code> codes { get; set; }

    }
}
