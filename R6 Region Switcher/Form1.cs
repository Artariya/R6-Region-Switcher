using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace R6_Region_Switcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                string currentRegion = iniEditor.ReadData(GameSettingsPath(), "ONLINE", "DataCenterHint");
                textBoxCurrentRegion.Text = currentRegion;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        static private string GameSettingsPath()
        {
            string r6BaseFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Documents",
                "My Games",
                "Rainbow Six - Siege");

            foreach (string dir in Directory.GetDirectories(r6BaseFolder))
            {
                if (File.Exists(Path.Combine(dir, "GameSettings.ini")))
                {
                    return Path.Combine(dir, "GameSettings.ini");
                }
            }
            throw new Exception("R6 GameSettings.ini not founded.");
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (comboBoxRegions.SelectedIndex >= 0)
            {
                try
                {
                    iniEditor.WriteData(GameSettingsPath(), "ONLINE", "DataCenterHint", comboBoxRegions.SelectedItem.ToString());
                    if (iniEditor.ReadData(GameSettingsPath(), "ONLINE", "DataCenterHint") == comboBoxRegions.SelectedItem.ToString())
                    {
                        MessageBox.Show("Your region has been successfully changed.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unknown Error.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textBoxCurrentRegion.Text = iniEditor.ReadData(GameSettingsPath(), "ONLINE", "DataCenterHint");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Please select region", "select region", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
