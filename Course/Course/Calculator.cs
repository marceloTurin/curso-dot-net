using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Calculator {

        //O modificador ref faz uma referencia a variavel original, ou seja a funcao altera o valor da variavel passada no parametro;
        public static void Triple(ref int x) {
            x = x * 3;
        }
    }
}
