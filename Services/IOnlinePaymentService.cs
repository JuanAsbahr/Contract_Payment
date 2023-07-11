using System;

namespace Contract_Payment.Service
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);

    }
}
