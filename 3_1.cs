using System;

    interface IPrintable
    {
        void DisplayEmployeeDetails();
    }
    class Employee : IPrintable
    {
           private string firstName;
           private string lastName;
           protected float netSalary;
           protected float grossSalary;

    protected Employee()
        {
            this.firstName = "";
            this.lastName = "";   
            this.netSalary = 0.0F;
            this.grossSalary = 0.0F;
        }

        protected Employee(string fName, string lName,  float salary)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.netSalary = salary;
        }

        public virtual void CalculateSalary()
        {
            
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("EMPLOYEE DETAILS:\n");
            Console.WriteLine("Name: {0} {1}", this.firstName, this.lastName);
           
            Console.WriteLine("Net Salary: {0}", this.netSalary);
            Console.WriteLine("Gross Salary: {0}\n", this.grossSalary);
        }
    }

    class Manager : Employee
    {
        private float petrolAllowance;
        private float foodAllowance;
        private float otherAllowance;



        public Manager(string fName, string lName, string designation, float salary) : base(fName, lName,  salary)
        {
            this.petrolAllowance = 0.08F;
            this.foodAllowance = 0.13F;
            this.otherAllowance = 0.03F;
        }

        public override void CalculateSalary()
        {
            grossSalary = (1 + petrolAllowance + foodAllowance + otherAllowance) * netSalary;

        }
    }

    class MarketingExecutive : Employee
    {
        private float kilometerTravel, tourAllowance;
        private int telephoneAllowance;

        public MarketingExecutive(string fName, string lName,  float salary, float kilometers) : base(fName, lName,  salary)
        {
            this.kilometerTravel = kilometers;
            tourAllowance = 5 * this.kilometerTravel;
            telephoneAllowance = 1000;
        }

        public override void CalculateSalary()
        {
            grossSalary = netSalary + kilometerTravel + tourAllowance + telephoneAllowance;
        }
    }

    class EmployeeManagement
    {
        static void Main()
        {
            Employee obj;
            obj = new Manager("anshika", "jain","manager", 53421);
            obj.CalculateSalary();
            obj.DisplayEmployeeDetails();

            obj = new MarketingExecutive("Adit", "Singh",  35425, 15);
            obj.CalculateSalary();
            obj.DisplayEmployeeDetails();
        }
    }

