using System;

namespace COOP
{
    public class Program
    {
        // usage
        public static void Main(string[] args)
        {
            new ClassRoom(new Pupil(), new BadPupil(), new GoodPupil(), new ExcellentPupil());
        }
    }

    internal class ClassRoom
    {
        public ClassRoom(params Pupil[] pupils)
        {
            foreach (var pupil in pupils)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
            }
        }
    }

    internal class Pupil
    {
        public virtual void Study() { Console.WriteLine("I am studying"); }
        public virtual void Read() { Console.WriteLine("I am reading"); }
        public virtual void Write() { Console.WriteLine("I am writing"); }
        public virtual void Relax() { Console.WriteLine("I am relaxing"); }
    }

    internal class ExcellentPupil : Pupil
    {
        public override void Study() { Console.WriteLine("I am studying always"); }
        public override void Read() { Console.WriteLine("I read a lot"); }
        public override void Write() { Console.WriteLine("I write like a pro"); }
        public override void Relax() { Console.WriteLine("I never ever relax"); }
    }

    internal class GoodPupil : Pupil
    {
        public override void Study() { Console.WriteLine("I like studying"); }
        public override void Read() { Console.WriteLine("I often read"); }
        public override void Write() { Console.WriteLine("I can write anything"); }
        public override void Relax() { Console.WriteLine("I relax with friends"); }
    }

    internal class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine("I don't like studying"); }
        public override void Read() { Console.WriteLine("I never read"); }
        public override void Write() { Console.WriteLine("I never ever read"); }
        public override void Relax() { Console.WriteLine("I relax always"); }
    }
}

/*
Создать класс, представляющий учебный класс ClassRoom.
Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
Write(), void Relax().
Создайте 3 производных класса ExcellentPupil, GoodPupil, BadPupil от класса базового класса
Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать,
писать, отдыхать.
 */
