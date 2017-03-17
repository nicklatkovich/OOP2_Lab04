using OOP_Lab02;
using System;

namespace OOP_Lab04 {
    class Program {

        static void Main(string[ ] args) {
            CollectionType<Cylinder> ct = new CollectionType<Cylinder>( );
            for (uint i = 0; i < 10; i++) {
                ct.Add(Cylinder.Random);
            }

            foreach (Cylinder cylinder in ct) {
                Console.WriteLine(cylinder);
            }
        }

    }
}
