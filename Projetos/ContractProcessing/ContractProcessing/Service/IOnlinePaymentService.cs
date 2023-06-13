﻿namespace ContractProcessing.Service
{
     interface IOnlinePaymentService
    {
        double PaymentFee(double amount);

        double Interest(double amount, int months);
    }
}
