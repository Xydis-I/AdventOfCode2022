namespace AdventOfCode_Day07;

internal class Directory
{
    public Directory(string name)
    {
        Name = name;
        Size = 0;
        FileSize = 0;
        Directories = new List<Directory>();
    }

    private string Name { get; }
    public int Size { get; private set; }
    private int FileSize { get; set; }

    public List<Directory> Directories { get; set; }

    public string GetName() => Name;

    public void UpdateSize()
    {
        if (this.Directories.Count != 0)
            Size = FileSize + Directories.Sum(x => x.Size);

        else
            Size = FileSize;
    }

    public void UpdateSize(int size) => FileSize += size;

    public void AddDirectory(Directory directory) => Directories.Add(directory);
}