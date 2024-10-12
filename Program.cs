/*
Yuqoridagi Book classiga qo’shimcha xususiyatlar qo’shing va ularni method lar yordamida bajaring.
Shartga muvofiq, oldingi proyektdan Copy Paste qilindi va davom etildi
*/


using System;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {   
            Book book = new Book();
            Console.WriteLine("Ma'lumotlar bazasiga kiritish uchun kitob haqida ma'lumotlarni to'ldiring: ");
            
            Console.Write("Kitob nomini kiriting: " + book.Title);
            book.Title = Console.ReadLine();
            
            Console.Write($"{book.Title} kim tomonidan yozilgan? ");
            book.Author = Console.ReadLine();

            Console.Write($"Kitob qaysi yilda nashr qilingan? ");
            book.Year = Convert.ToInt32(Console.ReadLine());
           
            Console.Write($"{book.Author}ning {book.Title}({book.Year}) kitobi narxini kiriting:(so'mda) ");
            book.Price = Convert.ToInt32(Console.ReadLine());
            
            book.SettingUp();
                System.Console.WriteLine("Qo'shimcha ma'lumotlar qo'shishni xohlaysizmi? ");
                System.Console.WriteLine("1) Ha\n2) Yo'q");
                int userInput = Convert.ToInt32(Console.ReadLine());
                switch(userInput)
            {
                case 1: 
                {
                    book.AdditionalInfo();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Dastur tugatildi.");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Xatolik!");
                    break;
                }
            }
        }
    }
}