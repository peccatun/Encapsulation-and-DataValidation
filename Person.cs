
using System;

namespace PersonsInfo
{
    public class Person
    {
        private int age;
        private string firstName;
        private string lastName;
        private decimal salary;

        public Person(string fname, string lname, int age, decimal salary)
        {
            FirstName = fname;
            LastName = lname;
            this.Age = age;
            Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.ValidateName(value);
                this.firstName = value;

            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                Validator.VallidateName(value);
                this.lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(" Age cannot be zero");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                Validator.ValidateSalary(value);
                this.salary = value;
            }
        }

        public void IncreaseAmount(decimal percent)
        {
            percent = this.Age < 30 ? percent / 2 : percent;

            this.Salary *= this.Salary + this.Salary * percent / 100;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }

        private void ValidateName(string name)
        {
            if (name.Length < 3)
            {
                throw new ArgumentException("Name length is least that 3 symbols");
            }
        }
    }
}
