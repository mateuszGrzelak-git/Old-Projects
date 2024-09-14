using System;

namespace Rekordy
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public record Person(string name, DateTime dateofbirth);
    public record struct PersonA(string name, DateTime dateofbirth);
    public record toSamo
    {
        public string name { get; init; } = default!;
        public DateTime dateOfBirth { get; init; } = default!;
    }
}
