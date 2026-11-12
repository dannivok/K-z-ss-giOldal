

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

            ImagePost imagePost = new ImagePost("Rahul Rai Vendel", 3);
            ImagePost imagePost1 = new ImagePost("Rahul Rai Vendel", 15);

            imagePost.Like();
            imagePost.Like();
            imagePost.Like();


            Console.WriteLine(imagePost.GetDescription());
            Console.WriteLine(imagePost.Score());

            Console.WriteLine(imagePost1.GetDescription());
            Console.WriteLine(imagePost1.Score());

        }
    }
}