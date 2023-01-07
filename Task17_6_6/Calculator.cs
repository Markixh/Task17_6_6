using Task17_6_6.Accounts;

namespace Task17_6_6
{
    public static class Calculator
    {
        /// <summary>
        /// Метод для расчета процентной ставки
        /// </summary>
        /// <param name="account"></param>
        public static void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}
