using StudentManager.Entities;
using StudentManager.Services;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet seBox = new Cabinet();
            Cabinet bizBox = new Cabinet();

            seBox.AddNewProfile("SE1", "An", "an@fpt.edu.vn", 2003, 8.6);
            seBox.AddNewProfile("SE2", "Binh", "binh@fpt.edu.vn", 2003, 4.6);

            bizBox.AddNewProfile("SE3", "Chi", "chi@fpt.edu.vn", 2002, 7.6);
            bizBox.AddNewProfile("SE4", "Dung", "dung@fpt.edu.vn", 2003, 9.6);

            Console.WriteLine("The Biz Students: ");
            bizBox.PrintStudentList();

            Console.WriteLine("The SE Students: ");
            seBox.PrintStudentList();

            //<Student> <Lecturer>
        }

        //challenge at home:
        //print out the student list by Name in ascending order
        //print out the student list by GPA in descending order
        //print out the student list by YOB in asscending order
        static void PlayWithObjectArray() 
        {
            //we will store multiple student profile
            //there are 2 ways to store multiple objects
            //1. Declare concrete variable/pointer - khai bao bien le 
            //Student s1, s2, s3, s4 
            //assign the value for each variables by using new Student
            //s1 = new Student(){Id = "SE1"}, Name = "Do The Hieu"....}
            //s2 = new Student(){.....................................}

            //Using array and collection (List, ArrayList, Set, HashMap,....)
            //int[] arr = new int[10];
            Student[] arr = new Student[10];

            //store the student value, new Student(){}
            arr[0] = new Student();
            arr[1] = new Student() {Id = "SE1", Name = "An Nguyen", Email = "an@fpt.edu.vn", Yob = 2003, Gpa = 8.6};//onject initializer
            arr[2] = new Student() { Id = "SE2", Name = "Binh Le", Email = "binh@fpt.edu.vn", Yob = 2003, Gpa = 8.2};
            arr[3] = new Student() { Id = "SE2", Name = "Chi Do", Email = "chi@fpt.edu.vn", Yob = 2002, Gpa = 8.9};
            arr[4] = new Student() { Id = "SE3", Name = "Dat Ngo", Email = "dat@fpt.edu.vn", Yob = 2003, Gpa = 6.0};

            Console.WriteLine("The student list printed by using traditional for: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);//call ToString() automatically in background
            }
        }

        static void PlayWithValueTypeArrayV2()
        {
            //we define array and init all of its values at the same time
            int[] arr = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50};
            //we have an array, we have declared 10 int variables
            //arr[0] to arr[9]
            //we init, we assign the value for each int variable within the array
            //khai bao bien, gan luon gia tri cho 10 bien trong mang
            //arr: general variable to manage all of its member
            //arr: bien ma mi. bien mama tong quan, quan li 10 dua duoi quyen 

            //using for each like in the Math subject to scan the whole of the array
            //whatever you declare the array, I dont care how you declare an array, I know that an array is a set of value, I use for each for the array in overall
            Console.WriteLine("The array has values of: ");
            foreach (var x in arr)
            {
                Console.Write($"{x} ");//take each value in array
            }
        }
        //work with multiple values, multiple object
        //how to manage many objects/values in an effectively way
        //ARRAY         |        COLLECTION
        //ez to use             ez to use (a little technic required)
        //some limitation       effectively
        //Java: there are 2 different datatypes - the way we store data
        //1. primitive data type: int long double char float boolean...\
        //      take only one ram/memory to store value
        //2. object data type/reference data type/"Pointer"
        //      take/consume 2 memory to store value
        //      one: variable/pointer
        //      one: object, the new segment to store actual value of an object
        //String,File, Math, Random, Exception, Statement, ArrayList,...

        //C# offer 2 ways to store value, two data type like java
        //1. value date type (~primitive): int, long, double, char, float, boolean,...
        //2. reference data type - same with java:  
        // string, String, File, Math, Random, Exception, Statement, ArrayList, Dog, Cat, Person, Student,...
        static void PlayWithValueTypeArray() 
        {
            //I want to store 10 nums, how???
            //I want to compute the sum of them???

            //1st answer: declare an abitrary/concrete variables, khai bao bien le, Retail
            int a1 = 5, a2 = 10, a3 = 15, a4 = 20, a5 = 25, a6 = 30, a7 = 35, a8 = 40, a9 = 45, a10 = 50;

            //how to store 1000 nums? you have to manually declare variables
            int sum = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10;

            //2nd answer: declare an array
            //a set of, a list of - 1 dãy - whole sales
            int[]    arr = new int[100];
            //Student s  = new Student();
            //        s.Id {get; set}

            //we have 10 variables
            //arr[0], arr[1], arr[2], arr[3], arr[4],..., arr[9]
            //  a1      a2      a3      a4      a5         a10
            //the name of a variab;e for now a little complex, with []
            //[Index, the order of eacj variable, we count the order of each var from 1 2 3]
            arr[0] = a1;
            arr[1] = a2;
            arr[2] = a3;
            arr[3] = a4;
            arr[4] = a5;
            //arr[5] = a6;
            //arr[6] = a7;
            //arr[7] = a8;
            //arr[8] = a9;
            //arr[9] = a10;

            Console.WriteLine("The array has values of: ");
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9]);
            Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]} {arr[3]} {arr[4]} {arr[5]} {arr[6]} {arr[7]} {arr[8]} {arr[9]}");

            Console.WriteLine("The array printed by using traditional for: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
                //Console.Write("{0} ", arr[i]);
                //Console.Write($"{arr[i]} ");

                //for each, delegate
                //generic ArrayList<Student>
            }
        }
    }   
}
