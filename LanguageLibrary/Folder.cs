using System;
using System.IO;

namespace LanguageLibrary
{
    public static class Folder
    {
        private static string PathFolder => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public static string SpecificFolder => Path.Combine(PathFolder, "Language Folder");

        public static void CreateFolder()
        {
            Directory.CreateDirectory(SpecificFolder);
        }

        public static string GetFilePath(string name)
        {
            return $"{SpecificFolder}\\{name}.dat";
        }
    }
}