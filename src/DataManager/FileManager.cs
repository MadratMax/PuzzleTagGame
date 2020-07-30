using System.Collections.Generic;
using System.IO;
using System.Linq;
using PuzzleTag.FileManager.Library;

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
            var subDirectories = Directory.GetDirectories(dir, "*.*", SearchOption.TopDirectoryOnly).ToList();
            
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
            var files = Directory.GetFiles(dir).ToList();
            
            return files;
        }

        public string GetFileName(string file)
        {
            var name = new FileInfo(file).Name;

            return name;
        }

        public void SaveImageCollection(string libraryPath, string category, List<CustomImage> imageCollection)
        {
            var newCollectionPath = Path.Combine(libraryPath, category);
            Directory.CreateDirectory(newCollectionPath);

            foreach (var customImage in imageCollection)
            {
                var imageFile = Path.Combine(newCollectionPath, customImage.Name);
                customImage.Image.Save(imageFile);
            }
        }
    }
}
