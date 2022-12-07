List<string> list = new List<string>();
list.Add("maria");
list.Add("alex");
list.Add("bob");
list.Add("anna");
list.Insert(2, "Marcos");



foreach(string obj in list)
{
    Console.WriteLine(obj);
}
Console.WriteLine("List count:" + list.Count);