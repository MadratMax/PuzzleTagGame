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

        public static string ButtonSound = SettingsManager.GetSettingsValue("settings", "sounds", "button-sound");

        public static string SettingsSound = SettingsManager.GetSettingsValue("settings", "sounds", "settings-sound");

        public static string WinSound = SettingsManager.GetSettingsValue("settings", "sounds", "win-game-sound");

        public static string SelectSound = SettingsManager.GetSettingsValue("settings", "sounds", "select-item-sound");

        public static string StartGameSound = SettingsManager.GetSettingsValue("settings", "sounds", "start-game-sound");

        public static string CloseCardSound = SettingsManager.GetSettingsValue("settings", "sounds", "close-card-sound");

        public static string CannotOpenCardSound = SettingsManager.GetSettingsValue("settings", "sounds", "cannot-open-card-sound");

        public static string ScoreSound = SettingsManager.GetSettingsValue("settings", "sounds", "score-sound");

        public static string ShuffleSound = SettingsManager.GetSettingsValue("settings", "sounds", "shuffle-sound");

        public static string OpenCloseCardsSound = SettingsManager.GetSettingsValue("settings", "sounds", "open-close-sound");

        public static string RemovePlayerSound = SettingsManager.GetSettingsValue("settings", "sounds", "remove-player-sound");

        public static string Player1Name = SettingsManager.GetSettingsValue("settings", "player1", "name");

        public static string Player1AvaImage = SettingsManager.GetSettingsValue("settings", "player1", "ava");

        public static string Player2Name = SettingsManager.GetSettingsValue("settings", "player2", "name");

        public static string Player2AvaImage = SettingsManager.GetSettingsValue("settings", "player2", "ava");

        public static string Player3Name = SettingsManager.GetSettingsValue("settings", "player3", "name");

        public static string Player3AvaImage = SettingsManager.GetSettingsValue("settings", "player3", "ava");
    }
}
