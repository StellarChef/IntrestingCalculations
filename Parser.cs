using System;

namespace Kalkulator {
    class Parser {
        public static Fraction ParseFraction(string input) {
            string[] parts = input.Split("/");
            if (parts.Length != 2) throw new Exception("Invalid fraction format");
            return new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
        }

        public static IntegerNumber ParseNumber(string input) {
            return new IntegerNumber(int.Parse(input));
        }

        public static ComplexNumber ParseComplexNumber(string input) {
            input = input.Replace(" ", "").Replace("−", "-");

            if (!input.EndsWith("i")) throw new Exception("Invalid complex number format");

            input = input.Substring(0, input.Length - 1); 
            int signIndex = input.LastIndexOfAny(new char[] { '+', '-' }, input.Length - 1);

            if (signIndex <= 0) throw new Exception("Invalid complex number format");

            string realPart = input.Substring(0, signIndex);
            string imaginaryPart = input.Substring(signIndex);

            int real = int.Parse(realPart);
            int imaginary = int.Parse(imaginaryPart);

            return new ComplexNumber(real, imaginary);
        }
    }
}