namespace AllFilesAndFoldersFromTheHardDrive
{
    using System.Collections.Generic;

    class Folder
    {
        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> ChildFolders { get; set; }

        public long GetFileSize()
        {
            long size = 0;

            foreach (var file in Files)
            {
                size += file.Size;
            }

            foreach (var childFolder in ChildFolders)
            {
                size += childFolder.GetFileSize();
            }

            return size;
        }

        public void AddFile(string name, long size)
        {
            File file = new File(name, size);
            Files.Add(file);
        }

        public void AddFolder(string name)
        {
            Folder folder = new Folder(name);
            ChildFolders.Add(folder);
        }
    }
}
