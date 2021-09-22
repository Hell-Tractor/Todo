using System.Collections.Generic;
using System.IO;

namespace Todo
{
    class SettingsManager : Singleton<SettingsManager>
    {
        private Dictionary<string, string> settings = new Dictionary<string, string>();
        private const string SETTINGS_FILE_NAME = "./config.cfg";

        public SettingsManager()
        {
            Load();
        }

        ~SettingsManager()
        {
            Save();
        }

        public string Get(string key)
        {
            return settings[key];
        }
        public SettingsManager Set(string key, string value)
        {
            settings[key] = value;
            return this;
        }
        public SettingsManager Load()
        {
            using (StreamReader file = new StreamReader(SETTINGS_FILE_NAME))
            {
                string line = "";
                while ((line = file.ReadLine()) != null)
                {
                    string[] res = line.Split('=');
                    settings.Add(res[0], res[1]);
                }
            }
            return this;
        }

        public SettingsManager Save()
        {
            using (StreamWriter file = new StreamWriter(SETTINGS_FILE_NAME))
            {
                foreach (var i in settings)
                {
                    file.WriteLine("{0}={1}", i.Key, i.Value);
                }
            }
            return this;
        }
    }
}
