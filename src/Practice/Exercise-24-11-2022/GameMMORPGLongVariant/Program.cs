using System;
using System.Linq;

namespace GameMMORPGLongVariant
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            string[] heroesNames = new string[numberOfHeroes];

            int[] heroesHP = new int[numberOfHeroes];

            int[] heroesMana = new int[numberOfHeroes];

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroesCommands = Console.ReadLine().Split().ToArray();
                heroesNames[i] = heroesCommands[0];
                heroesHP[i] = int.Parse(heroesCommands[1]);
                heroesMana[i] = int.Parse(heroesCommands[2]);
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split(" - ").ToArray();

                if (commands[0] == "End")
                {
                    break;
                }

                string heroName = commands[1];

                int heroIndex = Array.IndexOf(heroesNames, heroName);

                switch (commands[0])
                {
                    case "Heal":
                        int healAmount = int.Parse(commands[2]);
                        if (heroesHP[heroIndex] + healAmount <= 100)
                        {
                            heroesHP[heroIndex] += healAmount;
                            Console.WriteLine($"{heroName} healed for {healAmount} HP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} healed for {100 - heroesHP[heroIndex]} HP!");
                            heroesHP[heroIndex] = 100;
                        }
                        break;
                    case "Recharge":
                        int manaAmount = int.Parse(commands[2]);
                        if (heroesMana[heroIndex] + manaAmount <= 200)
                        {
                            heroesMana[heroIndex] += manaAmount;
                            Console.WriteLine($"{heroName} recharged for {manaAmount} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} recharged for {200 - heroesMana[heroIndex]} MP!");
                            heroesMana[heroIndex] = 200;
                        }
                        break;
                    case "TakeDamage":
                        int damageAmount = int.Parse(commands[2]);
                        string attacker = commands[3];
                        if (heroesHP[heroIndex] - damageAmount > 0)
                        {
                            heroesHP[heroIndex] -= damageAmount;
                            Console.WriteLine($"{heroName} was hit for {damageAmount} HP by {attacker} and now has {heroesHP[heroIndex]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                            heroesNames = heroesNames.Where(hn => hn != heroName).ToArray();
                            heroesHP = heroesHP.Where(hp => hp != heroesHP[heroIndex]).ToArray();
                            heroesMana = heroesMana.Where(hm => hm != heroesMana[heroIndex]).ToArray();
                        }
                        break;
                    case "CastSpell":
                        int spellManaAmount = int.Parse(commands[2]);
                        string spellName = commands[3];
                        if (spellManaAmount <= heroesMana[heroIndex])
                        {
                            heroesMana[heroIndex] -= spellManaAmount;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesMana[heroIndex]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        break;
                }
            }

            for (int i = 0; i < heroesNames.Length; i++)
            {
                Console.WriteLine(heroesNames[i]);
                Console.WriteLine($"  HP: {heroesHP[i]}");
                Console.WriteLine($"  MP: {heroesMana[i]}");
            }
        }
    }
}
