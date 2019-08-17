using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace FileSearcher
{
    public partial class MainWindow : Form
    {
        //Variables

        private Boolean m_closing = false;

        //Synchronizing Delegates

        private delegate void FoundInfoSyncHandler(FoundInfoEventArgs e);
        private FoundInfoSyncHandler FoundInfo;

        private delegate void ThreadEndedSyncHandler(ThreadEndedEventArgs e);
        private ThreadEndedSyncHandler ThreadEnded;


        //Constructor

        public MainWindow()
        {
            InitializeComponent();
        }

        //Event Handlers

        private void MainWindow_Load(object sender, EventArgs e)
        {
            searchDirTextBox.Text = UserConfig.Data.SearchDir;
            fileNameTextBox.Text = UserConfig.Data.FileName;
            containingTextBox.Text = UserConfig.Data.ContainingText;

            // Subscribe for my own delegates
            this.FoundInfo += new FoundInfoSyncHandler(this_FoundInfo);
            this.ThreadEnded += new ThreadEndedSyncHandler(this_ThreadEnded);

            // Subscribe for the Searcher's events
            Searcher.FoundInfo += new Searcher.FoundInfoEventHandler(Searcher_FoundInfo);
            Searcher.ThreadEnded += new Searcher.ThreadEndedEventHandler(Searcher_ThreadEnded);

            searchDirTextBox.Text = "";
            containingTextBox.Text = "";
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Remember that the window is closing,
            // so that all events from the Searcher are ignored from now on
            m_closing = true;

            UserConfig.Data.SearchDir = searchDirTextBox.Text;
            UserConfig.Data.FileName = fileNameTextBox.Text;
            UserConfig.Data.ContainingText = containingTextBox.Text;
        }

        private void selectSearchDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = searchDirTextBox.Text;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                searchDirTextBox.Text = dlg.SelectedPath;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Clear the results list
            resultsList.Items.Clear();

            // Get the parameters for  the search thread
            String fileNamesString = fileNameTextBox.Text;
            String[] fileNames = fileNamesString.Split(new Char[]{';'});
            List<String> validFileNames = new List<String>();
            foreach (String fileName in fileNames)
            {
                String trimmedFileName = fileName.Trim();
                if (trimmedFileName != "")
                {
                    validFileNames.Add(trimmedFileName);
                }
            }

            Encoding encoding = Encoding.ASCII;

            SearcherParams pars = new SearcherParams(searchDirTextBox.Text.Trim(), validFileNames, containingTextBox.Text.Trim(), encoding);

            // Start the search thread if it is not already running
            if (Searcher.StartSearch(pars)) { }
            else
            {
                MessageBox.Show("The searcher is already running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            // Don't open the context menu strip, if there are no items selected
            if (resultsList.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void openContainingFolderContextMenuItem_Click(object sender, EventArgs e)
        {
            // Get the path from the selected item
            if (resultsList.SelectedItems.Count > 0)
            {
                String path = resultsList.SelectedItems[0].Text;

                // Open its containing folder in Windows Explorer
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "explorer.exe";
                    startInfo.Arguments = Path.GetDirectoryName(path);
                    Process process = new Process();
                    process.StartInfo = startInfo;
                    process.Start();
                }
                catch (Exception)
                {
                }
            }
        }

        private void resultsList_DoubleClick(object sender, EventArgs e)
        {
            // Get the path from the selected item
            if (resultsList.SelectedItems.Count > 0)
            {
                String path = resultsList.SelectedItems[0].Text;

                // Open it, if it's a file
                if (File.Exists(path))
                {
                    try
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = path;
                        startInfo.Arguments = "";
                        Process process = new Process();
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                    catch (Exception) { }
                }
            }
        }

        private void resultsList_Resize(object sender, EventArgs e)
        {
            resultsList.Columns[0].Width = resultsList.Width - 230;
        }

        private void Searcher_FoundInfo(FoundInfoEventArgs e)
        {
            if (!m_closing)
            {
                // Invoke the method "this_FoundInfo" through a delegate,
                // so it is executed in the same thread as MainWindow
                this.Invoke(FoundInfo, new object[] { e });
            }
        }

        private void this_FoundInfo(FoundInfoEventArgs e)
        {
            // Create a new item in the results list
            CreateResultsListItem(e.Info);
        }

        private void Searcher_ThreadEnded(ThreadEndedEventArgs e)
        {
            if (!m_closing)
            {
                // Invoke the method "this_ThreadEnded" through a delegate,
                // so it is executed in the same thread as MainWindow
                this.Invoke(ThreadEnded, new object[] { e });
            }
        }

        private void this_ThreadEnded(ThreadEndedEventArgs e)
        {
            // Show an error message if necessary
            if (!e.Success)
            {
                MessageBox.Show(e.ErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CreateResultsListItem(FileSystemInfo info)
        {
            // Create a new item and set its text
            ListViewItem lvi = new ListViewItem();
            lvi.Text = info.FullName;

            lvi.ToolTipText = info.FullName;

            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
            lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Text = info.FullName;

            //repetition of string
            string s = File.ReadAllText(info.FullName, System.Text.Encoding.Default);
            string[] sub = { containingTextBox.Text };
            string[] arr = s.Split(sub, StringSplitOptions.None);

            resultsList.Items.Add(lvi);
            lvi.SubItems.Add((arr.Length - 1).ToString());

        }
    }
}
