namespace AdventOfCode_Day01
{
    class Part2
    {
        public static void Solution()
        {
            var fileLocation = @"C:\Users\ccb99\source\repos\AdventOfCode2022\Day01_Input.txt";

            try
            {
                using (var input = new StreamReader(fileLocation))
                {
                    var lines = input.ReadToEnd().Split("\r\n");
                    var elves = new List<List<string>>();
                    var calories = new List<int>();

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

                    foreach (var elf in elves)
                    {
                        var total = 0;
                        foreach (var item in elf)
                            total += int.Parse(item);
                        calories.Add(total);
                    }

                    calories.Sort();

                    for (int i = 1; i < 4; i++)
                        totalCal += calories[calories.Count - i];

                    Console.WriteLine(totalCal);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

    }
}
