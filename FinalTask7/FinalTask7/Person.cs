using System;
namespace FinalTask7
{
	abstract internal class Person
	{
        internal string firstName { get; set; }
        internal string lastName { get; set; }

        internal Person(string name, string surname)
        {
            firstName = name;
            lastName = surname;
        }
    }
}