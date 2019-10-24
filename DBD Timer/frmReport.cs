using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DBD_Timer
{
    public partial class frmReport : Form
    {
        private readonly int collaspedWidth;
        private readonly int collaspedHeight;

        public frmReport()
        {
            InitializeComponent();
            collaspedWidth = Width;
            collaspedHeight = Height; //size: (276, 343) initially
        }

        private void btnFinishClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }       

        public void CopyDataToRichTextBox(string summary, List<string> list)
        {
            richtxtReport.AppendText(summary + Environment.NewLine); //must go before the copying list method
            string[] lines = list.ToArray();
            for (int i = 0; i < lines.Length; i++)
                richtxtReport.AppendText(lines[i] + Environment.NewLine);
            richtxtReport.AppendText(Environment.NewLine);
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            DisableControls();
            
        }

        private void ModifyListBox(ListBox listBox, TextBox textBox, int size)
        {
            if (listBox.Items.Count < size)
            {
                listBox.Items.Add(textBox.Text);
                textBox.Text = "";
            }                
        }

        //to help modify values using one button
        private bool IsIndexSelected(ListBox listbox) 
            => listbox.SelectedIndex != -1 ? true : false;

        private void chkMore_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMore.Checked == true)            
                EnableControls();           
            else            
                DisableControls();
                
            Width = chkMore.Checked ? collaspedWidth + 620 : collaspedWidth;
            Height = chkMore.Checked ? collaspedHeight : collaspedHeight; //to keep the form height to be the same
        }

        private void EnableControls()
        {
            btnAppend.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
        }

        private void DisableControls()
        {
            btnAppend.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
        }

        private const byte LargeListSize = 4;
        private const byte SmallListSize = 2;
        
        //groupbox 1
        private void btnSurv1Perks_Click(object sender, EventArgs e)
        {
            if (!IsIndexSelected(listSurv1Perks))
                ModifyListBox(listSurv1Perks, txtSurv1Perks, LargeListSize);
            else
                FormatListBox.ChangeValue(listSurv1Perks, txtSurv1Perks);            
        }

        private void btnSurv1AddOns_Click(object sender, EventArgs e)
        {
            if (!IsIndexSelected(listSurv1AddOns))
                ModifyListBox(listSurv1AddOns, txtSurv1AddOns, SmallListSize);
            else
                FormatListBox.ChangeValue(listSurv1AddOns, txtSurv1AddOns);
        }

        private void listSurv1Perks_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatListBox.TextBoxtoListIndex(listSurv1Perks, txtSurv1Perks);
        }

        private void listSurv1AddOns_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatListBox.TextBoxtoListIndex(listSurv1AddOns, txtSurv1AddOns);
        }

        //groupbox 2
        private void btnSurv2Perks_Click(object sender, EventArgs e)
        {
            if(!IsIndexSelected(listSurv2Perks))
                ModifyListBox(listSurv2Perks, txtSurv2Perks, LargeListSize);
            else
                FormatListBox.ChangeValue(listSurv2Perks, txtSurv2Perks);
        }

        private void btnSurv2AddOns_Click(object sender, EventArgs e)
        {
            if (!IsIndexSelected(listSurv2AddOns))
                ModifyListBox(listSurv2AddOns, txtSurv2AddOns, SmallListSize);
            else
                FormatListBox.ChangeValue(listSurv2AddOns, txtSurv2AddOns);
        }

        private void listSurv2Perks_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatListBox.TextBoxtoListIndex(listSurv2AddOns, txtSurv2AddOns);
        }

        private void listSurv2AddOns_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatListBox.TextBoxtoListIndex(listSurv2AddOns, txtSurv2AddOns);
        }

        //groupbox 3
        private void btnSurv3Perks_Click(object sender, EventArgs e)
        {
            if (!IsIndexSelected(listSurv3Perks))
                ModifyListBox(listSurv3Perks, txtSurv3Perks, LargeListSize);
            else
                FormatListBox.ChangeValue(listSurv3Perks, txtSurv3Perks);
        }

        private void btnSurv3AddOns_Click(object sender, EventArgs e)
        {
            if (!IsIndexSelected(listSurv3AddOns))
                ModifyListBox(listSurv3AddOns, txtSurv3AddOns, SmallListSize);
            else
                FormatListBox.ChangeValue(listSurv3AddOns, txtSurv3AddOns);
        }

        private void listSurv3Perks_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatListBox.TextBoxtoListIndex(listSurv3Perks, txtSurv3Perks);
        }

        private void listSurv3AddOns_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatListBox.TextBoxtoListIndex(listSurv3AddOns, txtSurv3AddOns);
        }

        //groupbox 4
        private void btnSurv4Perks_Click(object sender, EventArgs e)
        {
            if (!IsIndexSelected(listSurv4Perks))
                ModifyListBox(listSurv4Perks, txtSurv4Perks, LargeListSize);
            else
                FormatListBox.ChangeValue(listSurv4Perks, txtSurv4Perks);
        }

        private void btnSurv4AddOns_Click(object sender, EventArgs e)
        {
            if (!IsIndexSelected(listSurv4AddOns))
                ModifyListBox(listSurv4AddOns, txtSurv4AddOns, SmallListSize);
            else
                FormatListBox.ChangeValue(listSurv4AddOns, txtSurv4AddOns);
        }

        private void listSurv4Perks_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatListBox.TextBoxtoListIndex(listSurv4Perks, txtSurv4Perks);
        }

        private void listSurv4AddOns_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatListBox.TextBoxtoListIndex(listSurv4AddOns, txtSurv4AddOns);
        }

        //groupbox 5
        private void btnKillerPerks_Click(object sender, EventArgs e)
        {
            if (!IsIndexSelected(listKillerPerks))
                ModifyListBox(listKillerPerks, txtKillerPerks, LargeListSize);
            else
                FormatListBox.ChangeValue(listKillerPerks, txtKillerPerks);
        }

        private void btnKillerAddOns_Click(object sender, EventArgs e)
        {
            if (!IsIndexSelected(listKillerAddOns))
                ModifyListBox(listKillerAddOns, txtKillerAddOns, SmallListSize);
            else
                FormatListBox.ChangeValue(listKillerAddOns, txtKillerAddOns);
        }

        private void listKillerPerks_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatListBox.TextBoxtoListIndex(listKillerPerks, txtKillerPerks);
        }

        private void listKillerAddOns_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatListBox.TextBoxtoListIndex(listKillerAddOns, txtKillerAddOns);
        }

        //Appending
        private string[] ListBoxItemsToArray(ListBox listbox, ListBox listbox2)
        {
            if(listbox.Items.Count > 0 && listbox2.Items.Count > 0)
            { 
                string[] x = new string[listbox.Items.Count];               
                string[] y = new string[listbox2.Items.Count];

                for (int i = 0; i < x.Length; i++)
                    x[i] = listbox.Items[i].ToString() + Environment.NewLine;

                for(int j = 0; j < y.Length; j++)
                    y[j] = listbox2.Items[j].ToString() + Environment.NewLine;
                
                string[] arr = new string[x.Length + y.Length];
                x.CopyTo(arr, 0);
                y.CopyTo(arr, x.Length);

                return arr;
            } 
            else if(listbox.Items.Count > 0 && listbox2.Items.Count == 0)
            {
                string[] x = new string[listbox.Items.Count];

                for (int i = 0; i < x.Length; i++)
                    x[i] = listbox.Items[i].ToString() + Environment.NewLine;

                return x;
            }
            else if(listbox.Items.Count == 0 && listbox2.Items.Count > 0)
            {
                string[] y = new string[listbox2.Items.Count];

                for (int j = 0; j < y.Length; j++)
                    y[j] = listbox2.Items[j].ToString() + Environment.NewLine;

                return y;
            }
            else
            {
                string[] empty = { "Empty", Environment.NewLine };
                return empty;
            }
            
        }

        private void PrintToRichbox(ListBox listbox1, ListBox listbox2, string title)
        {
            int size = listbox1.Items.Count + listbox2.Items.Count;
            richtxtReport.AppendText(title + Environment.NewLine);
            string[] arr = ListBoxItemsToArray(listbox1, listbox2);           

            for (int i = 0; i < size; i++)
                richtxtReport.AppendText(arr[i]);
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            richtxtReport.AppendText("Perk and Add-On Information" + Environment.NewLine);
            
            PrintToRichbox(listSurv1Perks, listSurv1AddOns, groupBox1.Text);
            richtxtReport.AppendText(Environment.NewLine);
            PrintToRichbox(listSurv2Perks, listSurv2AddOns, groupBox2.Text);
            richtxtReport.AppendText(Environment.NewLine);
            PrintToRichbox(listSurv3Perks, listSurv3AddOns, groupBox3.Text);
            richtxtReport.AppendText(Environment.NewLine);
            PrintToRichbox(listSurv4Perks, listSurv4AddOns, groupBox4.Text);
            richtxtReport.AppendText(Environment.NewLine);
            PrintToRichbox(listKillerPerks, listKillerAddOns, groupBox5.Text);

            btnAppend.Enabled = false;
            chkMore.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files (*.txt)|*.txt";
            save.Title = "Save to Text File";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (FileStream S = File.Open(save.FileName, FileMode.Create))
                {
                    using (StreamWriter st = new StreamWriter(S))
                    {
                        foreach (var aa in richtxtReport.Lines)
                            st.WriteLine(aa.ToString());
                        st.Close();
                    }
                    S.Close();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatListBox.DeleteIndex(listSurv1Perks, txtSurv1Perks);
            FormatListBox.DeleteIndex(listSurv2Perks, txtSurv2Perks);
            FormatListBox.DeleteIndex(listSurv3Perks, txtSurv3Perks);
            FormatListBox.DeleteIndex(listSurv4Perks, txtSurv4Perks);

            FormatListBox.DeleteIndex(listSurv1AddOns, txtSurv1AddOns);
            FormatListBox.DeleteIndex(listSurv2AddOns, txtSurv2AddOns);
            FormatListBox.DeleteIndex(listSurv3AddOns, txtSurv3AddOns);
            FormatListBox.DeleteIndex(listSurv4AddOns, txtSurv4AddOns);

            FormatListBox.DeleteIndex(listKillerPerks, txtKillerPerks);
            FormatListBox.DeleteIndex(listKillerAddOns, txtKillerAddOns);
        }
    }
}
 