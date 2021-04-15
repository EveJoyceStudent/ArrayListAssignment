using System;
using System.Collections.Generic;

namespace ArraysLists
{
    class Program
    {
        static void Main(string[] args)
        {

            // Using Arrays
            // Create a program that reads in 5 names from the console.  It then prints out "Hello <name>" for all the names entered
            Console.WriteLine("enter 5 names, they will be printed");

            string[] names = new string[5];

            // this is hard and weird, do it with a for
            /*
            foreach(string s in names){
                Console.Write("enter name ");
                s = Console.ReadLine();
            }
            */

            string[] names_for = new string[5];
            for(int i = 0; i < names_for.Length; i++){
                Console.Write("enter name ");
                names_for[i] = Console.ReadLine();
            }
            for(int i = 0; i < names_for.Length; i++){
                Console.WriteLine("Hello "+names_for[i]);
            }
            

            // A program starts with the values 34, 5, 67, 1, 99, 34, 44, 78, 34, 0. Write a program that adds all numbers together and outputs the total.
            Console.WriteLine("sum of the values 34, 5, 67, 1, 99, 34, 44, 78, 34, 0");
            
            int[] values = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
            int sumValues = 0;
            foreach(int i in values){
                sumValues += i;
            }
            Console.WriteLine(sumValues);
            

            // Using Lists
            // Write a program that reads in 5 numbers. It then asks the user for another number and outputs whether the number has already been entered.
            Console.WriteLine("enter 5 numbers, then enter a check number, i'll tel lyou if that check number was in the first 5");
            
            List<string> userNumberList = new List<string>();
            for(int i = 0; i < 5; i++){
                Console.Write("enter number ");
                userNumberList.Add(Console.ReadLine());
            }
            Console.Write("enter check number ");
            string checkNumber = Console.ReadLine();
            if (userNumberList.Contains(checkNumber)){
                Console.WriteLine("number exists in the list");
            } else {
                Console.WriteLine("number does not exist in the list");
            }
            

            // As above except the program will tell the user how many times a repeated number has been entered
            Console.WriteLine("enter 5 numbers, then enter a check number, i'll tel lyou how many times that check number was in the first 5");
                        
            List<string> userNumberList2 = new List<string>();
            for(int i = 0; i < 5; i++){
                Console.Write("enter number ");
                userNumberList2.Add(Console.ReadLine());
            }
            Console.Write("enter check number ");
            string checkNumber2 = Console.ReadLine();
            var matchList = userNumberList2.FindAll(s => s==checkNumber2);
            if (userNumberList2.Contains(checkNumber2)){
                Console.WriteLine("number exists "+matchList.Count+" times in the list");
            } else {
                Console.WriteLine("number does not exist in the list");
            }
            

            // A program stores words read from console, until the word "stop" is entered.  It then outputs the words entered in reverse order.
            // stop counts as a word
            Console.WriteLine("enter words as many times as you would like, enter stop and i will repeat your words back to you.");
            
            stopVersion1();

            //stop doesn't count as a word
            Console.WriteLine("enter words as many times as you would like, enter stop and i will repeat your words back to you.");

            stopVersion2();

            

        }
        public static void stopVersion1(){
            List<string> wordList = new List<string>();
            bool stopEntered=false;
            string lastWord;

            while(!stopEntered){
                Console.Write("enter word: ");
                lastWord = Console.ReadLine();
                wordList.Add(lastWord);
                if(lastWord.ToLower()=="stop"){
                    stopEntered=true;
                }
            }
            Console.WriteLine("your words were:");
            for(int i = 0; i < wordList.Count; i++){
                Console.Write(wordList[wordList.Count-i-1]+" ");
            }
            Console.WriteLine(".");
        }
        public static void stopVersion2(){
            List<string> wordList = new List<string>();
            bool stopEntered=false;
            string lastWord;

            while(!stopEntered){
                Console.Write("enter word: ");
                lastWord = Console.ReadLine();
                if(lastWord.ToLower()=="stop"){
                    stopEntered=true;
                } else {
                    wordList.Add(lastWord);
                }
            }
            Console.WriteLine("your words were:");
            for(int i = 0; i < wordList.Count; i++){
                Console.Write(wordList[wordList.Count-i-1]+" ");
            }
            Console.WriteLine(".");
        }
    }
}
