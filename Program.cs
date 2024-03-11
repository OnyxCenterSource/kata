namespace Kata
{
    record Point(int X, int Y);
    record Line(Point From, Point To);

    class Program
    {
        static Line[] SolvePuzzle(int[,] board)
        {
            var lines = new List<Line>();

            // Non-zero board cells represent islands that should have the corresponding
            // number of bridges connecting them to their horizontal/vertical neighbors,
            // without crossing any other islands or bridges, with maximum two bridges
            // between any two islands, interconnecting all islands.
            //
            // Only need bridges in a single direction, e.g. only (x1, y1) -> (x2, y2) and 
            // not (x2, y2) -> (x1, y1) in addition.
            //
            // How to add bridge/lines, e.g. from (0,0) to (0, 2): lines.Add(new(new(0, 0), new(0, 2)));

            // TODO: Calculate bridge locations as lines between islands ((x1, y1) -> (x2, y2))            
            
            return lines.ToArray();
        }

        static void Main(string[] args)
        {
            var board = new int[7, 7] {
                { 4, 0, 4, 0, 3, 0, 2 },
                { 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 2, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 },
                { 5, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0 },
                { 3, 0, 2, 0, 5, 0, 3 }
            };
            
            var lines = SolvePuzzle(board);

            // Expected lines from top-right 4:
            // (0, 0) -> (0, 2) to right 4
            // (0, 0) -> (0, 2) to right 4
            // (0, 0) -> (4, 0) to below 5
            // (0, 0) -> (4, 0) to below 5

            foreach (var line in lines)
            {
                Console.WriteLine($"({line.From.X}, {line.From.Y}) -> ({line.To.X}, {line.To.Y})");
            }
        }
    }
}