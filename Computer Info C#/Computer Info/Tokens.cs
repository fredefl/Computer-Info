using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ini;
using System.IO;

namespace Computer_Info
{
    public partial class Tokens : Form
    {
        IniFile Settings = new IniFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Replace("file:///",""))+"/Settings.ini");
        public Tokens()
        {
            InitializeComponent();
        }

        public bool StringToBool(string Input)
        {
            if (Input == "1") return true; else return false;
        }

        public string BoolToString(bool Input)
        {
            if (Input) return "1"; else return "0";
        }

        private void Tokens_Shown(object sender, EventArgs e)
        {
            Token1Box.Text = Settings.IniReadValue("Settings", "Token1");
            Token2Box.Text = Settings.IniReadValue("Settings", "Token2");
            UseTokensCheck.Checked = StringToBool(Settings.IniReadValue("Settings", "UseTokens"));
            if(StringToBool(Settings.IniReadValue("Settings", "UseTokens")))
            {
                Token1Box.Enabled = true;
                Token2Box.Enabled = true;
            }
            else
            {
                Token1Box.Enabled = false;
                Token2Box.Enabled = false;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Settings.IniWriteValue("Settings", "Token1", Token1Box.Text);
            Settings.IniWriteValue("Settings", "Token2", Token2Box.Text);
            Settings.IniWriteValue("Settings", "UseTokens", BoolToString(UseTokensCheck.Checked));
            this.Hide();
        }

        private void Tokens_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void UseTokensCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UseTokensCheck.Checked)
            {
                Token1Box.Enabled = true;
                Token2Box.Enabled = true;
            }
            else
            {
                Token1Box.Enabled = false;
                Token2Box.Enabled = false;
            }
        }
    }
}
