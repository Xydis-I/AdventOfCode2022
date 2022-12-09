namespace AdventOfCode_Day06
{
    internal static class Part1
    {
        public static void Solution()
        {
            const string fileLocation = @"C:\Users\ccb99\source\repos\AdventOfCode2022\Day06_Input.txt";

            try
            {
                using var input = new StreamReader(fileLocation);
                var line = input.ReadToEnd();

                for (var i = 3; i < line.Length; i++)
                {
                    var hash = new HashSet<char>();
                    for (var j = 0; j < 4; j++)
                        hash.Add(line[i - j]);

                    if (hash.Count != 4) continue;
                    Console.WriteLine(i + 1);
                    break;
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
