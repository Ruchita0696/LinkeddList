namespace LinkeddList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkeddList list = new LinkeddList();
            list.Add(56);
            list.Add(70);
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            list.Display();
            
           
        }
    }
}