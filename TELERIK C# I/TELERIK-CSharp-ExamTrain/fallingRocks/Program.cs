using System;
using System.Threading;
using System.Text;
using System.Collections;
/*
 Created by Borislav Vaptsarov
 */
class Program
{
    static int difficulty;
    static Random random = new Random();
    static int pos = 20, score = 0;
    static string[] allLines = new string[10000];
    static char[] ch = new char[100];
    static char[] lineAtConsole = new char[40];
    static char[] rocks = { '^', '@', '*', '+', '%', '$', '#', '!', '.', ';' };//rock symbols ^ @ * + % $ # ! . ;

    static string printCurrentLine()
    {
        byte howManyRocksAtEachLine = (byte)random.Next(0, 5);
        insertRockAtRandomInLine(howManyRocksAtEachLine);
        string tempLine = new string(lineAtConsole);
        Array.Clear(lineAtConsole, 0, lineAtConsole.Length);
        return tempLine;
    }

    static private void insertRockAtRandomInLine(byte rocksOnLine)
    {
        for (int i = 0; i < rocksOnLine; i++)
        {
            lineAtConsole[random.Next(0, 40)] = rocks[random.Next(0, rocks.Length)];
        }
    }

    static string isKeyPressed()
    {

        DateTime timeoutvalue = DateTime.Now.AddSeconds(0.009);


        string s;
        while (DateTime.Now < timeoutvalue)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keypress = Console.ReadKey();
                if (keypress.Key == ConsoleKey.LeftArrow)
                {
                    if (pos == 0) continue;
                    else
                    {
                        pos = pos - 1;
                        ch[pos] = ch[pos + 1];
                        ch[pos + 1] = ' ';
                    }
                    return s = new string(ch);
                }
                if (keypress.Key == ConsoleKey.RightArrow)
                {
                    if (pos == 39) continue;
                    else
                    {
                        pos = pos + 1;
                        ch[pos] = ch[pos - 1];
                        ch[pos - 1] = ' ';
                    }

                    return s = new string(ch);
                }
            }
            return s = new string(ch);
        }

        return s = new string(ch);
    }

    static void Main(string[] args)
    {
    newGame:
        ch[pos] = '0';
        Stack outPutTheFirstInOut = new Stack();
        StringBuilder tempStringForFirstScreen = new StringBuilder();
        StringBuilder mainStringForDataSaving = new StringBuilder();
        Console.SetWindowSize(40, 22);
        Console.SetBufferSize(500, 500);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        difficulty = 250;
        //Console.CursorVisible = false;
        fillTheLines();

        int primaryCounterSecondPart = 1, sm = 0;
        int lowerLimit = 1;
        while (true)
        {
            if (primaryCounterSecondPart != 20)
            {
                tempStringForFirstScreen.Clear();

                Thread.Sleep(250);

                Console.Clear();
                for (int i = primaryCounterSecondPart; i >= 0; i--)
                {
                    string temp = allLines[i];
                    tempStringForFirstScreen.Append(temp).AppendLine();
                }
                tempStringForFirstScreen.Append(isKeyPressed()).AppendLine();
                mainStringForDataSaving.Clear();
                mainStringForDataSaving.Append(tempStringForFirstScreen);

                Console.WriteLine(tempStringForFirstScreen);

                primaryCounterSecondPart++;
                if (primaryCounterSecondPart == 20)
                {
                    for (int i = (primaryCounterSecondPart + 1); i >= 1; i--)
                    {
                        string temp = allLines[i];
                        mainStringForDataSaving.Append(temp).AppendLine();
                    }
                    mainStringForDataSaving.Append(isKeyPressed()).AppendLine();
                    primaryCounterSecondPart = 20;
                    sm = primaryCounterSecondPart + 1;
                }
            }
            else
            {

                Console.WriteLine(mainStringForDataSaving);
                mainStringForDataSaving.Clear();
                Thread.Sleep(difficulty);
                Console.Clear();

                for (int i = sm; i >= lowerLimit; i--)
                {
                    string deleteMe = allLines[lowerLimit - 1];
                    string temp = allLines[i];
                    mainStringForDataSaving.Append(temp).AppendLine();
                    if (checkIfOver(deleteMe)) goto outer;
                }
                score++;
                if (score % 20 == 0) difficulty -= 10;
                mainStringForDataSaving.Append(isKeyPressed()).AppendLine();
                sm++;
                lowerLimit++;
            }

        }
    outer:
        Console.WriteLine("Game Over");
        if (score <= 10) Console.WriteLine("Your score is {0}, \nkinda sucks you know.. :p", (int)score * 15);
        if (score >= 10 && score <= 50) Console.WriteLine("Your score is {0}, \nwelcome to the dark side young padawan!", (int)score * 25);
        if (score >= 60) Console.WriteLine("Your score is {0}, you \nshouldn't be playing that game, it sucks.", (int)score * 35);
        Console.WriteLine("A new game will start in a moment");
        Thread.Sleep(5000);
        goto newGame;

    }

    private static void fillTheLines()
    {
        for (int i = 0; i < 9999; i++)
        {
            allLines[i] = printCurrentLine();
        }
    }

    private static bool checkIfOver(string str2)
    {
        for (int i = 0; i < str2.Length; i++)
        {
            if ((str2[i] == (char)94 || str2[i] == (char)64 || str2[i] == (char)42 || str2[i] == (char)38 || str2[i] == (char)43 || str2[i] == (char)37 || str2[i] == (char)36 || str2[i] == (char)35 || str2[i] == (char)33 || str2[i] == (char)46 || str2[i] == (char)59) && i == pos)
            {
                return true;
            }

        }
        return false;
    }
}