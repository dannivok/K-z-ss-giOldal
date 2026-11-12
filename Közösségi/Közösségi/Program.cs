

namespace feladat
{
    class Program
    {
        static void Main(string[] args)
        {

            TextPost post2 = new TextPost("Jane Smith", "Short post.");
            TextPost post = new TextPost("John Doe", "This is a sample text post that exceeds twenty characters.");

            post2.Like();
            post2.Like();
            post2.Like();

            Console.WriteLine(post.GetDescription());
            Console.WriteLine(post.Score());

            Console.WriteLine(post2.GetDescription());
            Console.WriteLine(post2.Score());



        }
    }
}