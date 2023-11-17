namespace QuickFindAlgorithm
{
    public class QuickFind
    {
        public int NumOfObjects { get; set; }
        public int[] Objects { get; set; }

        public QuickFind(int NumOfObjects)
        {
            this.NumOfObjects = NumOfObjects;
            Objects = new int[NumOfObjects];

            for (int i = 0; i < NumOfObjects; i++)
            {
                Objects[i] = i;
            }
        }

        public void Union(int p, int q)
        {
            if (Objects[p] == Objects[q])
            {
                Console.WriteLine($"Objects {p} and {q} are already connected.");
                return;
            }

            int qGroupId = Objects[q];

            for (int i = 0; i < NumOfObjects; i++)
            {
                if (Objects[i] == qGroupId)
                {
                    Objects[i] = Objects[p];
                }
            }

            Console.WriteLine($"Objects {p} and {q} are connected.");
        }

        public bool Connected(int p, int q)
        {
            return Objects[p] == Objects[q];
        }

        public void Print()
        {
            for (int i = 0; i < NumOfObjects; i++)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < NumOfObjects; i++)
            {
                Console.Write($"{Objects[i]}\t");
            }
            Console.WriteLine();
        }
    }
}