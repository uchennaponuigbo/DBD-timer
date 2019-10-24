namespace DBD_Timer
{
    partial class frmTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.rdoSurvivor = new System.Windows.Forms.RadioButton();
            this.rdoKiller = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKiller = new System.Windows.Forms.TextBox();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.listMarkedTimes = new System.Windows.Forms.ListBox();
            this.btnMark = new System.Windows.Forms.Button();
            this.cboSurv1 = new System.Windows.Forms.ComboBox();
            this.cboSurv2 = new System.Windows.Forms.ComboBox();
            this.cboSurv3 = new System.Windows.Forms.ComboBox();
            this.cboSurv4 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnHatch = new System.Windows.Forms.Button();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.rdoSurv4 = new System.Windows.Forms.RadioButton();
            this.rdoSurv3 = new System.Windows.Forms.RadioButton();
            this.rdoSurv2 = new System.Windows.Forms.RadioButton();
            this.rdoSurv1 = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtOptional = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtModify = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(337, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(37, 24);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnd.Location = new System.Drawing.Point(432, 9);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(37, 23);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "End";
            this.btnEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // rdoSurvivor
            // 
            this.rdoSurvivor.AutoSize = true;
            this.rdoSurvivor.Location = new System.Drawing.Point(6, 54);
            this.rdoSurvivor.Name = "rdoSurvivor";
            this.rdoSurvivor.Size = new System.Drawing.Size(64, 17);
            this.rdoSurvivor.TabIndex = 3;
            this.rdoSurvivor.TabStop = true;
            this.rdoSurvivor.Text = "Survivor";
            this.rdoSurvivor.UseVisualStyleBackColor = true;
            // 
            // rdoKiller
            // 
            this.rdoKiller.AutoSize = true;
            this.rdoKiller.Location = new System.Drawing.Point(6, 77);
            this.rdoKiller.Name = "rdoKiller";
            this.rdoKiller.Size = new System.Drawing.Size(47, 17);
            this.rdoKiller.TabIndex = 4;
            this.rdoKiller.TabStop = true;
            this.rdoKiller.Text = "Killer";
            this.rdoKiller.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKiller);
            this.groupBox1.Controls.Add(this.rdoSurvivor);
            this.groupBox1.Controls.Add(this.txtRank);
            this.groupBox1.Controls.Add(this.rdoKiller);
            this.groupBox1.Controls.Add(this.lblRank);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 126);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Playing As:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Killer:";
            // 
            // txtKiller
            // 
            this.txtKiller.Location = new System.Drawing.Point(35, 100);
            this.txtKiller.MaxLength = 20;
            this.txtKiller.Name = "txtKiller";
            this.txtKiller.Size = new System.Drawing.Size(58, 20);
            this.txtKiller.TabIndex = 7;
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(43, 15);
            this.txtRank.MaxLength = 2;
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(27, 20);
            this.txtRank.TabIndex = 6;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(9, 18);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(33, 13);
            this.lblRank.TabIndex = 5;
            this.lblRank.Text = "Rank";
            // 
            // listMarkedTimes
            // 
            this.listMarkedTimes.ContextMenuStrip = this.contextMenuStrip1;
            this.listMarkedTimes.FormattingEnabled = true;
            this.listMarkedTimes.Location = new System.Drawing.Point(337, 35);
            this.listMarkedTimes.Name = "listMarkedTimes";
            this.listMarkedTimes.Size = new System.Drawing.Size(232, 121);
            this.listMarkedTimes.TabIndex = 7;
            this.listMarkedTimes.SelectedIndexChanged += new System.EventHandler(this.listMarkedTimes_SelectedIndexChanged);
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(102, 115);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(85, 23);
            this.btnMark.TabIndex = 8;
            this.btnMark.Text = "Mark Event";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // cboSurv1
            // 
            this.cboSurv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSurv1.FormattingEnabled = true;
            this.cboSurv1.Items.AddRange(new object[] {
            "Hooked",
            "Sacrficed",
            "Escaped",
            "Dead (Bled out)",
            "Dead (Memento Mori)",
            "Disconnected"});
            this.cboSurv1.Location = new System.Drawing.Point(85, 13);
            this.cboSurv1.Name = "cboSurv1";
            this.cboSurv1.Size = new System.Drawing.Size(89, 21);
            this.cboSurv1.TabIndex = 9;
            // 
            // cboSurv2
            // 
            this.cboSurv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSurv2.FormattingEnabled = true;
            this.cboSurv2.Items.AddRange(new object[] {
            "Hooked",
            "Sacrficed",
            "Escaped",
            "Dead (Bled out)",
            "Dead (Memento Mori)",
            "Disconnected"});
            this.cboSurv2.Location = new System.Drawing.Point(85, 37);
            this.cboSurv2.Name = "cboSurv2";
            this.cboSurv2.Size = new System.Drawing.Size(89, 21);
            this.cboSurv2.TabIndex = 10;
            // 
            // cboSurv3
            // 
            this.cboSurv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSurv3.FormattingEnabled = true;
            this.cboSurv3.Items.AddRange(new object[] {
            "Hooked",
            "Sacrficed",
            "Escaped",
            "Dead (Bled out)",
            "Dead (Memento Mori)",
            "Disconnected"});
            this.cboSurv3.Location = new System.Drawing.Point(85, 64);
            this.cboSurv3.Name = "cboSurv3";
            this.cboSurv3.Size = new System.Drawing.Size(89, 21);
            this.cboSurv3.TabIndex = 11;
            // 
            // cboSurv4
            // 
            this.cboSurv4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSurv4.FormattingEnabled = true;
            this.cboSurv4.Items.AddRange(new object[] {
            "Hooked",
            "Sacrficed",
            "Escaped",
            "Dead (Bled out)",
            "Dead (Memento Mori)",
            "Disconnected"});
            this.cboSurv4.Location = new System.Drawing.Point(85, 88);
            this.cboSurv4.Name = "cboSurv4";
            this.cboSurv4.Size = new System.Drawing.Size(89, 21);
            this.cboSurv4.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Controls.Add(this.btnHatch);
            this.groupBox2.Controls.Add(this.btnGenerator);
            this.groupBox2.Controls.Add(this.rdoSurv4);
            this.groupBox2.Controls.Add(this.cboSurv4);
            this.groupBox2.Controls.Add(this.rdoSurv3);
            this.groupBox2.Controls.Add(this.cboSurv3);
            this.groupBox2.Controls.Add(this.rdoSurv2);
            this.groupBox2.Controls.Add(this.cboSurv2);
            this.groupBox2.Controls.Add(this.rdoSurv1);
            this.groupBox2.Controls.Add(this.btnMark);
            this.groupBox2.Controls.Add(this.cboSurv1);
            this.groupBox2.Location = new System.Drawing.Point(117, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 171);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(102, 142);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(85, 23);
            this.btnTest.TabIndex = 22;
            this.btnTest.Text = "Reset";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnHatch
            // 
            this.btnHatch.Location = new System.Drawing.Point(6, 142);
            this.btnHatch.Name = "btnHatch";
            this.btnHatch.Size = new System.Drawing.Size(90, 23);
            this.btnHatch.TabIndex = 23;
            this.btnHatch.Text = "Hatch is Closed";
            this.btnHatch.UseVisualStyleBackColor = true;
            this.btnHatch.Click += new System.EventHandler(this.btnHatch_Click);
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(6, 115);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(90, 23);
            this.btnGenerator.TabIndex = 14;
            this.btnGenerator.Text = "Finished Gen.";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // rdoSurv4
            // 
            this.rdoSurv4.AutoSize = true;
            this.rdoSurv4.Location = new System.Drawing.Point(6, 91);
            this.rdoSurv4.Name = "rdoSurv4";
            this.rdoSurv4.Size = new System.Drawing.Size(73, 17);
            this.rdoSurv4.TabIndex = 3;
            this.rdoSurv4.TabStop = true;
            this.rdoSurv4.Text = "Survivor 4";
            this.rdoSurv4.UseVisualStyleBackColor = true;
            // 
            // rdoSurv3
            // 
            this.rdoSurv3.AutoSize = true;
            this.rdoSurv3.Location = new System.Drawing.Point(6, 64);
            this.rdoSurv3.Name = "rdoSurv3";
            this.rdoSurv3.Size = new System.Drawing.Size(73, 17);
            this.rdoSurv3.TabIndex = 2;
            this.rdoSurv3.TabStop = true;
            this.rdoSurv3.Text = "Survivor 3";
            this.rdoSurv3.UseVisualStyleBackColor = true;
            // 
            // rdoSurv2
            // 
            this.rdoSurv2.AutoSize = true;
            this.rdoSurv2.Location = new System.Drawing.Point(6, 40);
            this.rdoSurv2.Name = "rdoSurv2";
            this.rdoSurv2.Size = new System.Drawing.Size(73, 17);
            this.rdoSurv2.TabIndex = 1;
            this.rdoSurv2.TabStop = true;
            this.rdoSurv2.Text = "Survivor 2";
            this.rdoSurv2.UseVisualStyleBackColor = true;
            // 
            // rdoSurv1
            // 
            this.rdoSurv1.AutoSize = true;
            this.rdoSurv1.Location = new System.Drawing.Point(6, 17);
            this.rdoSurv1.Name = "rdoSurv1";
            this.rdoSurv1.Size = new System.Drawing.Size(73, 17);
            this.rdoSurv1.TabIndex = 0;
            this.rdoSurv1.TabStop = true;
            this.rdoSurv1.Text = "Survivor 1";
            this.rdoSurv1.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 141);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(99, 23);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtOptional
            // 
            this.txtOptional.Location = new System.Drawing.Point(337, 194);
            this.txtOptional.MaxLength = 400;
            this.txtOptional.Name = "txtOptional";
            this.txtOptional.Size = new System.Drawing.Size(232, 20);
            this.txtOptional.TabIndex = 15;
            this.txtOptional.Enter += new System.EventHandler(this.txtOptional_Enter_1);
            this.txtOptional.Leave += new System.EventHandler(this.txtOptional_Leave);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(380, 9);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(46, 23);
            this.btnPause.TabIndex = 16;
            this.btnPause.Text = "Pause";
            this.btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(12, 183);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(298, 32);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "N/A";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(337, 161);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "Modify/Add";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtModify
            // 
            this.txtModify.Location = new System.Drawing.Point(418, 163);
            this.txtModify.Name = "txtModify";
            this.txtModify.Size = new System.Drawing.Size(151, 20);
            this.txtModify.TabIndex = 19;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(479, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 24);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "00:00:00";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmTimer
            // 
            this.AcceptButton = this.btnMark;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnEnd;
            this.ClientSize = new System.Drawing.Size(581, 224);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtModify);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.txtOptional);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listMarkedTimes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Name = "frmTimer";
            this.Text = "Dead By Daylight Match Timer";
            this.Load += new System.EventHandler(this.frmTimer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.RadioButton rdoSurvivor;
        private System.Windows.Forms.RadioButton rdoKiller;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.ListBox listMarkedTimes;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.ComboBox cboSurv1;
        private System.Windows.Forms.ComboBox cboSurv2;
        private System.Windows.Forms.ComboBox cboSurv3;
        private System.Windows.Forms.ComboBox cboSurv4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKiller;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoSurv4;
        private System.Windows.Forms.RadioButton rdoSurv3;
        private System.Windows.Forms.RadioButton rdoSurv2;
        private System.Windows.Forms.RadioButton rdoSurv1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtOptional;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtModify;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.Button btnHatch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

