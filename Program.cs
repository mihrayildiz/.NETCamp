// See https://aka.ms/new-console-template for more information
using Intro.Business;
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

CourseManager courseManager = new CourseManager(); //ctor çalışır
Course[] courses2 =  courseManager.GetAll();


for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}