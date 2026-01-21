namespace W26Week3IntroToPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //Add(2, 3, ref x);

            //Add(2, 3);


            BaseClass objBase;
            objBase = new BaseClass();
            objBase.Show();

            objBase = new DerivedClass();
            objBase.Show();
            
            DerivedClass objDerived = new DerivedClass();
            objDerived.Show();
        }

        static void PrintArray(int[] array)
        {

        }

        //static void PrintArray(params int[] array)
        //{

        //}

        static void Add(int n1, int n2)
        {

        }

        //static int Add(int n1, int n2)
        //{

        //}

        static void Add(string n1, string n2)
        {

        }

        static void Add(int n1, int n2, int n3)
        {

        }

        static void Add(int n1, int n2, ref int n3)
        {

        }
    }
}
