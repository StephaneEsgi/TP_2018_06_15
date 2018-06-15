using System;
using static System.Console;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ajout du noeud de la direction (base)
            Service root = new Service("Direction");
            root.Add(new Person("M. Le Président"));
        
            // ajout du premier service sous la direction de... la direction
            Service ceo = new Service("CEO");
            ceo.Add(new Person("Mme la CEO"));
            root.Add(ceo);

            // idem avec un second service
            Service cto = new Service("CTO");
            cto.Add(new Person("M. le CTO"));
            root.Add(cto);

            // en ainsi de suite !
            Service financeManager = new Service("Service financier");
            financeManager.Add(new Person("M. Pognon"));
            ceo.Add(financeManager);

            Service marketing = new Service("Service marketing");
            marketing.Add(new Person("M. Markeiteux"));
            ceo.Add(marketing);

            Service hr = new Service("Ressources humaines");
            hr.Add(new Person("Mme Perspicace"));
            ceo.Add(hr);

            Service customerService = new Service("Support");
            for (int i = 1; i <= 5; i++)
                customerService.Add(new Person($"Technicien support {i}"));
            cto.Add(customerService);

            Service leadDevelopers = new Service("Leaders");
            for (int i = 1; i <= 4; i++){
                leadDevelopers.Add(new Person($"Leader {i}"));
                Service technicians = new Service("Equipe de développeurs");
                for (int j = 1; j <= 10; j++)
                    technicians.Add(new Person($"Développeur  {i}{j}"));
                leadDevelopers.Add(technicians);
            }
            cto.Add(leadDevelopers);

            root.Display(1);
        
            ReadKey();
        }
    }
}
