using System;

namespace Type_conversion_implict__explict_
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid id = Guid.NewGuid();

            UserId userId = new UserId(id);
            UserId userIda = id;//bo implicit
            
        }
    }
}
/*zasada działania:
int someInt = 420;
long biggerInt = someInt;*/