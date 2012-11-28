namespace TrainingForTrainer
{
    public class Employee
    {
        private readonly int type;
        public readonly int monthlySalary;
        public readonly int commission;
        public readonly int bonus;

        private const int Engineer = 0;
        private const int Salesman = 1;
        private const int Manager = 2;

        public Employee(int type, int monthlySalary, int commission, int bonus)
        {
            this.type = type;
            this.monthlySalary = monthlySalary;
            this.commission = commission;
            this.bonus = bonus;
        }
    }

    public class Engineer:Employee
    {
        public Engineer(int monthlySalary)
            : base(0, monthlySalary, 0, 0)
        {
            
        }

        public int Payment()
        {
            return this.monthlySalary;
        }
    }

    public class Salesman : Employee
    {
        public Salesman(int monthlySalary, int commission)
            : base(1, monthlySalary, commission, 0)
        {
        }

        public int Payment()
        {
            return this.monthlySalary + this.commission;
        }
    }
    public class Manager : Employee
    {
        public Manager(int monthlySalary, int bonus)
            : base(2, monthlySalary, 0, bonus)
        {

        }

        public int Payment()
        {
            return this.monthlySalary + this.bonus;
        }
    }
}
