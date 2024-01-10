namespace Bmi // package bên java , thư mục / ngăn tủ chứa các class 
{                       // theo 1 tiêu chí phân loại 
    internal class Program // Internal là 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double bmi = GetBMI(62, 1.73);
            Console.WriteLine("Your BMI_1 is " + bmi);// in chuỗi/ ghép chuỗi truyền thống 
                                                      // Dùng toán tử + chuỗi - Concatenated

            Console.WriteLine("Your BMI_2 is {0}", bmi);// Kĩ thuật Place-holder
                                                        // Chừa chỗ sẵn trong chuỗi, fill value và tự điền biến vào sau
                                                        // Nếu có nhiều biến thì chừa chỗ đếm từ 0, 1, 2 

            Console.WriteLine("Your BMI_3 is {0} | {1}", bmi , 2024);// Nếu in nhiều biến 
            Console.WriteLine($"Your BMI_4 is {bmi} ");//KĨ THUẬT INTERPOLATION - Nội suy ( $_____ )
                                                     // Ráng suy nghĩ, tìm trong chuỗi
                                                     //Nếu thấy biến , tự điền Value vào 
            Console.WriteLine("Your BMI_5 is {0}" , BMICalculator.GetBMI(62, 1.92));

            Console.WriteLine($"Your BMI_6 is {BMICalculator.GetBMI(62, 1.92)} ");


            Console.WriteLine("Press and key to exit...");
            Console.ReadLine();
            
        }

        //Các hàm nằm trong class
        //Hàm đặc biệt là hàm chỉ có 1 câu lệnh (Viết tắt code, viết rút gọn không cần dùng mở ngoặc đóng ngoặc lấy đúng phần xử lí của hàm đặt sau tên hàm và dấu hàm kĩ thuật này gọi là BODY EXPRESSION,thân hàm là 1 biểu thức)
        // Không được nhầm lẫn với Lamda - Cũng xài chung dấu ( => )
        //Nhưng là kiến thức khác,cực hay, sẽ học sau !!!
        static double GetBMI(double weight, double height) => weight / (height * height);


        //static double GetBMI(double weight , double height)
        //{
        //    return weight / (height * height);
        //} //CMT CTRL K C dùng comment
        // CMT CTRL K U uncomment
        // Ctrl K D là format lại code cho đẹp 
    }
}
    // Các class không đc phần quyền khai báo ở đây
    //1 không gian tên - 1 căn phòng - 1 package 
    // Kĩ thuật tổ chức lưu trữ các class 
    // Chứa nhiều các class liên quang