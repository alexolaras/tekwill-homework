using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class PaymentManager
    {
        private ILogger logger;
        public PaymentManager(ILogger logger)
        {
            this.logger = logger;
        }
       
        public void ProcessPayment(double amount, string creditCardNumber)
        {
            if(creditCardNumber != null && creditCardNumber.Length == 16)
            {
                logger.LogInformation($"Processing payment of {amount} on this card: {creditCardNumber}");
                return;
            }
            logger.LogError($"Error when processing payment of {amount} on this card: {creditCardNumber}");
            
        }
        public void RefundPayment(double amount, string transactionId)
        {
            if (transactionId != null)
            {
                logger.LogInformation($"Refund of {amount} with transaction id: {transactionId}");
                return;
            }
            logger.LogError($"Error when refunding payment of {amount} with transaction id: {transactionId}");
        }
        public void ProcessRefund(double amount, string transactionId)
        {
            if (transactionId != "")
            {
                logger.LogInformation($"Processing refund of {amount} with transaction id: {transactionId}");
                return;
            }
            logger.LogError($"Error when processing payment refund of {amount} with transaction id: {transactionId}");

        }
    }
}
