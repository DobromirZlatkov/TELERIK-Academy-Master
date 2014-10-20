namespace MineSweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MineSweeper
    {
        private static void RankList(List<Result> points)
        {
            Console.WriteLine("\nTo4KI:");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].PlayerName, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void YourTurn(char[,] field, char[,] mines, int row, int col)
        {
            char numberOfBOmbs = CalculateNumberOfMinesAroundPossition(mines, row, col);
            field[row, col] = numberOfBOmbs;
            mines[row, col] = numberOfBOmbs;
        }

        private static void PrintPlayField(char[,] board)
        {
            int width = board.GetLength(0);
            int height = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < width; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < height; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] LoadMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] playField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int possition = random.Next(50);
                if (!mines.Contains(possition))
                {
                    mines.Add(possition);
                }
            }

            foreach (int mine in mines)
            {
                int col = mine / cols;
                int row = mine % cols;

                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                playField[col, row - 1] = '*';
            }

            return playField;
        }

        private static void LoadNumberOfMinesAroundPossition(char[,] playField)
        {
            int cols = playField.GetLength(0);
            int rows = playField.GetLength(1);

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (playField[i, j] != '*')
                    {
                        char numberOfMines = CalculateNumberOfMinesAroundPossition(playField, i, j);
                        playField[i, j] = numberOfMines;
                    }
                }
            }
        }

        private static char CalculateNumberOfMinesAroundPossition(char[,] playField, int row, int col)
        {
            int mineCounter = 0;
            int rows = playField.GetLength(0);
            int cols = playField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playField[row - 1, col] == '*')
                {
                    mineCounter++;
                }
            }

            if (row + 1 < rows)
            {
                if (playField[row + 1, col] == '*')
                {
                    mineCounter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (playField[row, col - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if (col + 1 < cols)
            {
                if (playField[row, col + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playField[row - 1, col - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (playField[row - 1, col + 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playField[row + 1, col - 1] == '*')
                {
                    mineCounter++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (playField[row + 1, col + 1] == '*')
                {
                    mineCounter++;
                }
            }

            return char.Parse(mineCounter.ToString());
        }

        public class Result
        {
            private string playerName;
            private int points;

            public Result()
            {
            }

            public Result(string name, int points)
            {
                this.playerName = name;
                this.points = points;
            }

            public string PlayerName
            {
                get { return this.playerName; }
                set { this.playerName = value; }
            }

            public int Points
            {
                get { return this.points; }
                set { this.points = value; }
            }
        }

        public static void Main(string[] args)
        {
            string currentCommand = string.Empty;
            char[,] playField = CreatePlayField();
            char[,] mines = LoadMines();
            int pointsCounter = 0;
            bool isMineHit = false;
            List<Result> champions = new List<Result>(6);
            int row = 0;
            int column = 0;
            bool isGameStarted = true;
            const int NUMBER_OF_CELLS = 35;
            bool isGameWon = false;

            do
            {
                if (isGameStarted)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    PrintPlayField(playField);
                    isGameStarted = false;
                }

                Console.Write("Daj red i kolona : ");
                currentCommand = Console.ReadLine().Trim();
                if (currentCommand.Length >= 3)
                {
                    if (int.TryParse(currentCommand[0].ToString(), out row) &&
                    int.TryParse(currentCommand[2].ToString(), out column) &&
                        row <= playField.GetLength(0) && column <= playField.GetLength(1))
                    {
                        currentCommand = "turn";
                    }
                }

                switch (currentCommand)
                {
                    case "top":
                        RankList(champions);
                        break;
                    case "restart":
                        playField = CreatePlayField();
                        mines = LoadMines();
                        PrintPlayField(playField);
                        isMineHit = false;
                        isGameStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                YourTurn(playField, mines, row, column);
                                pointsCounter++;
                            }

                            if (NUMBER_OF_CELLS == pointsCounter)
                            {
                                isGameWon = true;
                            }
                            else
                            {
                                PrintPlayField(playField);
                            }
                        }
                        else
                        {
                            isMineHit = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (isMineHit)
                {
                    PrintPlayField(mines);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", pointsCounter);

                    string playerName = Console.ReadLine();

                    Result resultOfPlayer = new Result(playerName, pointsCounter);
                    if (champions.Count < 5)
                    {
                        champions.Add(resultOfPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < resultOfPlayer.Points)
                            {
                                champions.Insert(i, resultOfPlayer);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Result firstPlayer, Result secondPlayer) => secondPlayer.PlayerName.CompareTo(firstPlayer.PlayerName));
                    champions.Sort((Result firstPlayer, Result secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    RankList(champions);

                    playField = CreatePlayField();
                    mines = LoadMines();
                    pointsCounter = 0;
                    isMineHit = false;
                    isGameStarted = true;
                }

                if (isGameWon)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    PrintPlayField(mines);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    Result to4kii = new Result(imeee, pointsCounter);
                    champions.Add(to4kii);
                    RankList(champions);
                    playField = CreatePlayField();
                    mines = LoadMines();
                    pointsCounter = 0;
                    isGameWon = false;
                    isGameStarted = true;
                }
            }
            while (currentCommand != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }
    }
}
