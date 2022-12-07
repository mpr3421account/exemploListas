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

//Encontrar primeiro ou último elementos da lista que satisfaça um predicado:list.Find, list.FindLast

string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine("Firs 'A': " + s1);
string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("Last 'A':"+s2);

int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("First position 'A':" + pos1);
int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Last position 'A':" + pos2);