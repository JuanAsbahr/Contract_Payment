namespace Contract_Payment.Service
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInrest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInrest * months;
        }
        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
