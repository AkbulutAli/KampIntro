using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class ApplicationManager
    {
        //Method injection
        public void Application(ICreditManager creditManager, List <ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.log();
            }
            
        }

        public void GiveCreditPreliminaryInformation(List<ICreditManager> credits)
        {
            foreach (ICreditManager creditManager in credits)
            {
                creditManager.Calculate();
            }
        }
    }
}
