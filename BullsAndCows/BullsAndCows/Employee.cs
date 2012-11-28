using System;

namespace TrainingForTrainer
{
    class Employee
    {
        private readonly int type;
        private readonly int monthlySalary;
        private readonly int commission;
        private readonly int bonus;

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

        int Payment()
        {
            switch (type)
            {
                case Engineer:
                    return monthlySalary;
                case Salesman:
                    return monthlySalary + commission;
                case Manager:
                    return monthlySalary + bonus;
                default:
                    throw new ApplicationException("Incorrect Employee");
            }
        }
    }

}
