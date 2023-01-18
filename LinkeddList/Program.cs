namespace LinkeddList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkeddList list = new LinkeddList();
            list.Add(56);
            list.Insert_front(30);
            list.Insert_front(70);
            list.Display();
            
           
        }
    }
}