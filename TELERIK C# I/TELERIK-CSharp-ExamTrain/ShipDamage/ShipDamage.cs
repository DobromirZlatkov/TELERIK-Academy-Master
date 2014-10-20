using System;
class ShipDamage
{
    static void Main()
    {
        int Sx1 = int.Parse(Console.ReadLine());
        int Sy1 = int.Parse(Console.ReadLine());
        int Sx2 = int.Parse(Console.ReadLine());
        int Sy2 = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());

        int Cx1 = int.Parse(Console.ReadLine());
        int Cy1 = int.Parse(Console.ReadLine());
        int Cx2 = int.Parse(Console.ReadLine());
        int Cy2 = int.Parse(Console.ReadLine());
        int Cx3 = int.Parse(Console.ReadLine());
        int Cy3 = int.Parse(Console.ReadLine());

        if (Sx1 > Sx2)
        {
            int temp = Sx2;
            Sx2 = Sx1;
            Sx1 = temp;
        }
        if (Sy1 < Sy2)
        {
            int temp = Sy2;
            Sy2 = Sy1;
            Sy1 = temp;
        }

        int dammage = 0;
        //shells fall on
        int firstHitX = Cx1;
        int firstHitY = 0;
        if (H >= 0)
        {
             firstHitY = -(Cy1 - H) + H;
        }
        else
        {
            firstHitY = (Cy1 + H) - H;
        }

        int secondHitX = Cx2;
        int secondHitY = 0;
        if (H >= 0)
        {
            secondHitY = -(Cy2 - H) + H;
        }
        else
        {
            secondHitY = (Cy2 + H) - H;
        }

        int thirdHitX = Cx3;
        int thirdHitY = 0;
        if (H >= 0)
        {
            thirdHitY = -(Cy3 - H) + H;
        }
        else
        {
            thirdHitY = (Cy3 + H) - H;
        }
        // first shells
        //is hit inside ship
        if ((Sx1 < firstHitX && Sx2 > firstHitX) && (Sy1 > firstHitY && Sy2 < firstHitY))
        {
            dammage += 100;
        }
        // hit on sides
        if (Sy1 == firstHitY && (Sx1 < firstHitX && Sx2 > firstHitX)
            || (Sy2 == firstHitY && (Sx1 < firstHitX && Sx2 > firstHitX))
            || (Sx1 == firstHitX && (Sy1 > firstHitY && Sy2 < firstHitY))
            || (Sx2 == firstHitX && (Sy1 > firstHitY && Sy2 < firstHitY)))
        {
            dammage += 50;
        }
        //hit on edjes;
        if ((Sx1 == firstHitX && Sy1 == firstHitY)
            ||(Sx1 == firstHitX && Sy2 == firstHitY)
            ||(Sx2 == firstHitX && Sy2 == firstHitY)
            ||(Sx2 == firstHitX && Sy1 == firstHitY))
        {
            dammage += 25;
        }

        // second shells

        //is hit inside ship
        if ((Sx1 < secondHitX && Sx2 > secondHitX) && (Sy1 > secondHitY && Sy2 < secondHitY))
        {
            dammage += 100;
        }
        // hit on sides
        if (Sy1 == secondHitY && (Sx1 < secondHitX && Sx2 > secondHitX)
            || (Sy2 == secondHitY && (Sx1 < secondHitX && Sx2 > secondHitX))
            || (Sx1 == secondHitX && (Sy1 > secondHitY && Sy2 < secondHitY))
            || (Sx2 == secondHitX && (Sy1 > secondHitY && Sy2 < secondHitY)))
        {
            dammage += 50;
        }
        //hit on edjes;
        if ((Sx1 == secondHitX && Sy1 == secondHitY)
            || (Sx1 == secondHitX && Sy2 == secondHitY)
            || (Sx2 == secondHitX && Sy2 == secondHitY)
            || (Sx2 == secondHitX && Sy1 == secondHitY))
        {
            dammage += 25;
        }


        // third shells
        if ((Sx1 < thirdHitX && Sx2 > thirdHitX) && (Sy1 > thirdHitY && Sy2 < thirdHitY))
        {
            dammage += 100;
        }
        // hit on sides
        if (Sy1 == thirdHitY && (Sx1 < thirdHitX && Sx2 > thirdHitX)
            || (Sy2 == thirdHitY && (Sx1 < thirdHitX && Sx2 > thirdHitX))
            || (Sx1 == thirdHitX && (Sy1 > thirdHitY && Sy2 < thirdHitY))
            || (Sx2 == thirdHitX && (Sy1 > thirdHitY && Sy2 < thirdHitY)))
        {
            dammage += 50;
        }
        //hit on edjes;
        if ((Sx1 == thirdHitX && Sy1 == thirdHitY)
            || (Sx1 == thirdHitX && Sy2 == thirdHitY)
            || (Sx2 == thirdHitX && Sy2 == thirdHitY)
            || (Sx2 == thirdHitX && Sy1 == thirdHitY))
        {
            dammage += 25;
        }

        Console.WriteLine("{0}%",dammage);
        // 90 to4ki ;[
    }
}
