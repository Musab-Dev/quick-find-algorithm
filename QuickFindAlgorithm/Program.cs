using QuickFindAlgorithm;

Console.Write("Define the number of objects: ");
int number = Convert.ToInt32(Console.ReadLine());

QuickFind qf = new QuickFind(number);

int choice;
do
{
    Console.Write("choose the desired operation:\n" +
        "1- Connect 2 objects.\n" +
        "2- Check the connectivity between 2 objects.\n" +
        "3- Print the Objects Array.\n" +
        "4- Quit.\n" +
        "Enter the number: ");
    choice = Convert.ToInt32(Console.ReadLine());

    int p, q;
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the two numbers:");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
            qf.Union(p, q);
            break;
        case 2:
            Console.WriteLine("Enter the two numbers:");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
            if (qf.Connected(p, q))
            {
                Console.WriteLine($"Objects {p} and {q} are connected.");
            }
            else
            {
                Console.WriteLine($"Objects {p} and {q} are NOT connected.");
            }
            break;
        case 3:
            qf.Print();
            break;
        case 4:
            Console.WriteLine("==============================\n" +
                "Thank You...");
            break;
        default:
            Console.WriteLine("please select one of the previous choices.");
            break;
    }
} while (choice != 4);
