using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public float Quantity { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public int BookCategoryId { get; set; }

        //Có 2 cách khi chơi với csdl
        //c1: Code First - tạo class chứa Info mà mai mốt sẽ map thành các cột của table tương ứng 
        //Sau đó dùng bộ thư viện tên là : EF CORE - ENTITY FRAMEWORK CORE (Java gọi là HIBERNATE) để tự động Create Database và Table
        //Code trước, tạo table tự động ăn theo class

        // C2: Có sẵn table và DB rồi, dùng EF CORE tự động suy ngược, GENERATE ra cái class này !!!
        //DB first , CÓ table trước rồi , tạo ra class ăn theo table 

        // Để thi PE xài cách 2 - DB first - ko cần gõ class 

    }
}
