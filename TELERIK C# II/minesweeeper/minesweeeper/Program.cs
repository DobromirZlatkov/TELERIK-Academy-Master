

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Minesweeper
    {
        public class PlayerScore
        {
            private string name;
            private int score;

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public int Score
            {
                get
                {
                    return score;
                }

                set
                {
                    score = value;
                }
            }

            public PlayerScore(string name, int score)
            {
                this.Name = name;
                this.Score = score;
            }
        }

        static void Main(string[] args)
        {
            string command = string.Empty;

            char[,] playBoard = MatrixBoardBuilder();
            char[,] bombs = RandomBombsGenerator();

            int score = 0;

            bool isMineVisited = false;
            bool isPlayable = true;
            bool isWonGame = false;

            List<PlayerScore> champions = new List<PlayerScore>(6);

            int row = 0;
            int col = 0;

            const int MAX = 35;

            do
            {
                if (isPlayable)
                {
                    Console.WriteLine("Let`s play Minesweeper. Let`s try to find all mines without mine." +
                    " Command 'top' show Player statistics by score, 'restart' begin new game, 'exit' just quit the game!");
                    PrintBoard(playBoard);
                    isPlayable = false;
                }

                Console.Write("Please enter Row and Column : ");

                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= playBoard.GetLength(0) && col <= playBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PlayersStatisticsByScore(champions);
                        break;

                    case "restart":
                        playBoard = MatrixBoardBuilder();
                        bombs = RandomBombsGenerator();
                        PrintBoard(playBoard);
                        isMineVisited = false;
                        isPlayable = false;
                        break;

                    case "exit":
                        Console.WriteLine("Bye, bye!");
                        break;

                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                tisinahod(playBoard, bombs, row, col);
                                score++;
                            }

                            if (MAX == score)
                            {
                                isWonGame = true;
                            }
                            else
                            {
                                PrintBoard(playBoard);
                            }
                        }
                        else
                        {
                            isMineVisited = true;
                        }
                        break;

                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (isMineVisited)
                {
                    PrintBoard(bombs);
                    Console.Write("\nHrrrrrr! You lose this game. Your score was {0} points. " +
                        "Please enter your nickname: ", score);

                    string nickname = Console.ReadLine();
                    PlayerScore t = new PlayerScore(nickname, score);

                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Score < t.Score)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((PlayerScore firstPlayer, PlayerScore secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    champions.Sort((PlayerScore firstPlayer, PlayerScore secondPlayer) => secondPlayer.Score.CompareTo(firstPlayer.Score));
                    PlayersStatisticsByScore(champions);

                    playBoard = MatrixBoardBuilder();
                    bombs = RandomBombsGenerator();

                    score = 0;

                    isMineVisited = false;
                    isPlayable = true;
                }

                if (isWonGame)
                {
                    Console.WriteLine("\nWell done! You won this game");

                    PrintBoard(bombs);

                    Console.WriteLine("Please enter your name!: ");

                    string playerName = Console.ReadLine();
                    PlayerScore scoreOfCurrentPlayer = new PlayerScore(playerName, score);
                    champions.Add(scoreOfCurrentPlayer);
                    PlayersStatisticsByScore(champions);

                    playBoard = MatrixBoardBuilder();
                    bombs = RandomBombsGenerator();

                    score = 0;

                    isWonGame = false;
                    isPlayable = true;
                }
            }

            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }

        private static void PlayersStatisticsByScore(List<PlayerScore> scores)
        {
            Console.WriteLine("\nScore:");

            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, scores[i].Name, scores[i].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void tisinahod(char[,] gameBoard, char[,] bombs, int row, int col)
        {
            char numberOfBombsAround = NumberOfBombsAroundCurrentCell(bombs, row, col);
            bombs[row, col] = numberOfBombsAround;

            gameBoard[row, col] = numberOfBombsAround;
        }

        private static void PrintBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] MatrixBoardBuilder()
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

        private static char[,] RandomBombsGenerator()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameBoard = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameBoard[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>();

            while (bombs.Count < 15)
            {
                Random random = new Random();
                int randomBomb = random.Next(50);

                if (!bombs.Contains(randomBomb))
                {
                    bombs.Add(randomBomb);
                }
            }

            foreach (int bomb in bombs)
            {
                int col = (bomb / cols);
                int row = (bomb % cols);

                if (row == 0 && bomb != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                gameBoard[col, row - 1] = '*';
            }

            return gameBoard;
        }

        private static void smetki(char[,] gameBoard)
        {
            int rows = gameBoard.GetLength(0);
            int cols = gameBoard.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (gameBoard[row, col] != '*')
                    {
                        char numberOfBombsAround = NumberOfBombsAroundCurrentCell(gameBoard, row, col);
                        gameBoard[row, col] = numberOfBombsAround;
                    }
                }
            }
        }

        private static char NumberOfBombsAroundCurrentCell(char[,] gameBoard, int currentRow, int currentCol)
        {
            int numberOfBombs = 0;

            int rows = gameBoard.GetLength(0);
            int cols = gameBoard.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (gameBoard[currentRow - 1, currentCol] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (currentRow + 1 < rows)
            {
                if (gameBoard[currentRow + 1, currentCol] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (currentCol - 1 >= 0)
            {
                if (gameBoard[currentRow, currentCol - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (currentCol + 1 < cols)
            {
                if (gameBoard[currentRow, currentCol + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
            {
                if (gameBoard[currentRow - 1, currentCol - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol + 1 < cols))
            {
                if (gameBoard[currentRow - 1, currentCol + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((currentRow + 1 < rows) && (currentCol - 1 >= 0))
            {
                if (gameBoard[currentRow + 1, currentCol - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((currentRow + 1 < rows) && (currentCol + 1 < cols))
            {
                if (gameBoard[currentRow + 1, currentCol + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            return char.Parse(numberOfBombs.ToString());
        }
    }
}

