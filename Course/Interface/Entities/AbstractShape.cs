using Interface.Enums;

namespace Interface.Entities {
    abstract class AbstractShape : IShape {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
