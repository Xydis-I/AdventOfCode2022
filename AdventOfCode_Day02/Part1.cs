namespace AdventOfCode_Day02
{
    internal class Part1
    {
        public static void Solution()
        {
            var fileLocation = @"C:\Users\ccb99\source\repos\AdventOfCode2022\Day02_Input.txt";

            try
            {
                using (var input = new StreamReader(fileLocation))
                {
                    var lines = input.ReadToEnd().Split("\r\n");
                    var rounds = new List<string[]>();
                    foreach (var line in lines)
                        rounds.Add(line.Split(" "));

                    var total = 0;

                    foreach (var round in rounds)
                    {
                        if (round[0] == "A") //Rock
                        {
                            if (round[1] == "X") //Rock
                                total += 4;

                            if (round[1] == "Y") //Paper
                                total += 8;

                            if (round[1] == "Z") //Scissors
                                total += 3;
                        }

                        if (round[0] == "B") //Paper
                        {
                            if (round[1] == "X") //Rock
                                total += 1;

                            if (round[1] == "Y") //Paper
                                total += 5;

                            if (round[1] == "Z") //Scissors
                                total += 9;
                        }

                        if (round[0] == "C") //Scissors
                        {
                            if (round[1] == "X") //Rock
                                total += 7;

                            if (round[1] == "Y") //Paper
                                total += 2;

                            if (round[1] == "Z") //Scissors
                                total += 6;
                        }
                    }

                    Console.WriteLine(total);
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
