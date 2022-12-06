namespace AdventOfCode_Day03
{
    internal static class Part2
    {
        public static void Solution()
        {
            const string fileLocation = @"C:\Users\ccb99\source\repos\AdventOfCode2022\Day03_Input.txt";

            try
            {
                using var input = new StreamReader(fileLocation);
                var rucksacks = input.ReadToEnd().Split("\r\n");
                var items = new List<char>();
                var total = 0;

                for (var i = 0; i < rucksacks.Length; i += 3)
                    items.Add(rucksacks[i].Intersect(rucksacks[i + 1]).Intersect(rucksacks[i + 2]).ToList()[0]);

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