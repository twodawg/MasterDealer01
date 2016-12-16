using System;

namespace MasterDealer01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------ Ranks --------");
            for (int i = 0; i < 13; i++)
            {
                //Console.WriteLine(i);
                Console.WriteLine((RankType)i);
            }
            Console.WriteLine("------ Suits --------");
            for (int i = 0; i < Enum.GetNames(typeof(SuitType)).Length; i++)
            {
                Console.WriteLine((SuitType)i);
            }
            Console.ReadLine();
        }
    }
    public enum SuitType
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }
    public enum RankType
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
