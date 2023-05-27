using System.Collections.Specialized;
using System;
using System.Configuration;
using System.Windows.Forms;
using KomiteKu.Class;

namespace KomiteKu
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            ReadConfig();
        }

        // Config Handler Start
        public void ReadConfig()
        {
            TextBox[] input = { txt_semester0, txt_semester1, txt_semester2, txt_semester3, txt_semester4, txt_semester5 };
            try
            {
                // Get the AppSettings section.
                NameValueCollection appSettings = ConfigurationManager.AppSettings;

                // Display The Setting To The Textbox
                for (int i = 0; i < input.Length; i++)
                {
                    input[i].Text = appSettings[i];
                }
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[ReadAppSettings: {0}]", e.ToString());
            }
        }
        public void UpdateConfig(object sender, EventArgs e)
        {
            // Check If The Input Was Valid
            string[] input = { txt_semester0.Text, txt_semester1.Text, txt_semester2.Text, txt_semester3.Text, txt_semester4.Text, txt_semester5.Text };

            if (Check.Errors(input, Check.number))
            {
                // Get the application configuration file.
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                for (int i = 0; i < input.Length; i++)
                {
                    config.AppSettings.Settings.Remove("semester" + i);
                    config.AppSettings.Settings.Add("semester" + i, input[i]);
                }
                SaveConfigFile(config);
            }    
        }
        private static void SaveConfigFile(System.Configuration.Configuration config)
        {
            string sectionName = "appSettings";

            // Save the configuration file.
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of the changed section. This  
            // makes the new values available for reading.
            ConfigurationManager.RefreshSection(sectionName);

            // Get the AppSettings section.
            AppSettingsSection appSettingSection =
              (AppSettingsSection)config.GetSection(sectionName);

            MessageBox.Show("Setting berhasil diperbarui");
        }
    }
}
