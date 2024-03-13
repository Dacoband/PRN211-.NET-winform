using Services;

namespace Zodiac
{
    public partial class textBoxMonth : Form
    {
        public textBoxMonth()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SDK cung cấp 1 đối tượng/ class dùng để , hiển thị popup window
            // tương đương với hàm Arlet() been JS
            //Vậy hàm trả về giá trị tương ứng với nút nhất đã chọn. giá trị trả về của Popup là data thuộc datatype DialogResult - đoạn hội thoại có kq là gì ?
            DialogResult answer = MessageBox.Show("Do you really want to exist?", "Exist ?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();// hàm cung cấp bởi SDK tắt 1 cái app 
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Load ảnh vào ram sau đó đưa vào tag <img> picZ
            //Image img = Image.FromFile("đưa đường dẫn bước ảnh");

            Image img = Image.FromFile(@"signs\HotGirl.jpg");
            pic.Image = img;
        }

        private void btnCheckZodiac_Click(object sender, EventArgs e)
        {
            //Lấy ngày tháng đã nhập ở bên text box convert thành số 
            //Java : Integer.ParseInt(Chuỗi muốn đổi thành số)
            //C# : int.Parse(Chuỗi đổi thành số)

            int day = int.Parse(textBoxDay.Text);
            int month = int.Parse(textBox1.Text);

            //goi thu vien minh viet san been Services
            string zodiacEN = ZodiacCalculator.GetZodiacEnglish(month, day);
            string zodiacVI = ZodiacCalculator.GetZodiacVietnamese(zodiacEN);

            string imagePath = @"signs\" + zodiacEN + ".jpg";

            // show picture
            Image img = Image.FromFile(imagePath);
            pic.Image = img;

            //show text 
            lblZodiacSign.Text = "Your Zodiac sign is " + zodiacEN + " | " + zodiacVI;

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
