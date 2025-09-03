using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderInvoiceSystem.Models
{
    public enum TemplateType
    {
        OrderCompletion = 1,
        OrderCancelled = 2,
        OrderPending = 3,
        PaymentSucess = 4,
        PaymentFailed = 5,
        PaymentPending = 6,
        CustomerRegistration = 7
    }
}