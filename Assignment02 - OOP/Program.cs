using static Assignment02___OOP.Employee;
using static Assignment02___OOP.Person;

namespace Assignment02___OOP
{

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            //Person[] pepole = new Person[3];

            //pepole[0] = new Person(22, "Abdo");
            //pepole[1] = new Person(60, "Mahmoud");
            //pepole[2] = new Person(700, "Sonbol");


            //for (int i = 0; i < pepole.Length; i++)
            //{
            //    Console.WriteLine($"Details of Person {i + 1}: Name = {pepole[i].Name}\t Age =\t {pepole[i].Age}");
            //}

            #endregion

            #region Q2

            //Point p = new Point(30,23);

            //Console.WriteLine(p.GetDifference(p.X, p.Y));

            #endregion

            #region Q3
            Person[] persons = new Person[3];

            persons[0].Name = "Abdulrahman";
            persons[0].Age = 21;

            persons[1].Name = "Mahmoud";
            persons[1].Age = 60;

            persons[2].Name = "Ibrahim";
            persons[2].Age = 121;

            Console.WriteLine(Person.GetOldestPerson(persons));





            #endregion








        }
    }
}
