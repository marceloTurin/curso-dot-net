using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    class Calculator {

        //Colocando params podemos colcoar quantos parametros que quiser.
        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
