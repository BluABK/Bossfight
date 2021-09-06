using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticHorizonsLib
{
    public class GameCharacter
    {
        private const int DefaultAttributeValue = 10;
        public string Name { get; set; }
        public string Profession { get; set; }
        public ConsumableAttribute Health;
        public ConsumableAttribute Mana;
        public ConsumableAttribute Stamina;
        public int Strength { get; set; } = DefaultAttributeValue;
        public int Defense { get; set; } = DefaultAttributeValue;
        public int Intelligence { get; set; } = DefaultAttributeValue;
        public int Dexterity { get; set; } = DefaultAttributeValue;

        public int Level { get; set; } = 1;
        public int Experience { get; set; } = 0;

        public readonly GameCharacterInventory Inventory;

        public GameCharacter(string name, int health, string profession = "enigma", int strength = DefaultAttributeValue, int stamina = DefaultAttributeValue, 
                             int mana = 0, int intelligence = DefaultAttributeValue, int dexterity = DefaultAttributeValue, int level = 1)
        {
            // Set values and store initials.
            Name         = name;
            Profession   = profession;
            Health       = new(health);
            Stamina      = new(stamina);
            Mana         = new(mana);
            Strength     = strength;
            Intelligence = intelligence;
            Dexterity    = dexterity;
            Level        = level;

        }

        private static string PaddedAttributeString(ConsumableAttribute attr, string name)
        {
            string descriptor = $"{name}:";

            return $"{descriptor,-5}{attr.Value}/{attr.MaxValue}";
        }

        private static string PaddedAttributeString(int attr, string name)
        {
            string descriptor = $"{name}:";

            return $"{descriptor,-5}{attr}";
        }

        public void AboutMe()
        {
            Console.WriteLine($"{Name}, the level {Level} {Profession}:");
            Console.WriteLine($"    {PaddedAttributeString(Health, "HP")}");
            Console.WriteLine($"    {PaddedAttributeString(Mana, "MP")}");
            Console.WriteLine($"    {PaddedAttributeString(Stamina, "STM")}");
            Console.WriteLine($"    {PaddedAttributeString(Strength, "STR")}");
            Console.WriteLine($"    {PaddedAttributeString(Defense, "DEF")}");
            Console.WriteLine($"    {PaddedAttributeString(Intelligence, "INT")}");
            Console.WriteLine($"    {PaddedAttributeString(Dexterity, "DEX")}");
        }
    }
}
