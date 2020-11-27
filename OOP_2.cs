using System;

namespace COOP
{
    internal class Book
    {
        // Параметрический конструктор класса
        public Book(string title, string author, string content)
        {
            Title newTitle = new Title {BookTitle = title};
            newTitle.Show(title);
            Author newAuthor = new Author {AuthorName = author};
            newAuthor.Show(author);
            Content newContent = new Content{BookContent = content};
            newContent.Show(content);
        }
    }

    public class Title
    {
        public string BookTitle;

        public void Show(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Название книги: `{str}`");
            Console.ResetColor();
        }
    }

    public class Author
    {
        public string AuthorName;

        public void Show(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Автор: `{str}`");
            Console.ResetColor();
        }
    }

    public class Content
    {
        public string BookContent;

        public void Show(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Содержание книги: `{str}`");
            Console.ResetColor();
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            new Book("Война и мир", "Лев Толстой", "Здесь будет содержание книги");
        }
    }
}

/*
Создать класс Book. Создать классы Title, Author и Content,
каждый из которых должен содержать одно строковое поле и метод void Show().
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
содержание.
*/
