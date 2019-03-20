using System;
using TomTom;

namespace testes
{
    class Program
    {
        static void Main(string[] args)
        {
            TomTomAPIMain t = new TomTomAPIMain();
            dynamic res = t.ReturnJsonObject("coimbra");
            Console.WriteLine(res.results);
            foreach (dynamic x in res.results)
                try
                {
                    Console.WriteLine(x.address.freeformAddress + " " + x.address.extendedPostalCode);
                    
                }
                catch (Exception e)
                {
                    continue;
                }
            Console.Read();
        }
    }
}
