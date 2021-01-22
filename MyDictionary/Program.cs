using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            
            myDictionary.Add(1, "Github");

            foreach (var item in myDictionary.Items)
            {
                Console.WriteLine("Key: " +item.Key+"\t Value: "+item.Value);
            }

            Console.WriteLine("#####################################");

            myDictionary.Add(2, "Stackoverflow");
            myDictionary.Add(3, "Discord");

            foreach (var item in myDictionary.Items)
            {
                Console.WriteLine("Key: " + item.Key + "\t Value: " + item.Value);
            }

        }
    }
}
