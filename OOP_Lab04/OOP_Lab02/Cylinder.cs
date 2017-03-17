using System;

namespace OOP_Lab02 {
    class Cylinder : IComparable {

        private Circle _base;
        private float _height;
        private static UInt32 _number = 0;
        private static UInt32 _nextID;

        public readonly UInt32 ID;
        public Circle BaseCircle {
            get { return _base; }
            set {
                if (value != null) {
                    _base = value;
                } else { throw new NullReferenceException( ); }
            }
        }
        public float Radius {
            get { return this.BaseCircle.Radius; }
            set { this.BaseCircle.Radius = value; }
        }
        public float Height {
            get { return this._height; }
            set {
                if (value > 0f) {
                    this._height = value;
                } else { throw new NotPositiveValueException("height"); }
            }
        }
        public virtual string ShapeType { get { return "Cylinder"; } }
        public const UInt32 BASES_NUMBER = 2;
        public static UInt32 Number { get { return _number; } }

        public Cylinder(float radius, float height) : this(new Circle(radius), height) { }
        public Cylinder(Circle cylinderBase, float height) {
            this.BaseCircle = cylinderBase;
            this.Height = height;
            _number++;
            ID = _nextID++;
        }
        public Cylinder( ) : this(10, 20) { }
        ~Cylinder( ) { _number--; }
        static Cylinder( ) { _nextID = 0; }

        public Cylinder Clone( ) { return new Cylinder(Radius, Height); }
        public void CloneInsteadOf(out Cylinder insteadOf) { insteadOf = Clone( ); }
        public void AddTo(ref Cylinder prolongedCylinder) {
            prolongedCylinder.Radius += this.Radius;
            prolongedCylinder.Height += this.Height;
        }

        public static string GetInfo( ) {
            return "Cylinder is the surface formed by the points at a fixed distance from a given straight line called the axis of the cylinder. It is one of the most basic curvilinear geometric shapes.";
        }

        public override Boolean Equals(Object obj) {
            if (obj == null) { return false; }
            Cylinder target = obj as Cylinder;
            if (target == null) { return false; }
            return this.Radius == target.Radius && this.Height == target.Height;
        }
        public override Int32 GetHashCode( ) {
            return (~Radius.GetHashCode( )) ^ Height.GetHashCode( );
        }
        public override String ToString( ) {
            string result = "Cylinder {\n";
            result += "\tBase   : " + this.BaseCircle + "\n";
            result += "\tHeight : " + this.Height + "\n";
            result += "}";
            return result;
        }

        public float Volume { get { return this.BaseCircle.Area * Height; } }

        public Int32 CompareTo(Object obj) {
            if (obj is Cylinder) {
                return Math.Sign(this.Volume - (obj as Cylinder).Volume);
            } else {
                throw new Exception("object of compare is not cylinder");
            }
        }
    }
}