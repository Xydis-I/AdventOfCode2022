namespace AdventOfCode_Day04
{
    internal static class Part1
    {
        public static void Solution()
        {
            const string fileLocation = @"C:\Users\ccb99\source\repos\AdventOfCode2022\Day04_Input.txt";

            try
            {
                using var input = new StreamReader(fileLocation);
                var lines = input.ReadToEnd().Split("\r\n");
                var elfPairs = lines.Select(line => line.Split(',')).ToList();
                var total = 0;

                foreach (var elfPair in elfPairs)
                {
                    if (int.Parse(elfPair[0].Split('-')[0]) <= int.Parse(elfPair[1].Split('-')[0]) && int.Parse(elfPair[0].Split('-')[1]) >= int.Parse(elfPair[1].Split('-')[1]))
                        total += 1;

                    else if (int.Parse(elfPair[1].Split('-')[0]) <= int.Parse(elfPair[0].Split('-')[0]) && int.Parse(elfPair[1].Split('-')[1]) >= int.Parse(elfPair[0].Split('-')[1]))
                        total += 1;
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
