using System.Xml.Linq;
using System.Diagnostics;
using System.Management.Automation;
using System.IO;
using System.Collections.ObjectModel;
using System.Text;
using LibGit2Sharp;

namespace Santal_Project
{
    
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        public string folder;
        public XDocument element;


        public bool ErrorType()
        {
            int n=0;
            bool valuereturn = false;
            if (projectName.Text.Trim() == "") 
            {
                n = 1;
            }
            if (languageList.Text.Trim() == "")
            {
                n = n + 2;
            }

            switch (n)
            {
                case 1:
                    MessageBox.Show("Inserire il nome del progetto", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valuereturn = true;
                    break;

                case 2:
                    MessageBox.Show("Inserire il linguaggio del progetto", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valuereturn = true;
                    break;
                case 3:
                    MessageBox.Show("Inserire il nome e il linguaggio del progetto", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valuereturn = true;
                    break;

            }
            return valuereturn;

        }

        public void AnalizeCheckbox(string projectfolder, string extension)
        {
            if (Gitselection.Checked)
            {
                Git(projectfolder);
            }
            if (FileOpen.Checked)
            {
                Process.Start("explorer.exe", Path.Combine(projectfolder, $"main.{extension}"));
                // Process.Start(Path.Combine(projectfolder, $"main.{extension}"));      
            }
            if (OpenFolder.Checked)
            {
                Process.Start("explorer.exe", projectfolder);
            }
        }
        public void Git(string projectfolder)
        {
            var author = new LibGit2Sharp.Signature("Author", "generic", DateTime.Now);
            var committer = author;
            Repository.Init(projectfolder);
            var repo = new Repository(projectfolder);
            Commands.Stage(repo, "*");
            
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            folder= Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), ".Project");

            
            Debug.WriteLine(folder);
            if (!(Directory.Exists(folder)))
            {
               Directory.CreateDirectory(folder);
            }
            element = XDocument.Load("Setting.xml");
            var query = from lan in element.Descendants("language")
                                     orderby lan.Attribute("name").Value
                                     select new
                                     {
                                         code = lan.Element("code").Value,
                                         languagename = lan.Attribute("name").Value,
                                         extension = lan.Attribute("extension")
                                     };
            foreach (var item in query)
            {
                if (!(Directory.Exists(Path.Combine(folder, item.languagename))))
                {
                    Directory.CreateDirectory(Path.Combine(folder, item.languagename));
                }
                languageList.Items.Add(item.languagename);
               
            }
           
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string text = projectName.Text.Trim();
            if (!ErrorType())
            {
                string extension="";
                var query = from lan in element.Descendants("language")
                            orderby lan.Attribute("name").Value
                            where lan.Attribute("name").Value == languageList.Text
                            select new
                            {
                                code = lan.Element("code").Value,
                                filename =lan.Element("code").Attribute("filename").Value,
                                languagename = lan.Attribute("name").Value,
                                extension = lan.Attribute("extension").Value
                            };
                string projectfolder = Path.Combine(folder, languageList.Text, projectName.Text);
                Directory.CreateDirectory(projectfolder);
                foreach (var item in query)
                {
                    if (item.filename == "main")
                    {
                        extension = item.extension;
                    }
                    using (FileStream fs = File.Create(Path.Combine(projectfolder, $"{item.filename}.{item.extension}")))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(item.code);
                        fs.Write(info, 0, info.Length);
                    }
                }
                AnalizeCheckbox(projectfolder, extension);

            }
            

        }
    }
}