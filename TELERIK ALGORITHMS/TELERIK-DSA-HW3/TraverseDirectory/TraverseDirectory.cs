namespace TraverseDirectory
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class TraverseDirectory
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> dirWithFIles = DirSearch("C:\\WINDOWS");
            foreach (var dir in dirWithFIles)
            {
                Console.WriteLine("Directory: {0}", dir.Key);
                Console.WriteLine("Files: {0}", string.Join(", ", dir.Value));
            }
        }

        public static Dictionary<string, string[]> DirSearch(string sDir)
        {
            Dictionary<string, string[]> directoryWithFiles = new Dictionary<string, string[]>();
            try
            {
                foreach (var dir in Directory.GetDirectories(sDir))
                {
                    directoryWithFiles.Add(dir, Directory.GetFiles(dir, "*.exe"));                   
                    DirSearch(dir);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return directoryWithFiles;
        }
    }
}
