using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imsproject
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void passwordTxt_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (isCB.Checked)
            {
                if (srvrTxt.Text != "" && dbTxt.Text != "")
                {
                    s = "Data Source=" + srvrTxt.Text + ";Initial Catalog=" + dbTxt.Text + ";Integrated Security=true;";
                    File.WriteAllText(Path+ "\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully.....", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else 
                {
                    MessageBox.Show("Please give complete data to continue....");
                }
            }
            else
            {
                if (srvrTxt.Text != "" && dbTxt.Text != "" && userIDTxt.Text != "" && passTxt.Text != "")
                {
                    s = "Data Source=" + srvrTxt.Text + ";Initial Catalog=" + dbTxt.Text + ";User ID=" + userIDTxt.Text + ";Password=" + passTxt.Text + ";";
                    File.WriteAllText(Path+ "\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully.....", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to continue....");
                }
            }

        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userIDTxt.Enabled = false;
                passTxt.Enabled = false;
                userIDTxt.Text = "";
                passTxt.Text = "";
            }
            else
            {
                userIDTxt.Enabled = true;
                passTxt.Enabled = true;
            }
        }
    }
}
