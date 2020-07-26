using System;
using System.Collections.Generic;
namespace PuzzleTag.Configuration
{
    class Settings
    {
        public static string LibraryPath = SettingsManager.GetSettingsValue("settings", "images");

        public static string WinnerImagePath = SettingsManager.GetSettingsValue("settings", "winner-image");

        public static string ClosedCardImagePath = SettingsManager.GetSettingsValue("settings", "closed-card-image");
    }
}
