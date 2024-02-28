namespace DelegateReview.LambdaExpression
{
    //viết hàm tính tổng từ 1 ... 100 in ra kết quả : 5050
    delegate void NoInputNoOutput();
    internal class Program
    {
        static void Main(string[] args) {
            NoInputNoOutput f = delegate () {
                int sum = 0;
                for(int i = 0; i <= 100; i++) {
                    sum += i;//cộng dồn, nhồi con em đất 
                }
                Console.WriteLine($"The sum of number of firm 1 ... 100 : {sum}");
            };
            f.Invoke();

            f = delegate () {
                int sum = 0;
                for(int i = 0; i <= 100; i++) {
                    if(i % 2 == 0)
                        sum += i;//cộng dồn, nhồi con em đất 
                }
                Console.WriteLine($"The sum of number of firm 1 ... 100 : {sum}");
            };
            f();

            f = () => {
                int sum = 0;
                for(int i = 0; i <= 100; i++) {
                    if(i % 2 == 0)
                        sum += i;//cộng dồn, nhồi con em đất 
                }
                Console.WriteLine($"The sum of number of firm 1 ... 100 : {sum}");
            };//biểu thức lambda : sự rút gọn của hàm ẩn danh, bỏ đi từ khóa delegate, thêm ký hiệu, biểu thức lambda là hàm ẩn danh đặc biệt 
            //nhưng hàm ẩn danh thì không chắc là biểu thức lambda nếu vẫn còn chữ delegate 
            f();
        }

        static void Sum() {
            int sum = 0;
            for(int i = 0; i <= 100; i++) {
                sum += i;//cộng dồn, nhồi con em đất 
            }
            Console.WriteLine($"The sum of number of firm 1 ... 100 : {sum}");
        }
    }
}
