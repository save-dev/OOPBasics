using System;
using System.Collections.Generic;

namespace COOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine() ?? string.Empty;
            new DocumentTypeManager(type).Output();
        }
    }

    internal class DocumentTypeManager
    {
        private readonly string _type;

        private const string TypeOfXml = "XML";
        private const string TypeOfTxt = "TXT";
        private const string TypeOfDoc = "DOC";

        public DocumentTypeManager(string type) { _type = type; }

        public void Output()
        {
            Dictionary<string, AbstractHandler> typeData = new Dictionary<string, AbstractHandler>
            {
                {TypeOfXml, new XMLHandler()},
                {TypeOfTxt, new TXTHandler()},
                {TypeOfDoc, new DOCHandler()}
            };

            if (typeData.ContainsKey(_type))
            {
                typeData[_type].Open();
                typeData[_type].Create();
                typeData[_type].Change();
                typeData[_type].Save();
            }
            else
            {
                throw new Exception("No such type");
            }
        }
    }

    internal abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    internal class XMLHandler : AbstractHandler
    {
        public override void Open() { Console.WriteLine("Opening the XML"); }
        public override void Create() { Console.WriteLine("Creating the XML"); }
        public override void Change() { Console.WriteLine("Changing the XML"); }
        public override void Save() { Console.WriteLine("Saving the XML"); }
    }

    internal class TXTHandler : AbstractHandler
    {
        public override void Open() { Console.WriteLine("Opening the TXT"); }
        public override void Create() { Console.WriteLine("Creating the TXT"); }
        public override void Change() { Console.WriteLine("Changing the TXT"); }
        public override void Save() { Console.WriteLine("Saving the TXT"); }
    }

    internal class DOCHandler : AbstractHandler
    {
        public override void Open() { Console.WriteLine("Opening the DOC"); }
        public override void Create() { Console.WriteLine("Creating the DOC"); }
        public override void Change() { Console.WriteLine("Changing the DOC"); }
        public override void Save() { Console.WriteLine("Saving the DOC"); }
    }
}

/*
Создайте класс AbstractHandler.
В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса
AbstractHandler.
Написать программу, которая будет выполнять определение документа и для каждого формата
должны быть методы открытия, создания, редактирования, сохранения определенного
формата документа.
 */
