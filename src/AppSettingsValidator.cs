using System.IO;
using PuzzleTag.Notification;

namespace PuzzleTag
{
    class AppSettingsValidator
    {
        public static void CheckSettingsAndContinue()
        {
            if (!IsValid())
            {
                var popUp = new TimedPopUp();
                popUp.ShowCriticalError($"Cannot find appsettings.json" +
                                        $"\nApplication will be closed");
            }
        }

        private static bool IsValid()
        {
            return File.Exists("appSettings.json");
        }
    }
}
