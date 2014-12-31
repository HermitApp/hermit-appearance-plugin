using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Hermit.Plugin;
using Caliburn.Micro;
using MahApps.Metro;
using System.Windows.Media;

namespace HermitAppearance
{
    /// <summary>
    /// 
    /// </summary>
    public class AppearanceSettingsViewModel : ISettingsItem
    {
        public AppearanceSettings Appearance { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AppearanceSettingsViewModel()
        {
            Appearance = new AppearanceSettings();

            this.Appearance.AccentColors = ThemeManager.Accents
                                            .Select(a => new AccentColorData() { Name = a.Name, ColorBrush = a.Resources["AccentColorBrush"] as Brush })
                                            .ToList();

            this.Appearance.ThemeColors = ThemeManager.AppThemes
                                           .Select(a => new ThemeColorData() { Name = a.Name, BorderColorBrush = a.Resources["BlackColorBrush"] as Brush, ColorBrush = a.Resources["WhiteColorBrush"] as Brush })
                                           .ToList();
        }

        public string Name
        {
            get { return "Appearance"; }
        }
    }
}
