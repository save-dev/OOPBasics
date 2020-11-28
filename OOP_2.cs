using System;

namespace COOP
{
    class Book
    {
        // Параметрический конструктор класса
        public Book(string title, string author, string content)
        {
            new Title {BookTitle = title}.Show();
            new Author {AuthorName = author}.Show();
            new Content{BookContent = content}.Show();
        }
    }

    class Title
    {
        public string BookTitle;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Название книги: `{BookTitle}`");
            Console.ResetColor();
        }
    }

    class Author
    {
        public string AuthorName;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Автор: `{AuthorName}`");
            Console.ResetColor();
        }
    }

    class Content
    {
        public string BookContent;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Содержание книги: `{BookContent}`");
            Console.ResetColor();
        }
    }

    class Program
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
