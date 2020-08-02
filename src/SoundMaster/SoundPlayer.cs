using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using PuzzleTag.FileManager.Library;

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
        public static string SaveSound;
        public static string NewImageSound;
        public static string FailedImageSound;

        public static void PlaySound(string soundFile)
        {
            Play(soundFile);
        }

        public static void PlayButtonSound()
        {
            Play(ButtonSound);
        }

        public static void PlayCloseCardSound()
        {
            Play(CloseCardSound);
        }

        public static void PlayFailedImageSound()
        {
            Play(FailedImageSound);
        }

        public static void PlayOpenCloseCardsSound()
        {
            Play(OpenCloseCardsSound);
        }

        public static void PlayCannotOpenCardSound()
        {
            Play(CannotOpenCardSound);
        }

        public static void PlayNewImageAddedSound()
        {
            Play(NewImageSound);
        }

        public static void PlaySaveSound()
        {
            Play(SaveSound);
        }

        public static void PlayShuffleSound()
        {
            Play(ShuffleSound);
        }

        public static void PlayRemovePlayerSound()
        {
            Play(RemovePlayerSound);
        }

        public static void PlayScoreSound()
        {
            Play(ScoreSound);
        }

        public static void PlaySettingsSound()
        {
            Play(SettingsSound);
        }

        public static void PlaySelectItemSound()
        {
            Play(SelectSound);
        }

        public static void PlayStartGameSound()
        {
            Play(StartGameSound);
        }

        public static void PlayWinSound()
        {
            Play(WinSound);
        }

        private static void Play(string sound)
        {
            new Thread(() =>
            {
                player = new System.Media.SoundPlayer(sound);
                player?.Play();

            }).Start();
        }
    }
}
