using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Calculator {

        //O modificador ref faz uma referencia a variavel original mas no caso não precisamos iniciar a variavel com um valor;
        public static void Triple(int origin, out int result) {
            result = origin * 3;
        }
    }
}
