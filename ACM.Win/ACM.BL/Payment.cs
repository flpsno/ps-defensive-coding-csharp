using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{

    public enum PaymentType
    {
        CreditCard = 1,
        PayPal = 2
    }

    public class Payment
    {
        public int PaymentType { get; set; }


        public void ProcessPayment()
        {
            //if (!Enum.IsDefined(typeof(PaymentType), this.PaymentType))
            PaymentType paymenteTypeOption;
            if (!Enum.TryParse(this.PaymentType.ToString(), out paymenteTypeOption))
            {
                throw new InvalidEnumArgumentException("Payment Type", (int)this.PaymentType, typeof(PaymentType));
            }

            /*if (!Enum.TryParse("creditcard", true, out paymenteTypeOption))
            {
                throw new InvalidEnumArgumentException("Payment Type", (int)this.PaymentType, typeof(PaymentType));
            }*/

            switch (paymenteTypeOption)
            {
                case ACM.BL.PaymentType.CreditCard:
                    // Process credit card
                    break;

                case ACM.BL.PaymentType.PayPal:
                    // Process PayPal
                    break;

                default:
                    throw new ArgumentException();
            }
        }
    }
}
