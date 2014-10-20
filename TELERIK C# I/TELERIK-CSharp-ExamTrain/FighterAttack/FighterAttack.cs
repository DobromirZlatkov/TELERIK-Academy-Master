using System;
class FighterAttack
{
    static void Main()
    {
        int Px1 = int.Parse(Console.ReadLine());
        int Py1 = int.Parse(Console.ReadLine());
        int Px2 = int.Parse(Console.ReadLine());
        int Py2 = int.Parse(Console.ReadLine());
        int Fx = int.Parse(Console.ReadLine());
        int Fy = int.Parse(Console.ReadLine());

        int D = int.Parse(Console.ReadLine());


        int damage = 0;
        int fieldTopBOund = Math.Max(Py1, Py2);
        int fieldRightBound = Math.Max(Px1, Px2);
        int fieldLeftBOud = Math.Min(Px1, Px2);
        int fieldVottomBound = Math.Min(Py1, Py2);

        int missleHitX = Fx + D;
        int missleHitY = Fy;
        //proverka dali e v pravoygylnika

        if (missleHitX >= fieldLeftBOud && missleHitX <= fieldRightBound // proverka dali e v kvadrata bomata
            && missleHitY <= fieldTopBOund && missleHitY >= fieldVottomBound)
        {
            damage = 100;
        }
        if (missleHitX + 1 >= fieldLeftBOud && missleHitX + 1 <= fieldRightBound // proverka dali poleto pred bombata e v kvadrata
            && missleHitY <= fieldTopBOund && missleHitY >= fieldVottomBound)
        {
            damage += 75;
        }
        if (missleHitX >= fieldLeftBOud && missleHitX <= fieldRightBound 
            && missleHitY + 1 <= fieldTopBOund && missleHitY + 1 >= fieldVottomBound)// proverka dali gornata 4ast e v kvadrata
        {
            damage += 50;
        }
        if (missleHitX >= fieldLeftBOud && missleHitX <= fieldRightBound 
            && missleHitY - 1 <= fieldTopBOund && missleHitY - 1 >= fieldVottomBound)
        {
            damage += 50;
        }
        Console.WriteLine(damage + "%");
    }
}
