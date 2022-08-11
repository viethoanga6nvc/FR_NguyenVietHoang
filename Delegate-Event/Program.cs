namespace Delegate_Event
{
    class Program
    {
        static void Main()
        {
            var child = new Child("Tom", "Contatta");

            List<Friend> friends = new()
            {
                new Friend("Hoang", "0123456879", true, child),
                new Friend("Quang", "0468413872", false, child),
                new Friend("Ti", "0974535798", true, child)
            };

            child.Send();

            Console.ReadKey();
        }
    }
}