using System.Collections.Specialized;
using System;
using System.Configuration;
using System.Windows.Forms;

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
            try
            {
                // Get the AppSettings section.
                NameValueCollection appSettings = ConfigurationManager.AppSettings;

                // Display The Setting To The Textbox
                txt_semester1.Text = appSettings[0].ToString();
                txt_semester2.Text = appSettings[1].ToString();
                txt_semester3.Text = appSettings[2].ToString();
                txt_semester4.Text = appSettings[3].ToString();
                txt_semester5.Text = appSettings[4].ToString();
                txt_semester6.Text = appSettings[5].ToString();
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[ReadAppSettings: {0}]", e.ToString());
            }
        }
        public void UpdateConfig(object sender, EventArgs e)
        {
            // Get the application configuration file.
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings.Remove("semester1");
            config.AppSettings.Settings.Remove("semester2");
            config.AppSettings.Settings.Remove("semester3");
            config.AppSettings.Settings.Remove("semester4");
            config.AppSettings.Settings.Remove("semester5");
            config.AppSettings.Settings.Remove("semester6");

            config.AppSettings.Settings.Add("semester1", txt_semester1.Text);
            config.AppSettings.Settings.Add("semester2", txt_semester2.Text);
            config.AppSettings.Settings.Add("semester3", txt_semester3.Text);
            config.AppSettings.Settings.Add("semester4", txt_semester4.Text);
            config.AppSettings.Settings.Add("semester5", txt_semester5.Text);
            config.AppSettings.Settings.Add("semester6", txt_semester6.Text);

            SaveConfigFile(config);
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
