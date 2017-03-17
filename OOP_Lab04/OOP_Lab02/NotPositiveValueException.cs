using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02 {
    class NotPositiveValueException : Exception {

        public NotPositiveValueException(string valueName) :
            base("The " + valueName + " can not be negative or zero") { }

    }
}
