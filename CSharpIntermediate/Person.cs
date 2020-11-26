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

        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return this._birthdate;
        }
        

    }
}