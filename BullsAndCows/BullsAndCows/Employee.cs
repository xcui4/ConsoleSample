namespace TrainingForTrainer
{
    public abstract class Employee:IPayment
    {
        public readonly int monthlySalary;
        public readonly int commission;
        public readonly int bonus;

        public Employee(int monthlySalary, int commission, int bonus)
        {
            this.monthlySalary = monthlySalary;
            this.commission = commission;
            this.bonus = bonus;
        }

        abstract public int Payment();
    }

    public interface IPayment
    {
        int Payment();
    }

    public class Engineer:Employee
    {
        public Engineer(int monthlySalary)
            : base(monthlySalary, 0, 0)
        {
            
        }

        public override int Payment()
        {
            return this.monthlySalary;
        }
    }

    public class Salesman : Employee
    {
        public Salesman(int monthlySalary, int commission)
            : base(monthlySalary, commission, 0)
        {
        }

        public override int Payment()
        {
            return this.monthlySalary + this.commission;
        }
    }
    public class Manager : Employee
    {
        public Manager(int monthlySalary, int bonus)
            : base(monthlySalary, 0, bonus)
        {

        }

        public override int Payment()
        {
            return this.monthlySalary + this.bonus;
        }
    }
}
