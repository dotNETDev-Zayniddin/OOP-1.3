namespace OOP
{
    class Book
    {
        private string title;
        private string author;                  // Fields
        private int year;
        private int price;
        //yangi xususiyat uchun o'zgaruvchilar
        private string genre;
        private string publisher;

       
        public string Title {get;set;}
        public string Author {get;set;}     //Properties
        public int Year {get;set;}
        public int Price {get;set;}
    
        public void SettingUp()
            {
                title = Title;
                author = Author;  
                year = Year;                   //Fieldlarga proplar orqali qiymatni berish
                price = Price; 

                System.Console.WriteLine("Natija: ");
                Console.Write($"{author}ning {title}({year}) kitobi {price} so'mda kutubxonada ro'yxatdan o'tdi "); 
            }
         public void AdditionalInfo()
            {
                System.Console.Write($"{title} kitobi janrini kiriting: ");
                genre = Console.ReadLine();
                System.Console.Write("Qaysi nashriyotda chop etilgan? ");   // <= Yangi xususiyat uchun method
                publisher = Console.ReadLine();
                System.Console.WriteLine("Saqlandi.");
                
            }
            
     }
}
