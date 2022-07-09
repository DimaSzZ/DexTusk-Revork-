using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_List__Dictionary
{
    internal class Client
    {
        string? fio;
        public string? Fio
        {
            get => fio;
            set
            {
                if (value == "1") { fio = "Саша"; }
                else if (value == "2") { fio = "Женя"; }
                else { fio = "Алекс"; }
            }
        }
        public string IdPassport { get; set; }
        public List<Currency_Account> Currency_List = new List<Currency_Account>();
        public Client(string FIO,double cash)
        {
            Fio = FIO;
            Currency_List.Add(new Dol(cash));
            IdPassport = Convert.ToString(GetHashCode());
        }
        
    }
}
