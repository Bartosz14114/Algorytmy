public static bool SprawdźNawiasy(string napis)
{
    Stack<char> stos = new Stack<char>();
    var pary = new Dictionary<char, char>
    {
        { '”', '„' },
        { '«', '»' },
        { ')', '(' }
    };

    foreach (char c in napis)
    {
        if (c == '„' || c == '»' || c == '(')
        {
            stos.Push(c);
        }
        else if (pary.ContainsKey(c))
        {
            if (stos.Count == 0 || stos.Pop() != pary[c])
            {
                Console.WriteLine("Błąd: Niepoprawne domknięcie bloku.");
                return false;
            }
        }
    }

    if (stos.Count > 0)
    {
        Console.WriteLine("Błąd: Pozostały niedomknięte bloki:");
        foreach (char s in stos)
        {
            Console.WriteLine(s);
        }
        return false;
    }

    return true;
}