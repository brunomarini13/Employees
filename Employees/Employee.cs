using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract class Employee
    {
        // Field data.
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }

            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
        protected BenefitPackage empBenefits = new BenefitPackage();

        // Properties
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name lenght exceeds 15 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        public int ID
        {
            get { return empID; }
            set
            {
                if (value > 0)
                    empID = value;
            }
        }

        public float Pay
        {
            get { return currPay; }
            set
            {
                if (value > 1000f)
                    currPay = value;
                else
                    currPay = 1000f;
            }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SSN
        {
            get { return empSSN; }
        }

        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

        // Constructors.
        public Employee() { }

        public Employee(string name, int age, int id, float pay)
        {
            empName = name;
            empAge = age;
            empID = id;
            currPay = pay;
        }

        public Employee(string name, int age, int id, float pay, string ssn) : this(name, age, id, pay)
        {
            empSSN = ssn;
        }

        // Methods.
        public virtual void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public double GetBenefitCost()
        { 
            return empBenefits.ComputePayDeduction(); 
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("Social security number: {0}", SSN);
        }
    }
}
