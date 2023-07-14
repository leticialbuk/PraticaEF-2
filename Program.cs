using PraticaEF_2.Data;
using PraticaEF_2.Models;
using System.Net.NetworkInformation;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new DataContext();

            //context.Users.Add(new User
            //{
            //    Bio = "devLeticia",
            //    Email = "leticialbuk@gmail",
            //    Image = "https://leticialbuk",
            //    Name = "Leticia",
            //    PasswordHash = "123",
            //    Slug = "albuk"
            //});
            //context.SaveChanges();

            var user = context.Users.FirstOrDefault();
            var post = new Post 
            {
                Author = user,
                Body = "Meu artigo",
                Category = new Category 
                {
                    Name = "Backend",
                    Slug = "backend"
                },
                CreateDate = DateTime.Now,
                Slug = "meu-artigo",
                Summary = "Neste artigo vamos conferir...",
                Title = "Meu artigo",
            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}