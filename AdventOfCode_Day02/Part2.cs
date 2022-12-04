namespace AdventOfCode_Day02
{
    internal class Part2
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
                            if (round[1] == "X") //Lose
                                total += 3;

                            if (round[1] == "Y") //Tie
                                total += 4;

                            if (round[1] == "Z") //Win
                                total += 8;
                        }

                        if (round[0] == "B") //Paper
                        {
                            if (round[1] == "X") //Lose
                                total += 1;

                            if (round[1] == "Y") //Tie
                                total += 5;

                            if (round[1] == "Z") //Win
                                total += 9;
                        }

                        if (round[0] == "C") //Scissors
                        {
                            if (round[1] == "X") //Lose
                                total += 2;

                            if (round[1] == "Y") //Tie
                                total += 6;

                            if (round[1] == "Z") //Win
                                total += 7;
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
