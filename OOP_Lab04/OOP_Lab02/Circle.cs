using System;

namespace OOP_Lab02 {
    class Circle {

        private float _radius;

        public Circle(float radius) { this.Radius = radius; }

        public float Radius {
            get { return _radius; }
            set {
                if (value > 0) {
                    _radius = value;
                } else { throw new NotPositiveValueException("radius"); }
            }
        }

        public override String ToString( ) {
            return "Circle (Radius=" + this.Radius + ")";
        }

        public float Area { get { return (float)(Math.PI * Math.Pow(Radius, 2)); } }
    }
}
