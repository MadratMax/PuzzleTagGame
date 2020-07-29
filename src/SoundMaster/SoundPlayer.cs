namespace PuzzleTag.SoundMaster
{
    class SoundPlayer
    {
        private static System.Media.SoundPlayer player;
        public static string ButtonSound;
        public static string SettingsSound;
        public static string SelectSound;
        public static string WinSound;
        public static string StartGameSound;
        public static string CloseCardSound;
        public static string ScoreSound;
        public static string ShuffleSound;
        public static string OpenCloseCardsSound;
        public static string RemovePlayerSound;
        public static string CannotOpenCardSound;

        public static void PlaySound(string soundFile)
        {
            player = new System.Media.SoundPlayer(soundFile);
            player?.Play();
        }

        public static void PlayButtonSound()
        {
            player = new System.Media.SoundPlayer(ButtonSound);
            player?.Play();
        }

        public static void PlayCloseCardSound()
        {
            player = new System.Media.SoundPlayer(CloseCardSound);
            player?.Play();
        }

        public static void PlayOpenCloseCardsSound()
        {
            player = new System.Media.SoundPlayer(OpenCloseCardsSound);
            player?.Play();
        }

        public static void PlayCannotOpenCardSound()
        {
            player = new System.Media.SoundPlayer(CannotOpenCardSound);
            player?.Play();
        }

        public static void PlayShuffleSound()
        {
            player = new System.Media.SoundPlayer(ShuffleSound);
            player?.Play();
        }

        public static void PlayRemovePlayerSound()
        {
            player = new System.Media.SoundPlayer(RemovePlayerSound);
            player?.Play();
        }

        public static void PlayScoreSound()
        {
            player = new System.Media.SoundPlayer(ScoreSound);
            player?.Play();
        }

        public static void PlaySettingsSound()
        {
            player = new System.Media.SoundPlayer(SettingsSound);
            player?.Play();
        }

        public static void PlaySelectItemSound()
        {
            player = new System.Media.SoundPlayer(SelectSound);
            player?.Play();
        }

        public static void PlayStartGameSound()
        {
            player = new System.Media.SoundPlayer(StartGameSound);
            player?.Play();
        }

        public static void PlayWinSound()
        {
            player = new System.Media.SoundPlayer(WinSound);
            player?.Play();
        }
    }
}
