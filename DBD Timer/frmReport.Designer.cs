namespace DBD_Timer
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.richtxtReport = new System.Windows.Forms.RichTextBox();
            this.btnFinishClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkMore = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAppend = new System.Windows.Forms.Button();
            this.listSurv1Perks = new System.Windows.Forms.ListBox();
            this.listSurv1AddOns = new System.Windows.Forms.ListBox();
            this.txtSurv1Perks = new System.Windows.Forms.TextBox();
            this.txtSurv1AddOns = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSurv1Perks = new System.Windows.Forms.Button();
            this.btnSurv1AddOns = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSurv2Perks = new System.Windows.Forms.Button();
            this.listSurv2Perks = new System.Windows.Forms.ListBox();
            this.btnSurv2AddOns = new System.Windows.Forms.Button();
            this.listSurv2AddOns = new System.Windows.Forms.ListBox();
            this.txtSurv2Perks = new System.Windows.Forms.TextBox();
            this.txtSurv2AddOns = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSurv3Perks = new System.Windows.Forms.Button();
            this.listSurv3Perks = new System.Windows.Forms.ListBox();
            this.btnSurv3AddOns = new System.Windows.Forms.Button();
            this.listSurv3AddOns = new System.Windows.Forms.ListBox();
            this.txtSurv3Perks = new System.Windows.Forms.TextBox();
            this.txtSurv3AddOns = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSurv4Perks = new System.Windows.Forms.Button();
            this.listSurv4Perks = new System.Windows.Forms.ListBox();
            this.btnSurv4AddOns = new System.Windows.Forms.Button();
            this.listSurv4AddOns = new System.Windows.Forms.ListBox();
            this.txtSurv4Perks = new System.Windows.Forms.TextBox();
            this.txtSurv4AddOns = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnKillerPerks = new System.Windows.Forms.Button();
            this.listKillerPerks = new System.Windows.Forms.ListBox();
            this.btnKillerAddOns = new System.Windows.Forms.Button();
            this.listKillerAddOns = new System.Windows.Forms.ListBox();
            this.txtKillerPerks = new System.Windows.Forms.TextBox();
            this.txtKillerAddOns = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richtxtReport
            // 
            this.richtxtReport.Location = new System.Drawing.Point(12, 95);
            this.richtxtReport.Name = "richtxtReport";
            this.richtxtReport.ReadOnly = true;
            this.richtxtReport.Size = new System.Drawing.Size(236, 199);
            this.richtxtReport.TabIndex = 0;
            this.richtxtReport.Text = "";
            // 
            // btnFinishClose
            // 
            this.btnFinishClose.Location = new System.Drawing.Point(155, 59);
            this.btnFinishClose.Name = "btnFinishClose";
            this.btnFinishClose.Size = new System.Drawing.Size(93, 23);
            this.btnFinishClose.TabIndex = 2;
            this.btnFinishClose.Text = "Finish and Close";
            this.btnFinishClose.UseVisualStyleBackColor = true;
            this.btnFinishClose.Click += new System.EventHandler(this.btnFinishClose_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save to Text File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkMore
            // 
            this.chkMore.AutoSize = true;
            this.chkMore.Location = new System.Drawing.Point(12, 9);
            this.chkMore.Name = "chkMore";
            this.chkMore.Size = new System.Drawing.Size(248, 17);
            this.chkMore.TabIndex = 23;
            this.chkMore.Text = "(Optional) Include Perk and Add-On information";
            this.chkMore.UseVisualStyleBackColor = true;
            this.chkMore.CheckedChanged += new System.EventHandler(this.chkMore_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 78);
            this.label1.TabIndex = 24;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(790, 271);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 23);
            this.btnAppend.TabIndex = 25;
            this.btnAppend.Text = "Append All";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // listSurv1Perks
            // 
            this.listSurv1Perks.ContextMenuStrip = this.contextMenuStrip1;
            this.listSurv1Perks.FormattingEnabled = true;
            this.listSurv1Perks.Location = new System.Drawing.Point(89, 12);
            this.listSurv1Perks.Name = "listSurv1Perks";
            this.listSurv1Perks.Size = new System.Drawing.Size(105, 56);
            this.listSurv1Perks.TabIndex = 26;
            this.listSurv1Perks.SelectedIndexChanged += new System.EventHandler(this.listSurv1Perks_SelectedIndexChanged);
            // 
            // listSurv1AddOns
            // 
            this.listSurv1AddOns.ContextMenuStrip = this.contextMenuStrip1;
            this.listSurv1AddOns.FormattingEnabled = true;
            this.listSurv1AddOns.Location = new System.Drawing.Point(89, 91);
            this.listSurv1AddOns.Name = "listSurv1AddOns";
            this.listSurv1AddOns.Size = new System.Drawing.Size(105, 30);
            this.listSurv1AddOns.TabIndex = 30;
            this.listSurv1AddOns.SelectedIndexChanged += new System.EventHandler(this.listSurv1AddOns_SelectedIndexChanged);
            // 
            // txtSurv1Perks
            // 
            this.txtSurv1Perks.Location = new System.Drawing.Point(6, 41);
            this.txtSurv1Perks.Name = "txtSurv1Perks";
            this.txtSurv1Perks.Size = new System.Drawing.Size(62, 20);
            this.txtSurv1Perks.TabIndex = 34;
            // 
            // txtSurv1AddOns
            // 
            this.txtSurv1AddOns.Location = new System.Drawing.Point(6, 101);
            this.txtSurv1AddOns.Name = "txtSurv1AddOns";
            this.txtSurv1AddOns.Size = new System.Drawing.Size(62, 20);
            this.txtSurv1AddOns.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSurv1Perks);
            this.groupBox1.Controls.Add(this.listSurv1Perks);
            this.groupBox1.Controls.Add(this.btnSurv1AddOns);
            this.groupBox1.Controls.Add(this.listSurv1AddOns);
            this.groupBox1.Controls.Add(this.txtSurv1Perks);
            this.groupBox1.Controls.Add(this.txtSurv1AddOns);
            this.groupBox1.Location = new System.Drawing.Point(266, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 131);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Survivor 1";
            // 
            // btnSurv1Perks
            // 
            this.btnSurv1Perks.Location = new System.Drawing.Point(6, 12);
            this.btnSurv1Perks.Name = "btnSurv1Perks";
            this.btnSurv1Perks.Size = new System.Drawing.Size(59, 23);
            this.btnSurv1Perks.TabIndex = 43;
            this.btnSurv1Perks.Text = "Add Perk";
            this.btnSurv1Perks.UseVisualStyleBackColor = true;
            this.btnSurv1Perks.Click += new System.EventHandler(this.btnSurv1Perks_Click);
            // 
            // btnSurv1AddOns
            // 
            this.btnSurv1AddOns.Location = new System.Drawing.Point(6, 72);
            this.btnSurv1AddOns.Name = "btnSurv1AddOns";
            this.btnSurv1AddOns.Size = new System.Drawing.Size(77, 23);
            this.btnSurv1AddOns.TabIndex = 44;
            this.btnSurv1AddOns.Text = "Add Add-On";
            this.btnSurv1AddOns.UseVisualStyleBackColor = true;
            this.btnSurv1AddOns.Click += new System.EventHandler(this.btnSurv1AddOns_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSurv2Perks);
            this.groupBox2.Controls.Add(this.listSurv2Perks);
            this.groupBox2.Controls.Add(this.btnSurv2AddOns);
            this.groupBox2.Controls.Add(this.listSurv2AddOns);
            this.groupBox2.Controls.Add(this.txtSurv2Perks);
            this.groupBox2.Controls.Add(this.txtSurv2AddOns);
            this.groupBox2.Location = new System.Drawing.Point(266, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 131);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Survivor 2";
            // 
            // btnSurv2Perks
            // 
            this.btnSurv2Perks.Location = new System.Drawing.Point(6, 12);
            this.btnSurv2Perks.Name = "btnSurv2Perks";
            this.btnSurv2Perks.Size = new System.Drawing.Size(59, 23);
            this.btnSurv2Perks.TabIndex = 43;
            this.btnSurv2Perks.Text = "Add Perk";
            this.btnSurv2Perks.UseVisualStyleBackColor = true;
            this.btnSurv2Perks.Click += new System.EventHandler(this.btnSurv2Perks_Click);
            // 
            // listSurv2Perks
            // 
            this.listSurv2Perks.ContextMenuStrip = this.contextMenuStrip1;
            this.listSurv2Perks.FormattingEnabled = true;
            this.listSurv2Perks.Location = new System.Drawing.Point(89, 12);
            this.listSurv2Perks.Name = "listSurv2Perks";
            this.listSurv2Perks.Size = new System.Drawing.Size(105, 56);
            this.listSurv2Perks.TabIndex = 26;
            this.listSurv2Perks.SelectedIndexChanged += new System.EventHandler(this.listSurv2Perks_SelectedIndexChanged);
            // 
            // btnSurv2AddOns
            // 
            this.btnSurv2AddOns.Location = new System.Drawing.Point(6, 72);
            this.btnSurv2AddOns.Name = "btnSurv2AddOns";
            this.btnSurv2AddOns.Size = new System.Drawing.Size(77, 23);
            this.btnSurv2AddOns.TabIndex = 44;
            this.btnSurv2AddOns.Text = "Add Add-On";
            this.btnSurv2AddOns.UseVisualStyleBackColor = true;
            this.btnSurv2AddOns.Click += new System.EventHandler(this.btnSurv2AddOns_Click);
            // 
            // listSurv2AddOns
            // 
            this.listSurv2AddOns.ContextMenuStrip = this.contextMenuStrip1;
            this.listSurv2AddOns.FormattingEnabled = true;
            this.listSurv2AddOns.Location = new System.Drawing.Point(89, 91);
            this.listSurv2AddOns.Name = "listSurv2AddOns";
            this.listSurv2AddOns.Size = new System.Drawing.Size(105, 30);
            this.listSurv2AddOns.TabIndex = 30;
            this.listSurv2AddOns.SelectedIndexChanged += new System.EventHandler(this.listSurv2AddOns_SelectedIndexChanged);
            // 
            // txtSurv2Perks
            // 
            this.txtSurv2Perks.Location = new System.Drawing.Point(6, 41);
            this.txtSurv2Perks.Name = "txtSurv2Perks";
            this.txtSurv2Perks.Size = new System.Drawing.Size(62, 20);
            this.txtSurv2Perks.TabIndex = 34;
            // 
            // txtSurv2AddOns
            // 
            this.txtSurv2AddOns.Location = new System.Drawing.Point(6, 101);
            this.txtSurv2AddOns.Name = "txtSurv2AddOns";
            this.txtSurv2AddOns.Size = new System.Drawing.Size(62, 20);
            this.txtSurv2AddOns.TabIndex = 38;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSurv3Perks);
            this.groupBox3.Controls.Add(this.listSurv3Perks);
            this.groupBox3.Controls.Add(this.btnSurv3AddOns);
            this.groupBox3.Controls.Add(this.listSurv3AddOns);
            this.groupBox3.Controls.Add(this.txtSurv3Perks);
            this.groupBox3.Controls.Add(this.txtSurv3AddOns);
            this.groupBox3.Location = new System.Drawing.Point(470, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 131);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Survivor 3";
            // 
            // btnSurv3Perks
            // 
            this.btnSurv3Perks.Location = new System.Drawing.Point(6, 12);
            this.btnSurv3Perks.Name = "btnSurv3Perks";
            this.btnSurv3Perks.Size = new System.Drawing.Size(59, 23);
            this.btnSurv3Perks.TabIndex = 43;
            this.btnSurv3Perks.Text = "Add Perk";
            this.btnSurv3Perks.UseVisualStyleBackColor = true;
            this.btnSurv3Perks.Click += new System.EventHandler(this.btnSurv3Perks_Click);
            // 
            // listSurv3Perks
            // 
            this.listSurv3Perks.ContextMenuStrip = this.contextMenuStrip1;
            this.listSurv3Perks.FormattingEnabled = true;
            this.listSurv3Perks.Location = new System.Drawing.Point(89, 12);
            this.listSurv3Perks.Name = "listSurv3Perks";
            this.listSurv3Perks.Size = new System.Drawing.Size(105, 56);
            this.listSurv3Perks.TabIndex = 26;
            this.listSurv3Perks.SelectedIndexChanged += new System.EventHandler(this.listSurv3Perks_SelectedIndexChanged);
            // 
            // btnSurv3AddOns
            // 
            this.btnSurv3AddOns.Location = new System.Drawing.Point(6, 72);
            this.btnSurv3AddOns.Name = "btnSurv3AddOns";
            this.btnSurv3AddOns.Size = new System.Drawing.Size(77, 23);
            this.btnSurv3AddOns.TabIndex = 44;
            this.btnSurv3AddOns.Text = "Add Add-On";
            this.btnSurv3AddOns.UseVisualStyleBackColor = true;
            this.btnSurv3AddOns.Click += new System.EventHandler(this.btnSurv3AddOns_Click);
            // 
            // listSurv3AddOns
            // 
            this.listSurv3AddOns.ContextMenuStrip = this.contextMenuStrip1;
            this.listSurv3AddOns.FormattingEnabled = true;
            this.listSurv3AddOns.Location = new System.Drawing.Point(89, 91);
            this.listSurv3AddOns.Name = "listSurv3AddOns";
            this.listSurv3AddOns.Size = new System.Drawing.Size(105, 30);
            this.listSurv3AddOns.TabIndex = 30;
            this.listSurv3AddOns.SelectedIndexChanged += new System.EventHandler(this.listSurv3AddOns_SelectedIndexChanged);
            // 
            // txtSurv3Perks
            // 
            this.txtSurv3Perks.Location = new System.Drawing.Point(6, 41);
            this.txtSurv3Perks.Name = "txtSurv3Perks";
            this.txtSurv3Perks.Size = new System.Drawing.Size(62, 20);
            this.txtSurv3Perks.TabIndex = 34;
            // 
            // txtSurv3AddOns
            // 
            this.txtSurv3AddOns.Location = new System.Drawing.Point(6, 101);
            this.txtSurv3AddOns.Name = "txtSurv3AddOns";
            this.txtSurv3AddOns.Size = new System.Drawing.Size(62, 20);
            this.txtSurv3AddOns.TabIndex = 38;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSurv4Perks);
            this.groupBox4.Controls.Add(this.listSurv4Perks);
            this.groupBox4.Controls.Add(this.btnSurv4AddOns);
            this.groupBox4.Controls.Add(this.listSurv4AddOns);
            this.groupBox4.Controls.Add(this.txtSurv4Perks);
            this.groupBox4.Controls.Add(this.txtSurv4AddOns);
            this.groupBox4.Location = new System.Drawing.Point(470, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 131);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Survivor 4";
            // 
            // btnSurv4Perks
            // 
            this.btnSurv4Perks.Location = new System.Drawing.Point(6, 12);
            this.btnSurv4Perks.Name = "btnSurv4Perks";
            this.btnSurv4Perks.Size = new System.Drawing.Size(59, 23);
            this.btnSurv4Perks.TabIndex = 43;
            this.btnSurv4Perks.Text = "Add Perk";
            this.btnSurv4Perks.UseVisualStyleBackColor = true;
            this.btnSurv4Perks.Click += new System.EventHandler(this.btnSurv4Perks_Click);
            // 
            // listSurv4Perks
            // 
            this.listSurv4Perks.ContextMenuStrip = this.contextMenuStrip1;
            this.listSurv4Perks.FormattingEnabled = true;
            this.listSurv4Perks.Location = new System.Drawing.Point(89, 12);
            this.listSurv4Perks.Name = "listSurv4Perks";
            this.listSurv4Perks.Size = new System.Drawing.Size(105, 56);
            this.listSurv4Perks.TabIndex = 26;
            this.listSurv4Perks.SelectedIndexChanged += new System.EventHandler(this.listSurv4Perks_SelectedIndexChanged);
            // 
            // btnSurv4AddOns
            // 
            this.btnSurv4AddOns.Location = new System.Drawing.Point(6, 72);
            this.btnSurv4AddOns.Name = "btnSurv4AddOns";
            this.btnSurv4AddOns.Size = new System.Drawing.Size(77, 23);
            this.btnSurv4AddOns.TabIndex = 44;
            this.btnSurv4AddOns.Text = "Add Add-On";
            this.btnSurv4AddOns.UseVisualStyleBackColor = true;
            this.btnSurv4AddOns.Click += new System.EventHandler(this.btnSurv4AddOns_Click);
            // 
            // listSurv4AddOns
            // 
            this.listSurv4AddOns.ContextMenuStrip = this.contextMenuStrip1;
            this.listSurv4AddOns.FormattingEnabled = true;
            this.listSurv4AddOns.Location = new System.Drawing.Point(89, 91);
            this.listSurv4AddOns.Name = "listSurv4AddOns";
            this.listSurv4AddOns.Size = new System.Drawing.Size(105, 30);
            this.listSurv4AddOns.TabIndex = 30;
            this.listSurv4AddOns.SelectedIndexChanged += new System.EventHandler(this.listSurv4AddOns_SelectedIndexChanged);
            // 
            // txtSurv4Perks
            // 
            this.txtSurv4Perks.Location = new System.Drawing.Point(6, 41);
            this.txtSurv4Perks.Name = "txtSurv4Perks";
            this.txtSurv4Perks.Size = new System.Drawing.Size(62, 20);
            this.txtSurv4Perks.TabIndex = 34;
            // 
            // txtSurv4AddOns
            // 
            this.txtSurv4AddOns.Location = new System.Drawing.Point(6, 101);
            this.txtSurv4AddOns.Name = "txtSurv4AddOns";
            this.txtSurv4AddOns.Size = new System.Drawing.Size(62, 20);
            this.txtSurv4AddOns.TabIndex = 38;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnKillerPerks);
            this.groupBox5.Controls.Add(this.listKillerPerks);
            this.groupBox5.Controls.Add(this.btnKillerAddOns);
            this.groupBox5.Controls.Add(this.listKillerAddOns);
            this.groupBox5.Controls.Add(this.txtKillerPerks);
            this.groupBox5.Controls.Add(this.txtKillerAddOns);
            this.groupBox5.Location = new System.Drawing.Point(674, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(198, 131);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Killer";
            // 
            // btnKillerPerks
            // 
            this.btnKillerPerks.Location = new System.Drawing.Point(6, 12);
            this.btnKillerPerks.Name = "btnKillerPerks";
            this.btnKillerPerks.Size = new System.Drawing.Size(59, 23);
            this.btnKillerPerks.TabIndex = 43;
            this.btnKillerPerks.Text = "Add Perk";
            this.btnKillerPerks.UseVisualStyleBackColor = true;
            this.btnKillerPerks.Click += new System.EventHandler(this.btnKillerPerks_Click);
            // 
            // listKillerPerks
            // 
            this.listKillerPerks.ContextMenuStrip = this.contextMenuStrip1;
            this.listKillerPerks.FormattingEnabled = true;
            this.listKillerPerks.Location = new System.Drawing.Point(89, 12);
            this.listKillerPerks.Name = "listKillerPerks";
            this.listKillerPerks.Size = new System.Drawing.Size(105, 56);
            this.listKillerPerks.TabIndex = 26;
            this.listKillerPerks.SelectedIndexChanged += new System.EventHandler(this.listKillerPerks_SelectedIndexChanged);
            // 
            // btnKillerAddOns
            // 
            this.btnKillerAddOns.Location = new System.Drawing.Point(6, 72);
            this.btnKillerAddOns.Name = "btnKillerAddOns";
            this.btnKillerAddOns.Size = new System.Drawing.Size(77, 23);
            this.btnKillerAddOns.TabIndex = 44;
            this.btnKillerAddOns.Text = "Add Add-On";
            this.btnKillerAddOns.UseVisualStyleBackColor = true;
            this.btnKillerAddOns.Click += new System.EventHandler(this.btnKillerAddOns_Click);
            // 
            // listKillerAddOns
            // 
            this.listKillerAddOns.ContextMenuStrip = this.contextMenuStrip1;
            this.listKillerAddOns.FormattingEnabled = true;
            this.listKillerAddOns.Location = new System.Drawing.Point(89, 91);
            this.listKillerAddOns.Name = "listKillerAddOns";
            this.listKillerAddOns.Size = new System.Drawing.Size(105, 30);
            this.listKillerAddOns.TabIndex = 30;
            this.listKillerAddOns.SelectedIndexChanged += new System.EventHandler(this.listKillerAddOns_SelectedIndexChanged);
            // 
            // txtKillerPerks
            // 
            this.txtKillerPerks.Location = new System.Drawing.Point(6, 41);
            this.txtKillerPerks.Name = "txtKillerPerks";
            this.txtKillerPerks.Size = new System.Drawing.Size(62, 20);
            this.txtKillerPerks.TabIndex = 34;
            // 
            // txtKillerAddOns
            // 
            this.txtKillerAddOns.Location = new System.Drawing.Point(6, 101);
            this.txtKillerAddOns.Name = "txtKillerAddOns";
            this.txtKillerAddOns.Size = new System.Drawing.Size(62, 20);
            this.txtKillerAddOns.TabIndex = 38;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 304);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkMore);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFinishClose);
            this.Controls.Add(this.richtxtReport);
            this.Name = "frmReport";
            this.Text = "Match Summary";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinishClose;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.RichTextBox richtxtReport;
        private System.Windows.Forms.CheckBox chkMore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.ListBox listSurv1Perks;
        private System.Windows.Forms.ListBox listSurv1AddOns;
        private System.Windows.Forms.TextBox txtSurv1Perks;
        private System.Windows.Forms.TextBox txtSurv1AddOns;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSurv1Perks;
        private System.Windows.Forms.Button btnSurv1AddOns;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSurv2Perks;
        private System.Windows.Forms.ListBox listSurv2Perks;
        private System.Windows.Forms.Button btnSurv2AddOns;
        private System.Windows.Forms.ListBox listSurv2AddOns;
        private System.Windows.Forms.TextBox txtSurv2Perks;
        private System.Windows.Forms.TextBox txtSurv2AddOns;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSurv3Perks;
        private System.Windows.Forms.ListBox listSurv3Perks;
        private System.Windows.Forms.Button btnSurv3AddOns;
        private System.Windows.Forms.ListBox listSurv3AddOns;
        private System.Windows.Forms.TextBox txtSurv3Perks;
        private System.Windows.Forms.TextBox txtSurv3AddOns;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSurv4Perks;
        private System.Windows.Forms.ListBox listSurv4Perks;
        private System.Windows.Forms.Button btnSurv4AddOns;
        private System.Windows.Forms.ListBox listSurv4AddOns;
        private System.Windows.Forms.TextBox txtSurv4Perks;
        private System.Windows.Forms.TextBox txtSurv4AddOns;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnKillerPerks;
        private System.Windows.Forms.ListBox listKillerPerks;
        private System.Windows.Forms.Button btnKillerAddOns;
        private System.Windows.Forms.ListBox listKillerAddOns;
        private System.Windows.Forms.TextBox txtKillerPerks;
        private System.Windows.Forms.TextBox txtKillerAddOns;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}