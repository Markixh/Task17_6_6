namespace Task17_6_6.Accounts
{
    public class RegularAccount : IAccount
    {
        // тип учетной записи
        public string Type { get; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public RegularAccount(double balance)
        {
            Type = "Обычный";
            Balance = balance;
        }

        /// <summary>
        /// Расчет процентной ставки обычного аккаунта по правилам банка
        /// </summary>
        /// <param name="account"></param>
        public void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }
}
