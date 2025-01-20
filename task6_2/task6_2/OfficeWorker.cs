using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.task6_1
{
    public class OfficeWorker : Employee
    {
        public OfficeWorkerType WorkerType { get; set; }

        public override void Quit()
        {
        }
    }

    public enum OfficeWorkerType
    {
        FinancialAnalyst,
        LoanSpecialist,
        Accountant,
        CustomerServiceRepresentative
    }


}
