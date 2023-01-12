using System;
using Balta.ContentContext;

namespace Balta
{

    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "balta.io/OOP"));
            articles.Add(new Article("Artigo sobre C#", "balta.io/c#"));
            articles.Add(new Article("Artigo sobre dotNet", "balta.io/dotNet"));

            //foreach (var article in articles)
            //{
            //    Console.WriteLine(article.Id);
            //    Console.WriteLine(article.Title);
            //    Console.WriteLine(article.Url);

            //}

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCS = new Course("Fundamentos C#", "fundamentos-c#");
            var courseSQL = new Course("Fundamentos SQL-Server", "fundamentos-sql");

            courses.Add(courseOOP);
            courses.Add(courseCS);
            courses.Add(courseSQL);

            var careers = new List<Career>();

            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda .NET", "Descricao", null);
            var careerItem1 = new CareerItem(1, "Comece por aqui", "Descricao", courseSQL);
            var careerItem3 = new CareerItem(3, "Aprenda OOP", "Descricao", courseOOP);

            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem1);
            careerDotNet.Items.Add(careerItem3);

            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
        }
    }
}