using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Gift
        {
            string name;
            string christmasGift;
            

            public Gift(string _name, string _christmasGift)
            {
                name = _name;
                christmasGift = _christmasGift;
            }

            public string Name
            {
                get { return name; }
            }
            public string ChristmasGift
            {
                get { return christmasGift; }
            }
           
        }
        static void Main(string[] args)
        {
            List<Gift> myGifts = new List<Gift>();
            string[] giftssFromFile = GetDataFromFile();

            foreach (string line in giftssFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Gift newGift = new Gift(tempArray[0], tempArray[1]);
                myGifts.Add(newGift);
            }

            foreach (Gift giftFromFileList in myGifts)
            {
                Console.WriteLine($"{giftFromFileList.Name} wants {giftFromFileList.ChristmasGift} for Christmas");
            }

        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"D:\Programmeerimise algkursus (RKE132)\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
