using System;

namespace Lab6_MusicalInstruments
{
    // Абстрактний базовий клас
    abstract class Instrument
    {
        protected string name;

        public Instrument(string name)
        {
            this.name = name;
        }

        // Метод відтворення характерного звуку
        public abstract void Play();
    }
}
using System;

namespace Lab6_MusicalInstruments
{
    class Piano : Instrument
    {
        public Piano(string name) : base(name) { }

        public override void Play()
        {
            Console.WriteLine($"Фортепіано {name} відтворює мелодійну ноту: До-ре-мі.");
        }
    }
}
using System;

namespace Lab6_MusicalInstruments
{
    class Guitar : Instrument
    {
        public Guitar(string name) : base(name) { }

        public override void Play()
        {
            Console.WriteLine($"Гітара {name} відтворює струнний звук: Дзень-дзень.");
        }
    }
}
using System;

namespace Lab6_MusicalInstruments
{
    class Drums : Instrument
    {
        public Drums(string name) : base(name) { }

        public override void Play()
        {
            Console.WriteLine($"Барабани {name} відтворюють ритм: Бум-бум.");
        }
    }
}
using System;
using System.Collections.Generic;

namespace Lab6_MusicalInstruments
{
    class Program
    {
        static void Main()
        {
            List<Instrument> instruments = new List<Instrument>
            {
                new Piano("Yamaha"),
                new Guitar("Fender"),
                new Drums("Pearl")
            };

            Console.WriteLine("Відтворення характерного звуку кожного інструмента:\n");

            foreach (Instrument instrument in instruments)
            {
                instrument.Play();
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
