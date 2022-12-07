List<string> list = new List<string>();
list.Add("Maria");//Inserir elemento na lista: Add, Insert
list.Add("Alex");
list.Add("Bob");
list.Add("Anna");
list.Insert(2, "Marcos");



foreach(string obj in list)
{
    Console.WriteLine(obj);
}
Console.WriteLine("List count:" + list.Count);//Tamanho da lista: Count

string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine("Firs 'A': " + s1);
string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("Last 'A':"+s2);