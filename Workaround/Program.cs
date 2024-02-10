using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Engin");
            SayHi("Tolga");
            SayHi("Ahmet");
            SayHi();

            Console.WriteLine("---------------------------------");

            int result = Collect(2, 4);
            int result2 = Collect(6, 58);

            Console.WriteLine("---------------------------------");

            //Array's
            string[] students = new string[] { "student1", "student2", "student3" };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            Console.WriteLine("---------------------------------");

            string[] cities = new[] {"Ankara", "İstanbul", "İzmir", "Eskişehir" };
            string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakır", "Düzce" };

            cities = cities2;
            cities[0] = "Adana";
            Console.WriteLine(cities2[0]);

            foreach (var city in cities)
            {   
                Console.WriteLine(city);   
            }

            Console.WriteLine("---------------------------------");

            List<string> newcities = new List<string> {"Ankara", "İzmir", "İstanbul" };
            newcities.Add("izmit");
            foreach (var city in newcities)
            {
                Console.WriteLine(city);
            }


            Person person1 = new Person();
            person1.FirstName = "AHMET";
            person1.LastName = "XYZT";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;

            //real checker.
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

        static void SayHi(string name= "for the anonymous")
        {
            Console.WriteLine("Hi " + name);
        }

        static int Collect(int value1=5, int value2=3) //default values 
        {
            int result = value1 + value2;
            Console.WriteLine("Collect: " + result.ToString());
            return result; 
        }    
    }
}