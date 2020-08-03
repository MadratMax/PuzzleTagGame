using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using PuzzleTag.FileManager.Library;
using PuzzleTag.Notification;
using PuzzleTag.SoundMaster;

namespace PuzzleTag.FileManager
{
    class FileManager
    {
        public FileManager()
        {
            
        }

        public bool IsDirectoryExist(string dir)
        {
            return Directory.Exists(dir);
        }

        public bool IsDirectoryNotEmpty(string dir)
        {
            var files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
            return Directory.Exists(dir) && files.Length > 0;
        }

        public List<string> GetSubDirectories(string dir)
        {
            List<string> subDirectories;

            try
            {
                subDirectories = Directory.GetDirectories(dir, "*.*", SearchOption.TopDirectoryOnly).ToList();
            }
            catch (DirectoryNotFoundException e)
            {
                var popUp = new TimedPopUp();
                popUp.Set("Images directory not found. Creating a new one...");
                popUp.Show();
                Directory.CreateDirectory(dir);
                subDirectories = Directory.GetDirectories(dir, "*.*", SearchOption.TopDirectoryOnly).ToList();
            }
            
            
            return subDirectories;
        }

        public List<string> GetSubDirNames(string dir)
        {
            var subFoldersList = new List<string>();
            var directories = Directory.GetDirectories(dir, "*.*", SearchOption.TopDirectoryOnly);

            foreach (var folder in directories)
            {
                var lastFolderName = Path.GetFileName(Path.GetDirectoryName(folder));
                subFoldersList.Add(lastFolderName);
            }

            return subFoldersList;
        }

        public string GetDirName(string dir)
        {
            return Path.GetFileName(Path.GetDirectoryName(dir));
        }

        public List<string> GetFiles(string dir)
        {
            List<string> files = null;

            try
            {
                files = Directory.GetFiles(dir).ToList();
            }
            catch (DirectoryNotFoundException e)
            {
                var popUp = new TimedPopUp();
                popUp.ShowCriticalError($"Cannot find directory: " +
                                        $"\n{dir}" +
                                        $"\nCreate the directory and restart app");
            }
            
            return files;
        }

        public string GetFileName(string file)
        {
            var name = new FileInfo(file).Name;

            return name;
        }

        public void SaveNewCollection(List<CustomImage> imageCollection, string collectionName, string libPath)
        {
            var collectionPath = Path.Combine(libPath, collectionName);

            if (!IsDirectoryExist(collectionPath)) {
                
                SaveImageCollection(libPath, collectionName, imageCollection);

                var popUp = new TimedPopUp();
                popUp.Set("СОХРАНЕНО");
                SoundPlayer.PlaySaveSound();
                popUp.Show();
            }
        }

        public void DeleteCollection(string collectionName, string libPath)
        {
            var collectionPath = Path.Combine(libPath, collectionName);

            if (IsDirectoryExist(collectionPath))
            {
                try
                {
                    Directory.Delete(collectionPath, true);
                    var popUp = new TimedPopUp();
                    popUp.Set($"Удалено");
                    popUp.Show();
                }
                catch (Exception e)
                {
                    var popUp = new TimedPopUp();
                    popUp.Set($"Failed to delete file. {e.Message}");
                    popUp.ShowError();
                }
            }
        }

        private void SaveImageCollection(string libraryPath, string category, List<CustomImage> imageCollection)
        {
            var newCollectionPath = Path.Combine(libraryPath, category);
            var idList = new List<int>();
            Directory.CreateDirectory(newCollectionPath);

            foreach (var customImage in imageCollection)
            {
                if (!idList.Contains(customImage.Id))
                {
                    idList.Add(customImage.Id);

                    var imageFile = Path.Combine(newCollectionPath, customImage.Name);

                    customImage.Image.Save(imageFile, ImageFormat.Jpeg);
                    customImage.AllowUpdate = false;
                }
            }
        }
    }
}
