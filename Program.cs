List<string> list = new List<string>();
list.Add("maria");
list.Add("alex");
list.Add("boba");
list.Add("anna");
list.Insert(2, "Marcos");



foreach(string obj in list)
{
    Console.WriteLine(obj);
}