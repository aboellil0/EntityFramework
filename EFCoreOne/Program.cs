using EFCoreOne;
using EFCoreOne.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var _context = new ApplicationDBContext();
        
        var MohamedBlog = new Blog
        {
            Name = "mm",
            Discription = "moahmed",
            kkkk = 12
        };
        var MohamedAuthor = new Author
        {
            FName = "Mohamed",
            LName = "Aboellil",
        };
        _context.Blogs.Add(MohamedBlog);
        _context.Authors.Add(MohamedAuthor);
        _context.SaveChanges();
        Console.WriteLine("Good morning");
    }
}