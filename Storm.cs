// Storm.cs
using System;

namespace MagicalInheritance
{
    class Storm
    {
        public string Essence
        { get; private set; }

        public bool IsStrong
        { get; private set; }

        public string Caster
        { get; private set; }

        public Storm(string essence, bool isstrong, string caster)
        {
            Essence = essence;
            IsStrong = isstrong;
            Caster = caster;
        }

        public void Announce()
        {
            string strength = IsStrong ? "strong" : "weak";
            Console.WriteLine($"{Caster} cast a {strength} {Essence} storm!");
        }
    }
}