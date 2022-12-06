namespace AdventOfCode_Day03
{
    internal static class Part1
    {
        public static void Solution()
        {
            const string fileLocation = @"C:\Users\ccb99\source\repos\AdventOfCode2022\Day03_Input.txt";

            try
            {
                using var input = new StreamReader(fileLocation);
                var lines = input.ReadToEnd().Split("\r\n");
                var total = 0;

                var rucksacks = lines.Select(line => new List<string> { line.Substring(0, line.Length / 2), line.Substring(line.Length / 2) }).ToList();

                var items = rucksacks.Select(rucksack => rucksack[0].Intersect(rucksack[1]).ToList()[0]).ToList();

                foreach (var item in items)
                {
                    if (char.IsUpper(item))
                        total += item - 38;

                    else
                        total += item - 96;
                }
                Console.WriteLine(total);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}