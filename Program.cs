namespace StakeAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stake Problem");
            Console.WriteLine("1.Push the Element In a Stack\n2.Display top element\n");
            Console.WriteLine("Select Your Choice: ");
            Console.WriteLine("----------------------------------\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("----------------------------------\n");
                    LinkStake listStack = new LinkStake();
                    listStack.Push(56);
                    listStack.Push(30);
                    listStack.Push(70);
                    listStack.Display();
                    Console.WriteLine("----------------------------------\n");
                    break;
                case 2:
                    Console.WriteLine("----------------------------------\n");
                    LinkStake listStack1 = new LinkStake();
                    listStack1.Push(56);
                    listStack1.Push(30);
                    listStack1.Push(70);
                    listStack1.Display();
                    listStack1.Peek();
                    break;


                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
        }
    }
}