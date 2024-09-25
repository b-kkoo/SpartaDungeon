using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Lv { get; set; }
        int Hp { get; set; }
        int Atk { get; set; }
        int Def { get; set; }
    }

    public class Warrior : IPlayer
    {
        public string Name { get; set; }
        public string Chad { get; set; }
        public int Lv { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }

        public Warrior()
        {

        }
    }

    public interface Item
    {
        string Name { get; set; }
        string Info { get; set; }
        int Atk { get; set; }
        int Def { get; set; }
        int Price { get; set; }
    }

    public class Item1 : Item
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Price { get; set; }

        public Item1()
        {
            Name = "수련자 갑옷";
            Info = "수련에 도움을 주는 갑옷";
            Def = 5;
        }

        public void ItemInfo()
        {
            Console.Write($" {Name} | 방어력 +{Def} | {Info}");
        }
    }

    public class Item2 : Item
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Price { get; set; }

        public Item2()
        {
            Name = "무쇠갑옷";
            Info = "무쇠로 만들어져 튼튼한 갑옷";
            Def = 9;
        }
        public void ItemInfo()
        {
            Console.Write($" {Name} | 방어력 +{Def} | {Info}");
        }
    }

    public class Item3 : Item
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Price { get; set; }

        public Item3()
        {
            Name = "스파르타의 갑옷";
            Info = "스파르타의 전사들이 사용했다는 전설의 갑옷";
            Atk = 3;
            Def = 17;
        }
        public void ItemInfo()
        {
            Console.Write($" {Name} | 공격력 +{Atk} | 방어력 +{Def} | {Info}");
        }
    }

    public class Item4 : Item
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Price { get; set; }

        public Item4()
        {
            Name = "낡은 검";
            Info = "쉽게 볼 수 있는 낡은 검";
            Atk = 2;
        }

        public void ItemInfo()
        {
            Console.Write($" {Name} | 방어력 +{Def} | {Info}");
        }

    }

    public class Item5 : Item
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Price { get; set; }

        public Item5()
        {
            Name = "청동 도끼";
            Info = "어디선가 사용됐던 것 같은 도끼";
            Atk = 5;
        }
        public void ItemInfo()
        {
            Console.Write($" {Name} | 방어력 +{Def} | {Info}");
        }
    }

    public class Item6 : Item
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Price { get; set; }

        public Item6()
        {
            Name = "스파르타의 창";
            Info = "스파르타의 전사들이 사용했다는 전설의 창";
            Atk = 7;
            Def = 3;
        }
        public void ItemInfo()
        {
            Console.Write($" {Name} | 공격력 +{Atk} | 방어력 +{Def} | {Info}");
        }
    }


    internal class Data
    {
    }
}
