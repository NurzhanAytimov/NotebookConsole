using Notebook;
using System;

namespace NoteBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            TextDoc textDoc = new TextDoc();
            Console.WriteLine("Select category: ");
            Console.WriteLine("[1] Write text");
            Console.WriteLine("[2] Reader text");
            Console.WriteLine("[3] Search text ");
            Console.WriteLine("[4] Delete text");
            Console.WriteLine("[5] Exit");
            int res = int.Parse(Console.ReadLine());

            do
            {
                if (res == 1)
                {
                    Console.WriteLine("Write text:  ");
                    Console.WriteLine("-------------------");
                    string text = Console.ReadLine();
                    textDoc.FileWrite(text);
                    break;
                }

                else if (res == 2)
                {
                    Console.WriteLine("Read text: ");
                    Console.WriteLine("----------------");
                    textDoc.FileRead();
                    break;
                }
                else if (res == 3)
                {
                    Console.WriteLine("Enter the text you want to find: ");
                    Console.WriteLine("------------------");
                    string text = Console.ReadLine();
                    textDoc.FileSearch(text);

                }
                else if (res == 4)
                {
                    Console.WriteLine("[1] Delete specific text");
                    Console.WriteLine("[2] Clear file");
                    int number = int.Parse(Console.ReadLine());

                    if(number == 1)
                    {
                        Console.WriteLine("Enter the text you want to delete: ");
                        Console.WriteLine("-----------------");
                        string delete = Console.ReadLine();
                        textDoc.FileDeleteText(delete);
                    
                        break;
                    }
                    else
                    {
                        textDoc.FileClear();
                        break;
                    }

                }

                else
                {
                    break;
                }

            } while (res != 5);

           
        }
    }
}
