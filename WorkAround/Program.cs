using Business.Concrete;
using Entities.Concrete;

namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Person person1 = new Person();
            person1.FirsName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1234;
            person1.NationalityIdentity = 1234;

            PttManager pttManager=new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }
    }
}
