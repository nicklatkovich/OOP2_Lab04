using System;

namespace OOP_Lab02 {
    class NotPositiveValueException : Exception {

        public NotPositiveValueException(string valueName) :
            base("The " + valueName + " can not be negative or zero") { }

    }
}
