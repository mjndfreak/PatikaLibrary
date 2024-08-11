

using PatikaLibrary;

Books book1 = new Books();
book1.Name = "Bir Kitap";
book1.Author = "Ahmet Yılmaz";
book1.Pages = 320;
book1.PublishingCompany = "Alfa Yayınları";

book1.Info();
Console.WriteLine("\n");

Books adiAylin = new Books("Adı Aylin","Ayşe Kulin",398,"Remzi Kitabevi");

adiAylin.Info();






