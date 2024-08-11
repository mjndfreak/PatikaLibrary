using System.Text;

namespace PatikaLibrary;

public class Books
{
    public Books()
    {
        Name = "unknown";
        Author = "unknown";
        Pages = 0 ;
        PublishingCompany = "unknown";
        RegistrationTime = DateTime.Now;
    }

    public Books(string name, string author, int pages, string publishingCompany)
    {
        Name = name;
        Author = author;
        Pages = pages;
        PublishingCompany = publishingCompany;
        RegistrationTime = DateTime.Now;
    }

    public string Name {get; set;}
    public string Author {get; set;}
    public int Pages {get; set;}
    public string PublishingCompany {get; set;}
    public DateTime RegistrationTime {get; set;}

    public void Info()
    {
        Console.WriteLine("Book Name: " + Name + "\nBook Author: " + Author + "\nPages: " + Pages + "\nPublishing Company: " + PublishingCompany + "\nRegistration Date: " + RegistrationTime);
    }
    
}