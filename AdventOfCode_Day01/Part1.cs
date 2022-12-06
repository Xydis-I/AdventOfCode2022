namespace AdventOfCode_Day01
{
    internal static class Part1
    {
        public static void Solution()
        {
            const string fileLocation = @"C:\Users\ccb99\source\repos\AdventOfCode2022\Day01_Input.txt";

            try
            {
                using var input = new StreamReader(fileLocation);
                var lines = input.ReadToEnd().Split("\r\n");
                var elves = new List<List<string>>();

                var elfNum = 0;

                elves.Add(new List<string>());
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                        elves[elfNum].Add(line);
                    else
                    {
                        elfNum++;
                        elves.Add(new List<string>());
                    }
                }

                var calories = elves.Select(elf => elf.Sum(int.Parse)).ToList();

                calories.Sort();
                Console.WriteLine(calories[^1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
