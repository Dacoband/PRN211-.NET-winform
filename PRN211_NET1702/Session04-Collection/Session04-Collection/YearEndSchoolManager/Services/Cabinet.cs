using Repositories.Entities;

namespace Services
{
    public class Cabinet<T> //Type - date type as a parameter
        //parameter
        //Java: List<Student> list = new ArrayList<Student>();
        //Cabinet<Student> seBox = new Cabinet();
        //Cabinet<Lecturer> seox = new Cabinet();
    {
        //private Student[] _list1 = new Student[300];
        //private Lecturer[] _list2 = new Lecturer[300];
        //private int _count1 = 0;
        //private int _count2 = 0;

        private T[] _list = new T[300];
        private int _count = 0;//to count the current number of elements in the array

        //CRUD
        public void AddItem(T item)
        {
            //TODO: check the limit of the array or you wil receive the out of boundary exception
            //if statement to notify if the array is full
            _list[_count] = item; //_list[299] its okay, _list[300] exception 
            _count++;

        }
       
        
        public void PrintAll()
        {
            Console.WriteLine($"There is/are {_count} item(s) in the list");
            for (int i = 0; i < _count ; i++)
            {
                Console.WriteLine(_list[i]); //goi tham ten em - call ToString() imlpicity
            }
        }
    }
}
