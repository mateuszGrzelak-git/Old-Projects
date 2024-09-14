using System;

namespace GUID
{
    class Program
    {
        static void Main(string[] args)
        {
            //guid - uniwersalnie unikatowy identyfikator(binar)
            var guid = new Guid();
            Guid g = Guid.Empty;
            Guid h = Guid.NewGuid();
        }
    }
}
