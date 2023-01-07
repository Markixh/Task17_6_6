namespace Task17_6_6.Accounts
{
    public class SalaryAccount : IAccount
    {
        // тип учетной записи
        public string Type { get; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public SalaryAccount(double balance)
        {
            Type = "Зарплатный";
            Balance = balance;
        }

        /// <summary>
        /// Расчет процентной ставки зарплатного аккаунта по правилам банка
        /// </summary>
        /// <param name="account"></param>
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
