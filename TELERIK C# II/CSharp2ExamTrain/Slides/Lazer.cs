using System;

class Laser
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int w = int.Parse(input[0]);
        int h = int.Parse(input[1]);
        int d = int.Parse(input[2]);

        input = Console.ReadLine().Split(' ');
        int posW = int.Parse(input[0]) - 1;
        int posH = int.Parse(input[1]) - 1;
        int posD = int.Parse(input[2]) - 1;

        input = Console.ReadLine().Split(' ');
        int dirW = int.Parse(input[0]);
        int dirH = int.Parse(input[1]);
        int dirD = int.Parse(input[2]);

        bool[, ,] cuboid = new bool[w, h, d];

        for (int W = 0; W < w; W++)
        {
            for (int H = 0; H < h; H++)
            {
                for (int D = 0; D < d; D++)
                {
                    if (W == 0 || W == w - 1)
                    {
                        if (H == 0 || H == h - 1 || D == 0 || D == d - 1)
                        {
                            cuboid[W, H, D] = true;
                        }
                    }
                    else if (H == 0 || H == h - 1)
                    {
                        if (D == 0 || D == d - 1)
                        {
                            cuboid[W, H, D] = true;
                        }
                    }
                }
            }
        }

        while (true)
        {
            cuboid[posW, posH, posD] = true;

            posW += dirW;
            posH += dirH;
            posD += dirD;

            if (cuboid[posW, posH, posD])
            {
                posW -= dirW;
                posH -= dirH;
                posD -= dirD;
                break;
            }

            if (posW == 0 || posW == (w - 1))
            {
                dirW *= -1;
            }

            if (posH == 0 || posH == (h - 1))
            {
                dirH *= -1;
            }

            if (posD == 0 || posD == (d - 1))
            {
                dirD *= -1;
            }
        }

        Console.WriteLine("{0} {1} {2}", posW + 1, posH + 1, posD + 1);
    }
}