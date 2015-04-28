using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingTest
{

    public class Fish
    {
        public string FishName;
        public string FishColor;
        public int FishSize;

        public Fish(string FishName, string FishColor, int FizeSize)
        {
            this.FishName = FishName;
            this.FishColor = FishColor;
            this.FishSize = FizeSize;
        }
    }
    public class Pond
    {
        public List<Fish> fishes = new List<Fish>();


        public Fish getFish()
        {
            Random random = new Random();
            int index = random.Next(fishes.Count);
            Fish checkFish = fishes[index];
            fishes.RemoveAt(index);
            return checkFish;
        }
        public void fishesInPond()
        {
            for (int i = 0; i < fishes.Count; i++)
            {
                Console.WriteLine("[" + fishes[i].FishName + "]" + "[" + fishes[i].FishSize + "]" + "[" + fishes[i].FishColor + "]");
            }
        }

        public void addFishToPond(Fish fish)
        {
            fishes.Add(fish);
        }
    }
    public class Fisherman
    {
        public static string FishermanName;
        public List<Fish> Bucket = new List<Fish>();
        public void catchFish(Pond pond)
        {
            Fish CaughtFish;
            CaughtFish = pond.getFish();
            if (CaughtFish.FishSize < 10)
            {
                pond.addFishToPond(CaughtFish);
            }
            else
            {
                addFishToBucket(CaughtFish);
            }
        }
        public void fishesInBucket()
        {
            for (int i = 0; i < Bucket.Count; i++)
            {
                Console.WriteLine("[" + Bucket[i].FishName + "]" + "[" + Bucket[i].FishSize + "]" + "[" + Bucket[i].FishColor + "]");
            }
        }
        
        private void addFishToBucket(Fish fish)
        {
            if (Bucket.Count < 10)
            {
                Bucket.Add(fish);

            }
            else
            {
                Console.WriteLine("You Have Done Today..");

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Enter your Name:");
            Fisherman.FishermanName = Console.ReadLine();

            Fish shark = new Fish("Shark", "Grey", 12);
            Fish Dolphin = new Fish("Dolpin", "Black", 9);
            Fish Whale = new Fish("Whale", "White", 14);

           

            Pond Pond = new Pond();

            Pond.fishes.Add(shark);
            Pond.fishes.Add(Dolphin);
            Pond.fishes.Add(Whale);

            Fisherman fishing = new Fisherman();

           
            
            Console.Read();

        }
    }

}
