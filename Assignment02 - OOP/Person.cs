using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment02___OOP
{
    internal struct Person
    {



        #region Attribute

            
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string nmae;

        public string Name
        {
            get { return nmae; }
            set { nmae = value; }
        }

        #endregion

        #region Default Constructor

        public Person()
        {
            this.Age = 21;
            this.Name = "Sonbol";
        }
        #endregion

        #region  Parameterized Constructor
        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }


        #endregion

        #region indexer

        public string this[int index]
        {
            get
            {
                return $"Ditils of Person {index + 1} Name: {Name}, Age: {Age}";
            }

            set { }
        }
        #endregion

        #region Method

        public static string GetOldestPerson(Person[] people)
        {
            int maxAge = people[0].Age;
            string oldestName = people[0].Name;

            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].Age > maxAge)
                {
                    maxAge = people[i].Age;
                    oldestName = people[i].Name;
                }
            }

            return $"Oldest Person \nname:  {oldestName} Age: {maxAge}";
        }

        #endregion


    }
}
