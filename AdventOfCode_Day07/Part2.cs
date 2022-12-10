namespace AdventOfCode_Day07
{
    internal static class Part2
    {
        public static void Solution()
        {
            const string fileLocation = @"C:\Users\ccb99\source\repos\AdventOfCode2022\Day07_Input.txt";

            try
            {
                using var input = new StreamReader(fileLocation);
                var lines = input.ReadToEnd().Split("\r\n");
                var directories = new List<Directory>();
                var directoryHistory = new Stack<Directory>();

                foreach (var line in lines)
                {
                    if (line[..4] == "$ cd")
                    {
                        if (line.Split()[^1] == "..")
                        {
                            directoryHistory.Pop();
                            continue;
                        }

                        if (directories.Count == 0)
                        {
                            var newDirectory = new Directory(line.Split()[^1]);
                            directories.Add(newDirectory);
                            directoryHistory.Push(newDirectory);
                        }

                        else if (directoryHistory.Peek().Directories.Find(x => x.GetName() == line.Split()[^1]) != null)
                            directoryHistory.Push(directoryHistory.Peek().Directories.Find(x => x.GetName() == line.Split()[^1])!);
                    }

                    if (line.Split(" ")[0] == "dir")
                    {
                        if (directoryHistory.Peek().Directories.Find(x => x.GetName() == line.Split()[^1]) == null)
                        {
                            var newDirectory = new Directory(line.Split()[^1]);
                            directoryHistory.Peek().AddDirectory(newDirectory);
                            directories.Add(newDirectory);
                        }
                    }

                    if (int.TryParse(line.Split(" ")[0], out int result))
                        directoryHistory.Peek().UpdateSize(result);
                }

                for (var i = directories.Count - 1; i > -1; i--)
                    directories[i].UpdateSize();

                Console.WriteLine(directories.Last(x => x.Size >= 30000000 - (70000000 - directories[0].Size)).Size);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
