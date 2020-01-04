using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using ExcelLibrary.SpreadSheet;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;

namespace TexDaemon
{
    public partial class DaemonForm : Form
    {
        public int QtyProcessed;
        public bool IsProcessingAborted = false;
        public LogForm Log = new LogForm();
        public GridRowEditForm OperationEditor = new GridRowEditForm();
        public ExecSQLForm SQLForm = new ExecSQLForm();
        public FilterByContentForm SearchResultsFilterForm = new FilterByContentForm();
        public string ProgramDirectory = Path.GetDirectoryName(Application.ExecutablePath);
        public List<string> FilterResults = null;
        public bool ShowApp;
        private int AmountToProcess = 0;
        private int ThreadsCount = 10;
        private int SingleThreadLimit = 20;

        private ProcessingThread WorkThread;
        private ProcessingThread[] WorkThreads;

        private DeletingThread DelWorkThread;
        private DeletingThread[] DelWorkThreads;

        private FilteringThread FilterWorkThread;
        private FilteringThread[] FilterWorkThreads;

        public DaemonForm(bool showMainForm)
        {
            ShowApp = showMainForm;
            InitializeComponent();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbxSearchTarget.SelectedIndex)
            {
                case 0: // Files Only
                    txtSearchResults.Lines = Directory.GetFiles(txtStartDir.Text, txtSearchCriteria.Text, chkDeepSearch.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                    break;
                case 1: // Folders Only
                    txtSearchResults.Lines = Directory.GetDirectories(txtStartDir.Text, txtSearchCriteria.Text, chkDeepSearch.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                    break;
                case 2: // Files and Folders
                    List<string> l = new List<string>();
                    l.AddRange(Directory.GetDirectories(txtStartDir.Text, txtSearchCriteria.Text, chkDeepSearch.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
                    l.AddRange(Directory.GetFiles(txtStartDir.Text, txtSearchCriteria.Text, chkDeepSearch.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
                    txtSearchResults.Lines = l.ToArray();
                    break;
                default:
                    break;
            }            
            lblProcessingStatus.Text = "Found: " + txtSearchResults.Lines.Length.ToString();
        }

        private void btnProcessResults_Click(object sender, EventArgs e)
        {
            if (txtRegExPR.Text == String.Empty)
            {
                return;
            }

            List<string> L;
            L = txtSearchResults.Lines.ToList();

            for (int i = 0; i <= L.Count - 1; i++ )
            {
                L[i] = Regex.Replace(L[i], txtRegExPR.Text, txtRegExSubPR.Text);
            }
            txtSearchResults.Clear();
            txtSearchResults.Lines = L.ToArray();
        }

        private void btnProcessFiles_Click(object sender, EventArgs e)
        {
            AmountToProcess = txtSearchResults.Lines.Length;
            if (AmountToProcess == 0) return;

            IsProcessingAborted = false;
            QtyProcessed = 0;
            ProcessingBar.Value = 0;
            ProcessingBar.Maximum = AmountToProcess;

            if (ShowApp)
            {
                Log.LogBox.Clear();
            }

            Log.Log("Started. Files amount: " + AmountToProcess.ToString());

            btnAbort.Text = "Abort";
            btnAbort.Location = btnProcessFiles.Location;
            btnAbort.Visible = true;
            btnProcessFiles.Visible = false;
            EnableAllControlls(this, false);
            
            if (AmountToProcess < SingleThreadLimit)
            {
                WorkThread = new ProcessingThread(this);
                WorkThread.Files = txtSearchResults.Lines;
                WorkThread.StartProcessing();
            }
            else
            {
                int FilesCountForThread = AmountToProcess / ThreadsCount;
                int StartIndexForCopy;
                WorkThreads = new ProcessingThread[ThreadsCount];

                // setting up the array sizes for threads. asigning files to threads.
                for (int i = 0; i < ThreadsCount; i++)
                {
                    StartIndexForCopy = FilesCountForThread * i;
                    if (i + 1 == ThreadsCount)
                    {
                        FilesCountForThread = AmountToProcess - StartIndexForCopy;
                    }

                    WorkThreads[i] = new ProcessingThread(this);
                    WorkThreads[i].Files = new string[FilesCountForThread];                    
                    
                    Array.Copy(txtSearchResults.Lines, StartIndexForCopy, WorkThreads[i].Files, 0, FilesCountForThread);                    
                }

                // start all threads
                for (int i = 0; i < ThreadsCount; i++)
                {
                    WorkThreads[i].StartProcessing();
                }
            }
        }

        public void UpdateProgress()
        {
            lblProcessingStatus.Text = "Done: " + QtyProcessed.ToString() + "/" + AmountToProcess.ToString();
            ProcessingBar.Value = QtyProcessed;
            if (AmountToProcess == QtyProcessed)
            {
                if (FilterResults != null)
                {
                    txtSearchResults.Clear();
                    txtSearchResults.Lines = FilterResults.ToArray();
                    FilterResults = null;
                }
                EnableAllControlls(this, true);
                btnAbort.Visible = false;
                btnProcessFiles.Visible = true;
                Log.Log("Job done.");
                SaveLogs();
                if (!ShowApp)
                {
                    Application.ExitThread();
                }
            }
        }

        public void WaitThreadsCompleted()
        {
            if (AmountToProcess < SingleThreadLimit)
            {
                EnableAllControlls(this, true);
                btnAbort.Visible = false;
                btnProcessFiles.Visible = true;
                Log.Log("Job aborted.");
            }
            else
            {
                int completed = 0;
                for (int i = 0; i < ThreadsCount; i++ )
                {
                    if (WorkThreads[i].Finished) completed += 1;
                }
                if (ThreadsCount == completed && btnAbort.Visible)
                {
                    EnableAllControlls(this, true);
                    btnAbort.Visible = false;
                    btnProcessFiles.Visible = true;
                    Log.Log("Job aborted.");
                }
            }
        }

        public void WaitDeletesCompleted()
        {
            if (AmountToProcess < SingleThreadLimit)
            {
                EnableAllControlls(this, true);
                btnAbort.Visible = false;
                btnProcessFiles.Visible = true;
                Log.Log("Job aborted.");
            }
            else
            {
                int completed = 0;
                for (int i = 0; i < ThreadsCount; i++)
                {
                    if (DelWorkThreads[i].Finished) completed += 1;
                }
                if (ThreadsCount == completed && btnAbort.Visible)
                {
                    EnableAllControlls(this, true);
                    btnAbort.Visible = false;
                    btnProcessFiles.Visible = true;
                    Log.Log("Job aborted.");
                }
            }
        }

        public void WaitFiltersCompleted()
        {
            if (AmountToProcess < SingleThreadLimit)
            {
                EnableAllControlls(this, true);
                btnAbort.Visible = false;
                btnProcessFiles.Visible = true;
                Log.Log("Job aborted.");
            }
            else
            {
                int completed = 0;
                for (int i = 0; i < ThreadsCount; i++)
                {
                    if (FilterWorkThreads[i].Finished) completed += 1;
                }
                if (ThreadsCount == completed && btnAbort.Visible)
                {
                    EnableAllControlls(this, true);
                    btnAbort.Visible = false;
                    btnProcessFiles.Visible = true;
                    Log.Log("Job aborted.");
                }
            }
        }

        public void WriteLog(string strMessage)
        {
            Log.Log(strMessage);
        }

        public void WriteErrorLog(string strMessage)
        {
            WriteLog("Error: " + strMessage);
            if (!Log.Visible && ShowApp)
            {
                Log.Show();
            }
        }

        public void EnableAllControlls(Control CContainer, bool BoolValue = true)
        {
            BackupCheckBox.Visible = BoolValue;

            foreach (Control c in CContainer.Controls)
            {
                if (c.Controls.Count > 0 && c.GetType() != typeof(System.Windows.Forms.DataGridView))
                {
                    EnableAllControlls(c, BoolValue);
                }
                else
                {
                    switch (c.Name)
                    {
                        case "lblProcessingStatus":
                            break;
                        case "ProcessingBar":
                            break;
                        case "btnShowLog":
                            break;
                        case "btnAbort":
                            break;
                        default:
                            c.Enabled = BoolValue;
                            break;
                    }
                }
            }
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            Log.Show();
            Log.Activate();
        }

        private void txtSearchResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtSearchResults.SelectAll();
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            btnAbort.Text = "Aborting...";
            IsProcessingAborted = true;
        }

        private void SuperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WorkThread != null) 
            {
                e.Cancel = WorkThread.IsAlive();
                if (e.Cancel) return;
            }

            if (WorkThreads == null) return;

            for (int i = 0; i < ThreadsCount; i++)
            {
                if (WorkThreads[i] != null)
                {
                    if (WorkThreads[i].IsAlive())
                    {
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }

        private void dgrProcRegExps_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrProcRegExps.SelectedCells.Count == 1)
            {
                dgrProcRegExps.BeginEdit(true);
            }
            else
            {
                dgrProcRegExps.EndEdit();
            }
        }

        private void dgrProcRegExps_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrProcRegExps.SelectedCells.Count > 1)
            {
                object objCondition =   dgrProcRegExps.SelectedRows[0].Cells[0].Value;
                object objRegEx =       dgrProcRegExps.SelectedRows[0].Cells[1].Value;
                object objRegExSub =    dgrProcRegExps.SelectedRows[0].Cells[2].Value;
                OperationEditor.txtCondition.Text = objCondition == null ? "" : objCondition.ToString();
                OperationEditor.txtRegEx.Text = objRegEx == null ? "" : objRegEx.ToString();
                OperationEditor.txtRegExSub.Text = objRegExSub == null ? "" : objRegExSub.ToString();
                if (OperationEditor.ShowDialog() == DialogResult.OK)
                {
                    dgrProcRegExps.SelectedRows[0].Cells[0].Value = OperationEditor.txtCondition.Text;
                    dgrProcRegExps.SelectedRows[0].Cells[1].Value = OperationEditor.txtRegEx.Text;
                    dgrProcRegExps.SelectedRows[0].Cells[2].Value = OperationEditor.txtRegExSub.Text;
                }
            }
        }

        private void txtSearchResults_TextChanged(object sender, EventArgs e)
        {
            lblSearchResults.Text = "Search results (" + txtSearchResults.Lines.Length + ") :";
        }

        private void txtSearchResults_Resize(object sender, EventArgs e)
        {
            btnSearchResultsPopup.Left = txtSearchResults.Width - 16 + btnSearchResultsPopup.Parent.Padding.Left;
            btnSearchResultsPopup.Top = txtSearchResults.Height - 16 + btnSearchResultsPopup.Parent.Padding.Top;
        }

        private void btnSearchResultsPopup_Click(object sender, EventArgs e)
        {
            ctmSearchResultsMenu.Show(Cursor.Position);
        }

        private void dgrProcRegExps_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (lblCurrentSettingsFile.Text != String.Empty)
            {
                if (lblCurrentSettingsFile.Text[lblCurrentSettingsFile.Text.Length - 1] != '*')
                {
                    lblCurrentSettingsFile.Text += '*';
                }
            }
        }

        private void mniSearchResultsSQLFill_Click(object sender, EventArgs e)
        {
            if (SQLForm.ShowDialog() == DialogResult.OK)
            {
                /*
                StringBuilder s = new StringBuilder();

                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=" + SQLForm.chbDbServers.SelectedValue + "; Integrated Security=SSPI; database=SomeDbName; Timeout=3600"))
                    {
                        SqlCommand command = new SqlCommand(SQLForm.txtSQL.Text, connection);
                        command.CommandTimeout = 3600;
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        bool isFirstRecord = true;
                        while (reader.Read())
                        {
                            if (isFirstRecord)
                            {
                                isFirstRecord = false;
                            }
                            else
                            {
                                s.Append(Environment.NewLine);
                            }

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                s.Append(reader[i]);
                                if (i + 1 < reader.FieldCount)
                                {
                                    s.Append("\t");
                                }
                            }
                        }
                        reader.Close();
                    }
                    txtSearchResults.Text = s.ToString();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "SQL Error");
                }
                */
            }
        }

        private void SuperForm_Load(object sender, EventArgs e)
        {
            if (!ShowApp)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            cbxSearchTarget.SelectedIndex = 0;
            lblCurrentSettingsFile.Text = String.Empty;
        }

        private void mniDeleteRealFiles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete all files from the disk?", "Deletion", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            AmountToProcess = txtSearchResults.Lines.Length;
            if (AmountToProcess == 0) return;

            IsProcessingAborted = false;
            QtyProcessed = 0;
            ProcessingBar.Value = 0;
            ProcessingBar.Maximum = AmountToProcess;

            Log.Log("Files amount: " + AmountToProcess.ToString() + ". Deleting files...");

            btnAbort.Text = "Abort";
            btnAbort.Location = btnProcessFiles.Location;
            btnAbort.Visible = true;
            btnProcessFiles.Visible = false;
            EnableAllControlls(this, false);

            if (AmountToProcess < SingleThreadLimit)
            {
                DelWorkThread = new DeletingThread(this);
                DelWorkThread.Masks = txtSearchResults.Lines;
                DelWorkThread.StartProcessing();
            }
            else
            {
                int FilesCountForThread = (int)Math.Round((double)AmountToProcess / (double)ThreadsCount);
                int StartIndexForCopy;
                DelWorkThreads = new DeletingThread[ThreadsCount];

                // setting up the array sizes for threads. asigning files to threads.
                for (int i = 0; i < ThreadsCount; i++)
                {
                    StartIndexForCopy = FilesCountForThread * i;
                    if (i + 1 == ThreadsCount)
                    {
                        FilesCountForThread = AmountToProcess - StartIndexForCopy;
                    }

                    DelWorkThreads[i] = new DeletingThread(this);
                    DelWorkThreads[i].Masks = new string[FilesCountForThread];

                    Array.Copy(txtSearchResults.Lines, StartIndexForCopy, DelWorkThreads[i].Masks, 0, FilesCountForThread);
                }

                // start all threads
                for (int i = 0; i < ThreadsCount; i++)
                {
                    DelWorkThreads[i].StartProcessing();
                }
            }
        }

        private void mniFilterResultsByContent_Click(object sender, EventArgs e)
        {
            if (SearchResultsFilterForm.ShowDialog() == DialogResult.OK)
            {
                if (SearchResultsFilterForm.txtFilterRegEx.Text != String.Empty)
                {
                    AmountToProcess = txtSearchResults.Lines.Length;
                    if (AmountToProcess == 0) return;

                    IsProcessingAborted = false;
                    QtyProcessed = 0;
                    ProcessingBar.Value = 0;
                    ProcessingBar.Maximum = AmountToProcess;

                    Log.Log("Files amount: " + AmountToProcess.ToString() + ". Filtering by content...");

                    btnAbort.Text = "Abort";
                    btnAbort.Location = btnProcessFiles.Location;
                    btnAbort.Visible = true;
                    btnProcessFiles.Visible = false;
                    EnableAllControlls(this, false);

                    FilterResults = new List<string>();

                    if (AmountToProcess < SingleThreadLimit)
                    {
                        FilterWorkThread = new FilteringThread(this);
                        FilterWorkThread.Files = txtSearchResults.Lines;
                        FilterWorkThread.StartProcessing();
                    }
                    else
                    {
                        int FilesCountForThread = (int)Math.Round((double)AmountToProcess / (double)ThreadsCount);
                        int StartIndexForCopy;
                        FilterWorkThreads = new FilteringThread[ThreadsCount];

                        // setting up the array sizes for threads. asigning files to threads.
                        for (int i = 0; i < ThreadsCount; i++)
                        {
                            StartIndexForCopy = FilesCountForThread * i;
                            if (i + 1 == ThreadsCount)
                            {
                                FilesCountForThread = AmountToProcess - StartIndexForCopy;
                            }

                            FilterWorkThreads[i] = new FilteringThread(this);
                            FilterWorkThreads[i].Files = new string[FilesCountForThread];

                            Array.Copy(txtSearchResults.Lines, StartIndexForCopy, FilterWorkThreads[i].Files, 0, FilesCountForThread);
                        }

                        // start all threads
                        for (int i = 0; i < ThreadsCount; i++)
                        {
                            FilterWorkThreads[i].StartProcessing();
                        }
                    }
                }
            }
        }

        private void ctmSearchResultsMenu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                mniDeleteRealFiles.Enabled = true;
            }
        }

        private void ctmSearchResultsMenu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            mniDeleteRealFiles.Enabled = false;
        }

        private void SaveLogs()
        {
            try
            {
                string logFile = "logs.log";

                if (Program.Args != null)
                {
                    foreach (string[] a in Program.Args)
                    {
                        if (a[0] == "log")
                        {
                            if (!String.IsNullOrWhiteSpace(a[1]))
                            {
                                logFile = a[1];
                            }
                            break;
                        }
                    }
                }
                File.AppendAllLines(logFile, Log.LogBox.Lines);
            }
            catch { }
        }

        private void SuperForm_Shown(object sender, EventArgs e)
        {
            if (!ShowApp)
            {
                this.Hide();
                Application.DoEvents();
            }
            if (Program.Args != null)
            {
                bool files_loaded = false;
                bool operations_loaded = false;
                txtSearchResults.Clear();

                try
                {
                    foreach (string[] a in Program.Args)
                    {
                        if (a[0] == "l" || a[0] == "load")
                        {
                            if (!String.IsNullOrWhiteSpace(a[1]) && File.Exists(a[1]))
                            {
                                txtSearchResults.AppendText(File.ReadAllText(a[1]) + Environment.NewLine);
                                files_loaded = true;
                                Log.Log("Files list: " + a[1]);
                            }
                        }

                        if (a[0] == "o" || a[0] == "operations")
                        {
                            if (!String.IsNullOrWhiteSpace(a[1]) && File.Exists(a[1]))
                            {
                                LoadSettings(a[1]);
                                operations_loaded = true;
                                Log.Log("RegEx Operations: " + a[1]);
                            }
                        }
                    }
                }
                catch { }

                if (!ShowApp && (!files_loaded || !operations_loaded))
                {
                    Application.ExitThread();
                }
                else if (!ShowApp)
                {
                    btnProcessFiles_Click(sender, e);
                }
            }
        }

        private void mniCustomOperation_Click(object sender, EventArgs e)
        {
            // some test code
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialogSave.InitialDirectory = ProgramDirectory;

            if (saveFileDialogSave.ShowDialog() == DialogResult.OK)
            {
                SaveSettings(saveFileDialogSave.FileName);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var filePath = lblCurrentSettingsFile.Tag as string;

            if (!String.IsNullOrEmpty(filePath))
            {
                SaveSettings(filePath);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            loadFileDialogLoad.InitialDirectory = ProgramDirectory;

            if (loadFileDialogLoad.ShowDialog() == DialogResult.OK)
            {
                LoadSettings(loadFileDialogLoad.FileName);
            }
        }

        private void SaveSettings(string filePath)
        {
            var settings = new UserSettings()
            {
                FilesListRegEx = txtRegExPR.Text,
                FilesListRegExSub = txtRegExSubPR.Text,
                MakeBackups = BackupCheckBox.Checked,
                Processors = new List<UserSettings.Processor>(),
                FilesList = new List<string>(txtSearchResults.Lines),
            };

            foreach (DataGridViewRow dgvR in dgrProcRegExps.Rows)
            {
                var processor = new UserSettings.Processor()
                {
                    Condition = dgvR.Cells[0].Value?.ToString() ?? String.Empty,
                    RegEx = dgvR.Cells[1].Value?.ToString() ?? String.Empty,
                    RegExSub = dgvR.Cells[2].Value?.ToString() ?? String.Empty,
                };

                if (!String.IsNullOrEmpty(processor.Condition) || !String.IsNullOrEmpty(processor.RegEx) || !String.IsNullOrEmpty(processor.RegExSub))
                {
                    settings.Processors.Add(processor);
                }
            }

            File.WriteAllText(filePath, JsonConvert.SerializeObject(settings));
            lblCurrentSettingsFile.Text = Path.GetFileName(filePath);
            lblCurrentSettingsFile.Tag = filePath;
        }

        private void LoadSettings(string filePath)
        {
            var settings = JsonConvert.DeserializeObject<UserSettings>(File.ReadAllText(filePath));
            dgrProcRegExps.Rows.Clear();

            txtRegExPR.Text = settings.FilesListRegEx;
            txtRegExSubPR.Text = settings.FilesListRegExSub;
            BackupCheckBox.Checked = settings.MakeBackups;
            txtSearchResults.Lines = settings.FilesList.ToArray();

            for (int i = 0; i < settings.Processors.Count; i++)
            {
                dgrProcRegExps.Rows.Add();
                dgrProcRegExps.Rows[i].Cells[0].Value = settings.Processors[i].Condition;
                dgrProcRegExps.Rows[i].Cells[1].Value = settings.Processors[i].RegEx;
                dgrProcRegExps.Rows[i].Cells[2].Value = settings.Processors[i].RegExSub;
            }

            lblCurrentSettingsFile.Text = Path.GetFileName(filePath);
            lblCurrentSettingsFile.Tag = filePath;
        }

        private void LblCurrentSettingsFile_TextChanged(object sender, EventArgs e)
        {
            btnSave.Visible = !String.IsNullOrEmpty(lblCurrentSettingsFile.Text);
        }
    }
}
