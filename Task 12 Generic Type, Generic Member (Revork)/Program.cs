using Task_9_Generic_Type__Generic_Member;

class Program
{
    private List<Client> clients = new List<Client>();
    private List<Employee> employes = new List<Employee>();
    static void Main()
    {
        var b = new Program();
        b.Registarion_Logic(new Client(32, "sdasa", 24));
        b.Registarion_Logic(new Employee(228, "sddasdasdasdasa", 9999999));
        foreach (var zxc in b.clients)
        {
            Console.WriteLine($"{zxc.Id} {zxc.Name} {zxc.Age}");
        }
        foreach (var zxc in b.employes)
        {
            Console.WriteLine($"{zxc.Id} {zxc.Name} {zxc.Age}");
        }
        b.Search_Logic(new Employee(228, "sddasdasdasdasa", 9999999));
    }

    void Registarion_Logic<T>(T x)
    {
        if (x is Client)
        {
            clients.Add(x as Client);
        }
        else if (x is Employee)
        {
            employes.Add(x as Employee);
        }
    }
    void Search_Logic<T>(T x)
    {
        if (x is Client)
        {
            var client = clients.Where(z => z.Id == (x as Client).Id).First();
            Console.WriteLine($"Работа велась с клиентом {client.Id} {client.Name} {client.Age}");
        }
        else if (x is Employee)
        {
            var employee = employes.Where(z => z.Id == (x as Employee).Id).First();
            Console.WriteLine($"Работа велась с работником {employee.Id} {employee.Name} {employee.Age}");
        }
    }
}

