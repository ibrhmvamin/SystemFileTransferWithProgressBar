using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace SystemFileTransferWithProgressBar
{
    public partial class Form1 : Form
    {
        public Thread thread = null;  
        public string from { get; set; }
        public string to { get; set; }
        public Form1()
        {
            InitializeComponent();
        }     

        private void filesbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog=new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                from = fileDialog.FileName;
                fromtxtbox.Text = from;
            }
        }

        private void tofilesbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                to = fileDialog.FileName;
                totxtbox.Text = to;
            }
        }

        private void copybtn_Click(object sender, EventArgs e)
        {    
            thread = new Thread(() =>
            {
                long fileSize = new FileInfo(from).Length;
                long totalBytesCopied = 0;

                FileMode fileMode = File.Exists(to) ? FileMode.Create : FileMode.OpenOrCreate;

                using (FileStream sourceStream = File.OpenRead(from))
                using (FileStream destinationStream = new FileStream(to, fileMode))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;

                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {                    
                        Thread.Sleep(100);
                        destinationStream.Write(buffer, 0, bytesRead);

                        totalBytesCopied += bytesRead;

                        int progressPercentage = (int)((totalBytesCopied * 100) / fileSize);
                      
                        progressBar1.Value = progressPercentage;    
                    }
                    if (progressBar1.Value == 100)
                    {
                        MessageBox.Show("Copying process finished");
                    }
                }
            });

            thread.Start();
        }

        private void suspendbtn_Click(object sender, EventArgs e)
        {
            thread.Suspend();
        }

        private void resumebtn_Click(object sender, EventArgs e)
        {
            thread.Resume();   
        }
        private void abortbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aborted","Abort",MessageBoxButtons.OK,MessageBoxIcon.Error);
            thread.Abort();
        }
    }
}
