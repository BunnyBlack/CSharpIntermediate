using System;

namespace CSharpIntermediate
{
    public class Person
    {
        #region OldOne

        // public string Name;
        //
        // public void Introduce(string to)
        // {
        //     Console.WriteLine("Hi {0}, I am {1}", to, Name);
        // }
        //
        // public static Person Parse(string str)
        // {
        //     var person = new Person {Name = str};
        //     return person;
        // }
        //

        #endregion

        private DateTime Birthdate { get; }
        private string Name { get; set; }
        
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var year = timeSpan.Days / 365;
                return year;
            }
        }


        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        /*
        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return this._birthdate;
        }
        */
    }
}