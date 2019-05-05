using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_renamer
{
    public partial class FileRenamer : Form
    {
        string namingConvention ="";
        int counter = 1;

        FileInfo[] FilesInDirectory;
        DirectoryInfo CurrentDirectory;
        public FileRenamer()
        {
            InitializeComponent();
            AllowDrop = true;
            this.DragEnter += new DragEventHandler(FileRenamer_DragEnter);
            this.DragDrop += new DragEventHandler(FileRenamer_DragDrop);
        }

        private void FileRenamer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void FileRenamer_DragDrop(object sender, DragEventArgs e)
        {
            HelperMethods hm = new HelperMethods();
            hm.AddFilesToList = (List<string>)e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in hm.AddFilesToList)
            {
                CurrentFileLbl.Text = file;
                Console.WriteLine(file);
            }
        }

        private void FileRenamer_Load(object sender, EventArgs e)
        {
            Console.WriteLine("loaded form");
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("File Renaming started....", this.ToString());
            openDirectory();
        }

        private void openDirectory()
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            FilePathsList.Items.Clear();
            FilesInDirectory = null;
            CurrentDirectory = null;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurrentDirectory = new DirectoryInfo(openFileDialog.SelectedPath);
                FilesInDirectory = CurrentDirectory.GetFiles();

                foreach (var filesl in FilesInDirectory)
                {
                    FilePathsList.Items.Add(filesl);
                }
            }
        }

        private void RenameBtn_Click(object sender, EventArgs e)
        {
            try
            {
                namingConvention = NewNameInput.Text;
                counter = Convert.ToInt32(CInput.Text);

                if (String.IsNullOrEmpty(counter.ToString()) || String.IsNullOrEmpty(namingConvention))
                {
                    MessageBox.Show("Enter counter position/naming convention");
                    return;
                }
               
                foreach (FileInfo files in FilesInDirectory.OrderBy(lastWrite => lastWrite.FullName))
                {
                   
                    File.Move(files.FullName, Path.Combine(files.DirectoryName, NewNameInput.Text + counter + files.Extension));
                    counter++;
                }

                MessageBox.Show("File Renaming completed ...", this.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show("error" + exception);
            }
        }

    }
}
