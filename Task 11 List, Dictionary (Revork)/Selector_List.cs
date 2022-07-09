using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_List__Dictionary
{
    internal static class Selector_List
    {
        public static Client Selector_IdPassport(this List<Client> clients, string id)
        {
            return clients.First(x => x.IdPassport == id);
        }
        public static List<Client> Selector_This_Cash(this List<Client> clients, double Cash)
        {
            return (List<Client>)clients.Where(x => x.Currency_List[0].Currency < Cash);
        }
        public static Client? Selector_Min_Cash(this List<Client?> clients)
        {
            return clients.Min();
        }
        public static double Selector_All_Cash(this List<Client> clients)
        {
            return clients.Select(x => x.Currency_List[0].Currency).Sum();
        }
    }
}
