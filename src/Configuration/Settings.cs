using System;
using System.Collections.Generic;
namespace PuzzleTag.Configuration
{
    class Settings
    {
        public static string LibraryPath = SettingsManager.GetSettingsValue("settings", "images");

        public static string WinnerImagePath = SettingsManager.GetSettingsValue("settings", "winner-image");

        public static string MainImagePath = SettingsManager.GetSettingsValue("settings", "main-form-image");

        public static string ClosedCardImagePath = SettingsManager.GetSettingsValue("settings", "closed-card-image");

        public static string Delay = SettingsManager.GetSettingsValue("settings", "open-card-delay");

        public static string Player1Name = SettingsManager.GetSettingsValue("settings", "player1", "name");

        public static string Player1AvaImage = SettingsManager.GetSettingsValue("settings", "player1", "ava");

        public static string Player2Name = SettingsManager.GetSettingsValue("settings", "player2", "name");

        public static string Player2AvaImage = SettingsManager.GetSettingsValue("settings", "player2", "ava");

        public static string Player3Name = SettingsManager.GetSettingsValue("settings", "player3", "name");

        public static string Player3AvaImage = SettingsManager.GetSettingsValue("settings", "player3", "ava");
    }
}
