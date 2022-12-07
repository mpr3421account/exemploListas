internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("Maria");//Inserir elemento na lista: Add, Insert
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Anna");
        list.Insert(2, "Marcos");

        Console.WriteLine();

        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine("List count:" + list.Count);//Tamanho da lista: Count
        Console.WriteLine();

        //Encontrar primeiro ou último elementos da lista que satisfaça um predicado:list.Find, list.FindLast

        string s1 = list.Find(x => x[0] == 'A');
        Console.WriteLine("Firs 'A': " + s1);
        Console.WriteLine();
        string s2 = list.FindLast(x => x[0] == 'A');
        Console.WriteLine("Last 'A':" + s2);
        Console.WriteLine();

        //Encontrar primeira ou última posição de elemento da lista que satisfaça um predicado: list.FindIndex, list.FindLastIndex

        int pos1 = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine("First position 'A':" + pos1);
        Console.WriteLine();
        int pos2 = list.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine("Last position 'A':" + pos2);
        Console.WriteLine();

        //Filtrar a lista com base em um predicado: list.FindAll

        List<string> list2 = list.FindAll(x => x.Length == 5);
        foreach (string obj in list2)
        {
            Console.WriteLine("Objeto da lista com 5 caracteres:" + obj);
            Console.WriteLine();
        }

        //Remover elementos da lista: RemoveRange Remove, RemoveAll, RemoveAt,
        list.Remove("Alex");
        Console.WriteLine("Removido Alex:");
        Console.WriteLine();
        foreach (string obj2 in list)
        {

            Console.WriteLine(obj2);
        }
        list.RemoveAll(x => x[0] == 'M');
        Console.WriteLine("Removido nomes que iniciem com a letra M: ");
        Console.WriteLine();
        foreach (string obj3 in list)
        {

            Console.WriteLine(obj3);
        }

        Console.WriteLine();

        list.RemoveAt(0);
        foreach(string obj4 in list)
        {
            Console.WriteLine(obj4);
        }
    }
}