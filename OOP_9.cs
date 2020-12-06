using System;
using System.Collections.Generic;

namespace COOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Reading licence key");
            new KeyManager(Console.ReadLine() ?? string.Empty).Output();
        }
    }

    internal class KeyManager
    {
        private const string ProKey = "123PRO";
        private const string ExpKey = "456EXP";
        private readonly string _key;
        private readonly Dictionary<string, DocumentWorker> _dic = new Dictionary<string, DocumentWorker>();

        public KeyManager(string key)
        {
            _key = key;
            _dic.Add(ProKey, new ProDocumentWorker());
            _dic.Add(ExpKey, new ExpertDocumentWorker());
            _dic.Add("", new DocumentWorker());
        }

        public void Output()
        {
            DocumentWorker document = new DocumentWorker();
            if (!_dic.ContainsKey(_key))
            {
                Console.WriteLine("Бесплатная версия, неверный ключ");
            }
            else
            {
                document = _dic[_key];
            }
            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();
        }
    }

    internal class DocumentWorker
    {
        public void OpenDocument() { Console.WriteLine("Документ открыт"); }
        public virtual void EditDocument() { Console.WriteLine("Редактирование документа доступно в версии Про"); }
        public virtual void SaveDocument() { Console.WriteLine("Сохранение документа доступно в версии Про"); }
    }

    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument() { Console.WriteLine("Документ отредактирован"); }
        public override void SaveDocument() { Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт"); }
    }

    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument() { Console.WriteLine("Документ сохранен в новом формате"); }
    }
}

/*
 Создайте класс DocumentWorker.
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт",
"Редактирование документа доступно в версии Про", "Сохранение документа доступно в
версии Про".
Создайте производный класс ProDocumentWorker.
Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных
форматах доступно в версии Эксперт".
Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран
"Документ сохранен в новом формате".
В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается
экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен
создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.
 */
