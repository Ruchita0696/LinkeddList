namespace LinkeddList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkeddList list = new LinkeddList();
            list.Add(70);
            list.Insert_front(30);
            list.Insert_front(56);
            list.Display();
            
           
        }
    }
}