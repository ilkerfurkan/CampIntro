using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class AppealManager
    {
        // Dependency Injection - Method Injection: Bu methodun kullanacağı kredinin hangi tür olacağını ve hangi loglayıcı olacağını enjekte ediyoruz.
        public void MakeAnAppeal(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendirme
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void MakeALoanPreInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
