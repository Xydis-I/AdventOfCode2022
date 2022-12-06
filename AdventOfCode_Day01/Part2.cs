namespace AdventOfCode_Day01
{
    internal static class Part2
    {
        public static void Solution()
        {
            const string fileLocation = @"C:\Users\ccb99\source\repos\AdventOfCode2022\Day01_Input.txt";

            try
            {
                using var input = new StreamReader(fileLocation);
                var lines = input.ReadToEnd().Split("\r\n");
                var elves = new List<List<string>>();

                var totalCal = 0;
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

                for (var i = 1; i < 4; i++)
                    totalCal += calories[^i];

                Console.WriteLine(totalCal);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
