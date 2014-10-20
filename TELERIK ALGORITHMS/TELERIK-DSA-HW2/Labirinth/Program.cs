using System;
using System.Text;
using System.Collections.Generic;

struct Coordinates
{
    public int Row { get; private set; }
    public int Col { get; private set; }

    public Coordinates(int row, int col)
        : this()
    {
        this.Row = row;
        this.Col = col;
    }

    public static Coordinates operator +(Coordinates a, Coordinates b)
    {
        return new Coordinates(
            a.Row + b.Row,
            a.Col + b.Col
        );
    }

    public static Coordinates operator -(Coordinates a, Coordinates b)
    {
        return new Coordinates(
            a.Row - b.Row,
            a.Col - b.Col
        );
    }
}

static class Program
{
    static readonly ICollection<Coordinates> Directions = new Coordinates[]
    {
        new Coordinates( 0,  1),
        new Coordinates( 1,  0),
        new Coordinates( 0, -1),
        new Coordinates(-1,  0),
    };

    static void Main()
    {
        string[,] labyrinth =  
        {
            { "0", "0", "0", "#", "0", "#" },
            { "0", "#", "0", "#", "0", "#" },
            { "0", "X", "#", "0", "#", "0" },
            { "0", "#", "0", "0", "0", "0" },
            { "0", "0", "0", "#", "#", "0" },
            { "0", "0", "0", "#", "0", "#" },
        };

        var currentQueue = new Queue<Coordinates>();
        currentQueue.Enqueue(labyrinth.GetCoordinate("X"));

        int step = 0;

        while (currentQueue.Count != 0)
        {
            var nextQueue = new Queue<Coordinates>();

            step++;

            while (currentQueue.Count != 0)
            {
                Coordinates currentCoordinates = currentQueue.Dequeue();

                foreach (Coordinates currentDirection in Directions)
                {
                    Coordinates nextCoordinates = currentCoordinates + currentDirection;

                    if (!labyrinth.IsInRange(nextCoordinates))
                    {
                        continue;
                    }

                    if (labyrinth[nextCoordinates.Row, nextCoordinates.Col] != "0")
                    {
                        continue;
                    }

                    labyrinth[nextCoordinates.Row, nextCoordinates.Col] = step.ToString();
                    nextQueue.Enqueue(nextCoordinates);
                }
            }

            currentQueue = nextQueue;
        }

        Console.WriteLine(labyrinth.Replace("_", "u").VisualizeMatrix());
    }

    static Coordinates GetCoordinate<T>(this T[,] matrix, T element)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
            for (int col = 0; col < matrix.GetLength(1); col++)
                if (matrix[row, col].Equals(element))
                    return new Coordinates(row, col);

        throw new ArgumentException("Invalid element.");
    }

    static bool IsInRange<T>(this T[,] matrix, Coordinates coordinates)
    {
        return (0 <= coordinates.Row) && (coordinates.Row < matrix.GetLength(0)) &&
               (0 <= coordinates.Col) && (coordinates.Col < matrix.GetLength(1));
    }

    static T[,] Replace<T>(this T[,] matrix, T oldValue, T newValue)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col].Equals(oldValue))
                {
                    matrix[row, col] = newValue;
                }
            }
        }

        return matrix;
    }

    static string VisualizeMatrix<T>(this T[,] matrix)
    {
        var result = new StringBuilder();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                result.Append(matrix[row, col] + (col != matrix.GetUpperBound(1) ? " " : Environment.NewLine));
            }
        }

        return result.ToString().TrimEnd();
    }
}