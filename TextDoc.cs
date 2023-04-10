using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    
    public class TextDoc
    {
        //Имя файла
       public string fileName = @"C:\\Users\\PC\\source\repos\\Notebook\\notebook.txt";

     //Метод для записи в блокнот
       public void FileWrite(string text)
        {
            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Append);

                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(text);

                streamWriter.Close();
                fileStream.Close();

                Console.WriteLine("Text written!!");
            }catch(Exception ex) 
            {
                Console.WriteLine("Error!");
            }
            
        }
        //Метод для вывода в консоль текста в блокноте
        public void FileRead()
        {
            try
            {
                StreamReader streamReader = new StreamReader(fileName);
                string text = streamReader.ReadToEnd(); 
                Console.WriteLine(text);
                streamReader.Close();

            }catch(Exception ex)
            {
                Console.WriteLine("Error!");
            };

        }
        //метод для пойска 
        public void FileSearch(string text)
        {
            try
            {
                StreamReader streamReader = new StreamReader(fileName);

                string texts = streamReader.ReadToEnd();
                string[] words = texts.Split('.');

                foreach (string word in words) 
                {
                    if (word.Contains(text))
                    {
                        Console.WriteLine("Find text: " + word);
                    }
                   
                }

                streamReader.Close();   

            }
            catch (Exception ex)
            {
                Console.WriteLine("Not find!");

            }
        }

        //метод для удаления текста
        public void FileDeleteText(string text)
        {
            string fileText;
            try
            {
                using(StreamReader stream = new StreamReader(fileName))
                {
                    fileText = stream.ReadToEnd();
                }
                fileText = fileText.Replace(text, "");

                using(StreamWriter streamWriter = new StreamWriter(fileName))
                {
                    streamWriter.Write(fileText);
                }

                Console.WriteLine("Text delete!");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Error!");
            }
        }
        //метод для очистки файла полностью
        public void FileClear()
        {
            try
            {
                StreamWriter stream = new StreamWriter(fileName);
                stream.Write("");

                Console.WriteLine("File clear!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!");
            }
        }


       
    }

    
}
