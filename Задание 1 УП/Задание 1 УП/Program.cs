using System;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1.");
            string a = "Hello";
            string b = " World";
            Console.WriteLine(a + b);

            Console.WriteLine("Задание 2.");
            int ab = 3;
            int bb = 6;
            Console.WriteLine($"a + b = {ab + bb}");
            Console.WriteLine($"b - a = {bb - ab}");
            Console.WriteLine($"a * b = {ab * bb}");
            Console.WriteLine($"b / a = {bb / ab}");


            Console.WriteLine("Задание 3.");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию : ");
            string surname = Console.ReadLine();
            Console.Write("Введите отчество : ");
            string second_name = Console.ReadLine();
            Console.WriteLine($"{name} {surname} {second_name}");

            Console.WriteLine("Задание 4.");
            int HP_player = 100;
            int HP_monster = 180;

            int dmg_player = 10;
            int dmg_monster = 15;

            int def_player = 5;
            int def_monster = 5;

            int dmgPlayer = dmg_player - def_monster;
            int dmgMonster = dmg_monster - def_player;

            int hp_player = HP_player - dmgMonster;
            int hp_monster = HP_monster - dmgPlayer;

            Console.WriteLine($"hp player = {hp_player} /n hp monster = {hp_monster} /n dmg player = {dmgPlayer} /n dmg monser = {dmgMonster}");

        }
    }
}