using System;

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

        public int Payment()
        {
            switch (type)
            {
                case Engineer:
                    return TrainingForTrainer.Engineer.CalculateEngineerPayment(new Engineer(type, monthlySalary, commission, bonus));
                case Salesman:
                    return TrainingForTrainer.Salesman.CalculateSalesmanPayment(new Salesman(type, monthlySalary, commission, bonus));
                case Manager:
                    return  TrainingForTrainer.Manager.CalculateManagerPayment(new Manager(type, monthlySalary, commission, bonus));
                default:
                    throw new ApplicationException("Incorrect Employee");
            }
        }
    }

    public class Engineer:Employee
    {
        public Engineer(int type, int monthlySalary, int commission, int bonus) : base(type, monthlySalary, commission, bonus)
        {
        }

        public static int CalculateEngineerPayment(Employee employee)
        {
            return employee.monthlySalary;
        }
    }

    public class Salesman : Employee
    {
        public Salesman(int type, int monthlySalary, int commission, int bonus)
            : base(type, monthlySalary, commission, bonus)
        {
        }

        public static int CalculateSalesmanPayment(Employee employee)
        {
            return employee.monthlySalary + employee.commission;
        }
    }
    public class Manager : Employee
    {
        public Manager(int type, int monthlySalary, int commission, int bonus)
            : base(type, monthlySalary, commission, bonus)
        {
        }

        public static int CalculateManagerPayment(Employee employee)
        {
            return employee.monthlySalary + employee.bonus;
        }
    }
}
