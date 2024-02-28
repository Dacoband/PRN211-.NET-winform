namespace MainUIV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithIntegerList();
        }

        //store/save and print the 10 first integers beginning with 1
        static void PlayWithIntegerList()
        {
            //int[] arr = new int[10]
            //arr[0] = 1;
            //arr[1] = 2; arr is a pointer, a variable to point to a big memory segment
            //            in big men segment will consist of 10 other integer number/ vars
            //            arr is a bag, a box, a container to store many variables/values

            //int[] arr = new int[] {1,2,3,4};
            int[] arr = { 1, 2, 3, 4 };

            //Java: List<Integer> arr = new ArrayList<Integer>();
            //Java: ArrayList<Integer> arr = new ArrayList<Integer>()
            //arr also is a pointer, point to a big mem segment
            //arr is a bag to hold many things are put in 
            //how to put??
            //arr.Add(???)
            //how to get one
            //arr.Get(pos)

            //C#: List ----- ArrayList in Java
            //C#: List can new, and replaces for ArrayList in Java
            //C# also offers ArrayList (focus in another time - it is not safe to use)
            List<int> list = new List<int>();
            //arr is also a pointer, points to a bag, a big mem segment, 100% the same with Java
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);


            //how to get one???
            //how to print all???
            Console.WriteLine($"There are {list.Count} item(s) in the list");

            Console.WriteLine("The List printed by using for i");
            for(int i = 0; i < list.Count; i++) {
                Console.WriteLine(list[i]);//use as an array[] to access each element
                                            // Indexer technic
            }
            Console.WriteLine("The list print ");
            foreach (var x in list) {
                Console.WriteLine(x);
            }
        }
    }
}
            