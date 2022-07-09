using System.Diagnostics;
using Task_8_List__Dictionary;

class Program
{
    static void Main()
    {
        Random random = new Random();
        var list = new List<Client>();
        Stopwatch sw = new Stopwatch();
        var Dictionary = new Dictionary<string, Client>();
        var b = new Client(Convert.ToString(random.Next(1, 4)), random.Next(1, 99999));
        list.Add(new Client(Convert.ToString(random.Next(1, 7)), random.Next(1, 99999)));
        Dictionary.Add(b.IdPassport, b);
        {
            list.Add(new Client(Convert.ToString(random.Next(1, 7)), random.Next(1, 99999)));
        }
        for (int i = 0; i < 1001; i++)
        {
            var a = new Client(Convert.ToString(random.Next(1, 4)), random.Next(1, 99999));
            Dictionary.Add(a.IdPassport, a);
            Console.WriteLine(a.IdPassport);
        }
        sw.Start();
        list.Selector_IdPassport($"{list[0].IdPassport}");
        foreach (var L in list)
        {
            Console.WriteLine($"Сумма на счету:{L.Currency_List[0].Currency} ID паспорта:{L.IdPassport} ФИО:{L.Fio}");
        }
        Console.WriteLine($"Время {sw.Elapsed.TotalMilliseconds}");
        sw.Stop();
        sw.Reset();
        sw.Start();
        var zxc = Dictionary[b.IdPassport];
        Console.WriteLine($"Сумма на счету:{zxc.Currency_List[0].Currency} ID паспорта:{zxc.IdPassport} ФИО:{zxc.Fio}");
        Console.WriteLine($"Время {sw.Elapsed.TotalMilliseconds}");
        sw.Stop();
    }
}
