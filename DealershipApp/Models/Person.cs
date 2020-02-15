using System;
using System.Collections.Generic;
using System.Text;

namespace DealershipApp.Models
{
    abstract class Person
    {
        private readonly DateTime birthDate;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string BirthDate { get { return birthDate.ToShortDateString(); } }
        public Enums.Gender Gender { get; set; }
        public int Age { get { return (DateTime.Now - birthDate).Days / 365; } } //Not exact age. There may be an deviation of a few days.

        public abstract string Talk();
        public abstract string Walk();

        public Person(string firstName, string lastName, DateTime birthDate, Enums.Gender gender)
        {
            LastName = lastName;
            FirstName = firstName;
            this.birthDate = birthDate;
            Gender = gender;
        }

    }
}
