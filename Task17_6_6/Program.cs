using Task17_6_6.Accounts;

namespace Task17_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создать обычный счет
            RegularAccount regularAccount = new RegularAccount(500.45);
            // Расчитать ставку
            Calculator.CalculateInterest(regularAccount);

            // Создать зарплатный счет
            SalaryAccount salaryAccount = new SalaryAccount(1000.00);
            // Расчитать ставку
            Calculator.CalculateInterest(salaryAccount);
        }
    }
}