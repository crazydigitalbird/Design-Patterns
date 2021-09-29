namespace RecursionComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rules = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Component root = new Composite("root");
            root.Build(rules);
            root.Operetion();

        }
    }
}
