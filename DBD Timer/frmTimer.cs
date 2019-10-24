using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace DBD_Timer
{   
    public partial class frmTimer : Form
    {
        private sbyte survCounter1 = 0;
        private sbyte survCounter2 = 0;
        private sbyte survCounter3 = 0;
        private sbyte survCounter4 = 0;

        private Stopwatch stopwatch = new Stopwatch();

        private Thread starter;
        private bool isThreadRunning = false;

        public frmTimer()
        {
            InitializeComponent();
            UpdateTime();
        }     

        private void btnStart_Click(object sender, EventArgs e)
        {
            //stopwatch.Start();
            //timer1.Enabled = true;

            isThreadRunning = true;
            StartThread();
            DisableOptionsOnTimerStart();                      
        }

        private void StartThread()
        {
            starter = new Thread(new ThreadStart(HandleTime));
            starter.Start();
        }

        private void HandleTime()
        {
            TimeSpan timespan;
            stopwatch.Start();
            while (isThreadRunning)
            {
                timespan = stopwatch.Elapsed;
                //using invoke to update the label which is in the original thread 
                //and avoid a cross thread exception
                if (InvokeRequired)
                {
                    //read up on lamda functions if you don't know what this is doing
                    Invoke(new MethodInvoker(() =>
                        lblTime.Text = String.Format("{0:00}:{1:00}.{2:00}", 
                        timespan.Minutes, timespan.Seconds, timespan.Milliseconds / 10
                        )));
                }
                else
                {
                    label1.Text = String.Format("{0:00}:{1:00}.{2:00}",
                        timespan.Minutes, timespan.Seconds, timespan.Milliseconds / 10);
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(/*timer1.Enabled*/isThreadRunning == true)
            {
                stopwatch.Stop();
                //timer1.Enabled = false;
                btnPause.Text = "Cont.";
                isThreadRunning = false;
            }
            else
            {
                //stopwatch.Start();
                //timer1.Enabled = true;
                btnPause.Text = "Pause";
                isThreadRunning = true;
                StartThread();
            }
            
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            //timer1.Enabled = false;
            isThreadRunning = false;
            DisableOptionsOnTimerEnd();            
        }

        private void ResetTime()
        {       
            stopwatch.Reset();
            //timer1.Enabled = false;
            isThreadRunning = false;
        }

        private void UpdateTime()
        {
            TimeSpan elasped = stopwatch.Elapsed;
            lblTime.Text = String.Format("{0:00}:{1:00}.{2:00}", elasped.TotalMinutes,
                elasped.TotalSeconds, elasped.TotalMilliseconds);
            
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    UpdateTime();
        //}

        private void btnGenerate_Click(object sender, EventArgs e)
        {           
            var markedTimesList = listMarkedTimes.Items.Cast<String>().ToList();

            frmReport form = new frmReport();            
            form.CopyDataToRichTextBox(GetPlayerData(), markedTimesList);
            form.ShowDialog();
        }

        private string GetPlayerData()
        {
            string rank = $"{lblRank.Text}: {txtRank.Text} |";            
            string matchTime = $"Trial Time: {lblTime.Text}";
            string character = "";

            if (rdoSurvivor.Checked)
                character = "Played As: " + rdoSurvivor.Text;
            else if (rdoKiller.Checked)
                character = $"Played as the {rdoKiller.Text}: {txtKiller.Text}";

            string summary = 
                $"{matchTime}{Environment.NewLine}{rank} {character}{Environment.NewLine}{txtOptional.Text}{Environment.NewLine}";
            return summary;
        }

        private void LoadSettings()
        {
            cboSurv1.SelectedIndex = 0;
            cboSurv2.SelectedIndex = 0;
            cboSurv3.SelectedIndex = 0;
            cboSurv4.SelectedIndex = 0;

            rdoSurvivor.Checked = true;
            rdoSurv1.Checked = true;
            txtRank.Text = "20";
            txtOptional.Text = "Optional Match Ending Description";
            txtOptional.ForeColor = Color.Gray;
            lblMessage.Text = "Press the Start button to began the timer.";

            btnGenerate.Enabled = false;
            btnPause.Enabled = false;
            btnEnd.Enabled = false;
            DisableGroupBox();
            btnTest.Enabled = false;
            btnModify.Enabled = false;
        }

        private void DisableOptionsOnTimerStart()
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnEnd.Enabled = true;
            btnMark.Enabled = true;
            EnableGroupBox();
            lblMessage.Text = "The Trial has begun.";
            btnTest.Enabled = false;
            btnModify.Enabled = true;
        }

        private void DisableOptionsOnTimerEnd()
        {
            lblMessage.Text = "This Trial is Over. You can now generate a report to save to text file" +
                " or to copy and paste the summary to the Entity.";

            btnEnd.Enabled = false;
            btnPause.Enabled = false;
            btnMark.Enabled = false;
            DisableGroupBox();           

            btnGenerate.Enabled = true;
            btnGenerate.Focus();
            btnPause.Text = "Pause";
            btnTest.Enabled = true;
        }

        private void DisableGroupBox() //can't use groupbox2.enabled = false and enabled a control to be true in there
        { //need to have the reset button enabled
            cboSurv1.Enabled = false;
            cboSurv2.Enabled = false;
            cboSurv3.Enabled = false;
            cboSurv4.Enabled = false;

            rdoSurv1.Enabled = false;
            rdoSurv2.Enabled = false;
            rdoSurv3.Enabled = false;
            rdoSurv4.Enabled = false;

            btnGenerator.Enabled = false;
            btnHatch.Enabled = false;
            btnMark.Enabled = false;
        }

        private void EnableGroupBox() //groupbox 2
        {
            cboSurv1.Enabled = true;
            cboSurv2.Enabled = true;
            cboSurv3.Enabled = true;
            cboSurv4.Enabled = true;

            rdoSurv1.Enabled = true;
            rdoSurv2.Enabled = true;
            rdoSurv3.Enabled = true;
            rdoSurv4.Enabled = true;

            btnGenerator.Enabled = true;
            btnHatch.Enabled = true;
            btnMark.Enabled = true;
        }

        public void ResetControls()
        {
            ResetTime();
            UpdateTime();
            cboSurv1.SelectedIndex = 0;
            cboSurv2.SelectedIndex = 0;
            cboSurv3.SelectedIndex = 0;
            cboSurv4.SelectedIndex = 0;

            groupBox1.Enabled = true;

            rdoSurv1.Checked = true;

            btnGenerate.Enabled = false;
            btnEnd.Enabled = false;
            btnStart.Enabled = true;
            btnStart.Focus();
            btnTest.Enabled = false;
            btnModify.Enabled = false;

            listMarkedTimes.Items.Clear();
            txtOptional.Text = "Optional Match Ending Description";
            txtOptional.ForeColor = Color.Gray;
            lblMessage.Text = "Press the Start button to began the timer.";

            survCounter1 = 0;
            survCounter2 = 0;
            survCounter3 = 0;
            survCounter4 = 0;
            genCount = 5;
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private string GetTime() => $"{lblTime.Text} |";

        private void btnMark_Click(object sender, EventArgs e)
        {
            if(rdoSurv1.Checked == true)
            {
                if(cboSurv1.SelectedIndex == 0 && survCounter1 < 2)
                {
                    survCounter1++;
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv1.Text} {cboSurv1.Text}: {survCounter1}");
                }
                else if(cboSurv1.SelectedIndex == 0 && survCounter1 == 2)
                {
                    cboSurv1.SelectedIndex = 1;
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv1.Text} {cboSurv1.Text}");
                    cboSurv1.Enabled = false;
                    rdoSurv1.Enabled = false;
                    rdoSurv1.Checked = false;
                }
                else if(cboSurv1.SelectedIndex != 0 || cboSurv1.SelectedIndex != 1)
                {
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv1.Text} {cboSurv1.Text}");
                    cboSurv1.Enabled = false;
                    rdoSurv1.Enabled = false;
                    rdoSurv1.Checked = false;
                }
            }

            if(rdoSurv2.Checked == true)
            {
                if (cboSurv2.SelectedIndex == 0 && survCounter2 < 2)
                {
                    survCounter2++;
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv2.Text} {cboSurv2.Text}: {survCounter2}");
                }
                else if (cboSurv2.SelectedIndex == 0 && survCounter2 == 2)
                {
                    cboSurv2.SelectedIndex = 1;
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv2.Text} {cboSurv2.Text}");
                    cboSurv2.Enabled = false;
                    rdoSurv2.Enabled = false;
                    rdoSurv2.Checked = false;
                }
                else if (cboSurv2.SelectedIndex != 0 || cboSurv2.SelectedIndex != 1)
                {
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv2.Text} {cboSurv2.Text}");
                    cboSurv2.Enabled = false;
                    rdoSurv2.Enabled = false;
                    rdoSurv2.Checked = false;
                }
            }

            if (rdoSurv3.Checked == true)
            {
                if (cboSurv3.SelectedIndex == 0 && survCounter3 < 2)
                {
                    survCounter3++;
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv3.Text} {cboSurv3.Text}: {survCounter3}");
                }
                else if (cboSurv3.SelectedIndex == 0 && survCounter3 == 2)
                {
                    cboSurv3.SelectedIndex = 1;
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv3.Text} {cboSurv3.Text}");
                    cboSurv3.Enabled = false;
                    rdoSurv3.Enabled = false;
                    rdoSurv3.Checked = false;
                }
                else if (cboSurv3.SelectedIndex != 0 || cboSurv3.SelectedIndex != 1)
                {
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv3.Text} {cboSurv3.Text}");
                    cboSurv3.Enabled = false;
                    rdoSurv3.Enabled = false;
                    rdoSurv3.Checked = false;
                }
            }

            if (rdoSurv4.Checked == true)
            {
                if (cboSurv4.SelectedIndex == 0 && survCounter4 < 2)
                {
                    survCounter4++;
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv4.Text} {cboSurv4.Text}: {survCounter4}");
                }
                else if (cboSurv4.SelectedIndex == 0 && survCounter4 == 2)
                {
                    cboSurv4.SelectedIndex = 1;
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv4.Text} {cboSurv4.Text}");
                    cboSurv4.Enabled = false;
                    rdoSurv4.Enabled = false;
                    rdoSurv4.Checked = false;
                }
                else if (cboSurv4.SelectedIndex != 0 || cboSurv4.SelectedIndex != 1)
                {
                    listMarkedTimes.Items.Add($"{GetTime()} {rdoSurv4.Text} {cboSurv4.Text}");
                    cboSurv4.Enabled = false;
                    rdoSurv4.Enabled = false;
                    rdoSurv4.Checked = false;
                }
            }
        }

        private void btnHatch_Click(object sender, EventArgs e)
        {
            listMarkedTimes.Items.Add($"{GetTime()} {btnHatch.Text}");            
            btnHatch.Enabled = false;
            btnGenerator.Enabled = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormatListBox.ChangeValue(listMarkedTimes, txtModify, GetTime());           
        }

        private void listMarkedTimes_SelectedIndexChanged(object sender, EventArgs e)
        {           
            FormatListBox.TextBoxtoListIndex(listMarkedTimes, txtModify);
        }
       
        private void btnTest_Click(object sender, EventArgs e)
        {
            //named "btnTest" for testing the other form without starting and ending the timer
            //frmReport form = new frmReport();
            //form.Show();
            ResetControls();
        }

        private byte genCount = 5;
        private void btnGenerator_Click(object sender, EventArgs e)
        {
            genCount--;
            if(genCount == 1)
                listMarkedTimes.Items.Add($"{GetTime()} {genCount} generator left.");
            else if(genCount == 0)
            {
                listMarkedTimes.Items.Add($"{GetTime()} Exit Gates powered!");
                btnGenerator.Enabled = false;
            }
            else
                listMarkedTimes.Items.Add($"{GetTime()} {genCount} generators left.");           
        }           

        private void txtOptional_Enter_1(object sender, EventArgs e)
        {
            if (txtOptional.Text == "Optional Match Ending Description")
            {
                txtOptional.Text = "";
                txtOptional.ForeColor = Color.Black;
            }
        }

        private void txtOptional_Leave(object sender, EventArgs e)
        {
            if (txtOptional.Text == "")
            {
                txtOptional.Text = "Optional Match Ending Description";
                txtOptional.ForeColor = Color.Gray;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatListBox.DeleteIndex(listMarkedTimes, txtModify);
        }
    }
}
