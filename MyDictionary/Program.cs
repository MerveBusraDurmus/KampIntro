using System;

namespace MyDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1, "Kalem");
            myDictionary.Add(2, "Kitap");
            myDictionary.Add(3, "Defter");
            myDictionary.Add(4, "Silgi");
            myDictionary.Add(5, "Cetvel");
            myDictionary.Add(6, "Bant");


            myDictionary.GetAll();

        }
    }

   
}
