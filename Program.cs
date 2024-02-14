// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 10000;

bool isAuthenticated = false;  //camelCase

Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton -> Hoşgeldin!");

}
else
{
    Console.WriteLine("Buton -> Giriş Yapınız!");
}

//array

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };//dbden gelecek

//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}
//Console.WriteLine(loans.Length);

//aslında kendi veritipimizdir.

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8 VS..";
course1.Price = 10;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "JAVA";
course2.Description = "JAVA 7";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12";
course3.Price = 10;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

CourseManager courseManager = new CourseManager(new CourseDal()); //ctor çalışır
List<Course> courses2 =  courseManager.GetAll();


for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


Console.WriteLine("************");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56478965412";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

//değer tipli ve referans tipli değişkenler
int number1 = 10;//20
int number2 = 20;
number1 = number2; // number2 nin değeri number1 e atansın
number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1; // cities2 cities1 ile aynı adresi göstersin.
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

//value types -->int, bool,double...
//reference types --> array, class, interface...

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
//base sınıflar inherit edilen sınıfların referansını tutabilir. Yani:
//cutomer1 =101
//cutomer2 =102
//cutomer3 =103
//cutomer4 =104  şeklinde yer tutuyordur ancak hepsi bir basecutomer arrayinin elemanı olabilir.

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber); //şu anda tüm müşterilrin customernumberı okunur.

    //if( customer is IndividualCustomer)  özelleştirilebilirdi.
    //{
    //    Console.WriteLine(((IndividualCustomer)customer).FirstName);//cascade ettim
    //}
}