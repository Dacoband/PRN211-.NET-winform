using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repositories.Entities;

namespace Repositories;


//đây là class đại diện cho cái database BookManagementDB ta đang móc tới 
//1 DB có nhiều table, DB giống như cái Cabinet, thùng chứa, container 
//Class này có chưa nhiều entities khác
//CÓ chứa 3 table Book | BookCategory | UserAccount 

// Scaffold sẽ sinh ra dàn code y chang cấu trúc DB 

//BookManagementDbContext (Cabinet)

//List<Book> arr
//List<BookCategory> arr
//List<UserAccount>  arr

// .Books ~SELECT~ FROM Book 
// .BookCategories ~SELECT~ FROM BookCategory 

//Chúng đều là List, đó là lúc áp dụng LinQ , Lambda Expression - Delegate để thao tác trên Table - Trong RAM 
//.WHERE(Biểu thức lambda đẻ làm gì đó với table trong ram )
//.SELECT(Biểu thức lambda)
//Còn rrast nhiều method khác để thao tác trên CSDL : UPDATE(), ADD(), ...


//Tuy nhiên - class này đc tạo tự động bởi con kì lân EF8 ta cài từ cmd và nó nhúng luôn câu kết nối CSDL từ trong class
//Hard-Coded | Connection String Nguy hiểm khi bị lộ thông tin Server trong file .DLL sẽ bị dịch ngược bởi Dotpeek ...
//Khiến app chỉ chơi đc với đúng 1 server, 1 cặp User/Pass cố định 
// => ta cần linh hoạt hơn, app chạy với mọi máy server 
// => Ta cần giấu info Server 
// => Tách , gỡ phần Connection String ra khỏi class này 
//=> class này sẽ đọc info cấu hình, chuỗi CS từ 1 tập tin này bên ngoài đặt ở thu mưuc nào đó | GUI App 
//Tập tin mà chứa Info kết nối CSDL - Gọi là Configuration File 
//Nó thường là FIle Text thuần nhưng có định dạng trong Contents để đọc thông tin 

//Nó thường có dạng         .INI     .XML      .JSON 

//Trong này ta sẽ Đọc file cấu hình JSON để lấy ra CS thay vào hàm Hard-Coded 
//Để đọc tập tin .JSON ta cần thêm 2 thư viện phụ trợ 
//Đề thi cho bạn content của tập tin .JSON , copy & paste
//để thi cho bạn thư viện đọc .JSON 
//Bạn chỉ cần sửa chỗ hard-coded thay = hàm đọc file JSON . 

public partial class BookManagementDbContext : DbContext
{

    public BookManagementDbContext()
    {

    }

    public BookManagementDbContext(DbContextOptions<BookManagementDbContext> options)
        : base(options)
    {
    }

    

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookCategory> BookCategories { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }


    //Hàm đọc file JSON để trả về Connetion Strings 
    //Cẩn thận cái tag , PROP của file JSON để mò ra chuỗi kết nối CSDL 
    //nhớ check chuỗi kết nối - Sửa User/Pass của mình 

    private string? GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DefaultConnectionStringDB"];
    }  // học phí 9tr nằm ở đây coi chừng có dấu cách giữa 2 Tag 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());
    // REMOVE Hard-Coded CS

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Book__3DE0C20788F59922");

            entity.ToTable("Book");

            entity.Property(e => e.BookId).ValueGeneratedNever();
            entity.Property(e => e.Author).HasMaxLength(50);
            entity.Property(e => e.BookName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");

            entity.HasOne(d => d.BookCategory).WithMany(p => p.Books)
                .HasForeignKey(d => d.BookCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Book_BookCategory");
        });

        modelBuilder.Entity<BookCategory>(entity =>
        {
            entity.HasKey(e => e.BookCategoryId).HasName("PK__BookCate__6347EC04CB6BCCF0");

            entity.ToTable("BookCategory");

            entity.Property(e => e.BookCategoryId).ValueGeneratedNever();
            entity.Property(e => e.BookGenreType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__UserAcco__0CF04B18BE863750");

            entity.ToTable("UserAccount");

            entity.Property(e => e.MemberId).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
