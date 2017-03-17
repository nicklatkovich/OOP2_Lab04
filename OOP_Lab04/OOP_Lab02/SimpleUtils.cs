using System;

namespace OOP_Lab02 {
    class SimpleUtils {

        static private Random rand = new Random( );

        public static Int32 IRandom(Int32 maxValue) { return rand.Next( ) % (maxValue + 1); }

        public static Int32 IRandomRange(Int32 minValue, Int32 maxValue) {
            return minValue + IRandom(maxValue - minValue);
        }

    }
}
