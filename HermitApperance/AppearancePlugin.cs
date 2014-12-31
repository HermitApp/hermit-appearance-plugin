using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hermit.Plugin;
using System.Reflection;

namespace HermitAppearance
{
    public class AppearancePlugin : IPlugin
    {
        AppearanceSettingsViewModel _Settings;
        public string Author
        {
            get { return "Lucas Brendel"; }
        }

        public string Description
        {
            get { return "Adjust the visual appearance of Hermit"; }
        }

        public string Name
        {
            get { return "Appearance"; }
        }

        public void SaveSettings()
        {
            throw new NotImplementedException();
        }

        public ISettingsItem Settings
        {
            get { return _Settings; }
        }

        public string Version
        {
            get { return Assembly.GetEntryAssembly().GetName().Version.ToString(); }
        }

        public AppearancePlugin()
        {
            _Settings = new AppearanceSettingsViewModel();
        }
    }
}
