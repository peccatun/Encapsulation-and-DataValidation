using System;

namespace PersonsInfo
{
    public class Validator
    {
        public static void ValidateSalary(decimal salary)
        {
            if (salary < 460)
            {
                throw new ArgumentException("Salary must be more that 460 for the country");
            }
        }

        public static void VallidateName(string name)
        {
            if (name.Length < 3)
            {
                throw new ArgumentException("Invalid Name");
            }
        }
    }
}
