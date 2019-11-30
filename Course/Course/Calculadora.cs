

namespace Course {
    class Calculadora {

         public double Pi = 3.14;

         public double Circunferencia(double raio) {
            return 2.0 * Pi * raio;
        }

         public double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
