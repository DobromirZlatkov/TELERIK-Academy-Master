using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AllFilesAndFoldersFromTheHardDrive
{
    class AllFilesAndFoldersFromTheHardDrive
    {
        static void Main(string[] args)
        {
            const string DirectoryRoot = "C:\\windows";
            const string FilePattern = "*.*";
            Folder root = new Folder(DirectoryRoot);

            CreateFolders(root, FilePattern);

            Console.WriteLine("Folder: " + root.Name);
            Console.WriteLine("Size in bytes: " + root.GetFileSize());
            Console.WriteLine("-----------------------");
            //prints all Folders and files in the tree but its too big for console ;D
           // BFS(root);

        }

        public static void BFS(Folder root)
        {
            Queue<Folder> folders = new Queue<Folder>();
            folders.Enqueue(root);
            while (folders.Count > 0)
            {
                var currentFolder = folders.Dequeue();
                Console.WriteLine("Folder name: {0}", currentFolder.Name);
                Console.Write("Folder files: ");
                foreach (var file in currentFolder.Files)
                {
                    Console.Write(file.Name + ", ");
                }
                foreach (var childFolder in currentFolder.ChildFolders)
                {
                    folders.Enqueue(childFolder);
                }
            }
        }

       
        private static void CreateFolders(Folder root, string FilePattern)
        {
            try
            {
                string[] files = Directory.GetFiles(root.Name, FilePattern);
                string[] folders = Directory.GetDirectories(root.Name);
                if (files.Length == 0 && folders.Length == 0)
                {
                    return;
                }
                else
                {
                    FileInfo fileInfo;
                    long size;
                    foreach (var file in files)
                    {
                        fileInfo = new FileInfo(file);
                        size = fileInfo.Length;
                        root.AddFile(file, size);
                    }

                    foreach (var folder in folders)
                    {
                        root.AddFolder(folder);
                        CreateFolders(root.ChildFolders[root.ChildFolders.Count - 1], FilePattern);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
