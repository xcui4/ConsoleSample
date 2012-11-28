using System;

namespace TrainingForTrainer
{
    public class Employee
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

        public int Payment()
        {
            switch (type)
            {
                case Engineer:
                    return CalculateEngineerPayment();
                case Salesman:
                    return CalculateSalesmanPayment();
                case Manager:
                    return CalculateManagerPayment();
                default:
                    throw new ApplicationException("Incorrect Employee");
            }
        }

        private int CalculateManagerPayment()
        {
            return monthlySalary + bonus;
        }

        private int CalculateSalesmanPayment()
        {
            return monthlySalary + commission;
        }

        private int CalculateEngineerPayment()
        {
            return monthlySalary;
        }
    }

}
