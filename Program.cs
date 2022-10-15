Pass P = new Pass();
P.add(); //ДОБАВЛЕНИЕ
P.print();//вывод на экран
P.del();//удоление по логину
P.print();
P.search();//поиск по логину
P.NewLogAndPass();//изменения и логина и пароля сразу
P.print();
class Pass
{
    public Dictionary<string,string> people = new Dictionary<string, string>();
    public string pass;
    public string pass2;
    public string log;
    string dellog;
    public void add()
    {
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Намбер = " + (i+1));
            Console.WriteLine("Введите логин");
            log = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            pass = Console.ReadLine();
            people.Add(log, pass);
            pass = "";
            log = "";
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
    public void print()
    {
        foreach (var person in people)
        {
            Console.WriteLine($"Login: {person.Key}  Pass: {person.Value}");
        }
    }
    public void del()
    {
        Console.WriteLine("Введите логин шоб удолить");
        dellog = Console.ReadLine();
        people.Remove(dellog);
    }
    public void search()
    {
        Console.WriteLine("Введите логин шоб лицезреть пороль");
        dellog = Console.ReadLine();
        people.TryGetValue(dellog, out string pass);
        Console.WriteLine(pass);
    }
    public void NewLogAndPass()
    {
        Console.WriteLine("Введите логин для поиска");
        dellog = Console.ReadLine();
        people.Remove(dellog);
        Console.WriteLine("Введите новый логин");
        dellog = Console.ReadLine();
        Console.WriteLine("Введите новый пароль");
        pass = Console.ReadLine();
        people.Add(dellog, pass);
    }
}