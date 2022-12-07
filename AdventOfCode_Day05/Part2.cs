namespace AdventOfCode_Day05
{
    internal static class Part2
    {
        public static void Solution()
        {
            const string fileLocation = @"C:\Users\ccb99\source\repos\AdventOfCode2022\Day05_Input.txt";

            try
            {
                using var input = new StreamReader(fileLocation);
                var lines = input.ReadToEnd().Split("\r\n");
                var stacks = new List<Stack<string>>();
                for (var i = 0; i < 9; i++)
                    stacks.Add(new Stack<string>());

                //Crate Stacks
                var k = 1;
                for (var i = 0; i < 9; i++)
                {
                    for (var j = 7; j > -1; j--)
                        if (!string.IsNullOrWhiteSpace(lines[j][k].ToString()))
                            stacks[i].Push(lines[j][k].ToString());
                    k += 4;
                }

                //Crane Instructions
                var movements = new List<List<int>>();
                for (var i = 10; i < lines.Length; i++)
                {
                    var temp = new List<int>();
                    for (var j = 1; j < 6; j += 2)
                        temp.Add(int.Parse(lines[i].Split(' ')[j]));
                    movements.Add(temp);
                }

                //Crane Movements
                var tempStack = new Stack<string>();
                foreach (var movement in movements)
                {
                    for (var i = 0; i < movement[0]; i++)
                        tempStack.Push(stacks[movement[1] - 1].Pop());

                    for (var i = 0; i < movement[0]; i++)
                        stacks[movement[2] - 1].Push(tempStack.Pop());
                }

                for (var i = 0; i < 9; i++)
                    Console.Write(stacks[i].Peek());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}