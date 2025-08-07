using System;
      namespace Kalkulator
{
    class ComplexNumber : NumberBase
    {
        public int RealNumber { get; }
        public int ImaginaryNumber { get; }

        public ComplexNumber(int realNumber, int imaginaryNumber)
        {
            this.RealNumber = realNumber;
            this.ImaginaryNumber = imaginaryNumber;
        }

        public override NumberBase Add(NumberBase other)
        {
            ComplexNumber? complex = other as ComplexNumber;
            if (complex == null) throw new Exception("Different type of number");
            int newReal = this.RealNumber + complex.RealNumber;
            int newImaginary = this.ImaginaryNumber + complex.ImaginaryNumber;
            return new ComplexNumber(newReal, newImaginary);
        }

        public override NumberBase Substraction(NumberBase other)
        {
            ComplexNumber? complex = other as ComplexNumber;
            if (complex == null) throw new Exception("Different type of number");
            int newReal = this.RealNumber - complex.RealNumber;
            int newImaginary = this.ImaginaryNumber - complex.ImaginaryNumber;
            return new ComplexNumber(newReal, newImaginary);
        }

        public override NumberBase Multiply(NumberBase other)
        {
            ComplexNumber? complex = other as ComplexNumber;
            if (complex == null) throw new Exception("Different type of number");
            int newReal = this.RealNumber * complex.RealNumber - this.ImaginaryNumber * complex.ImaginaryNumber;
            int newImaginary = this.RealNumber * complex.ImaginaryNumber + this.ImaginaryNumber * complex.RealNumber;
            return new ComplexNumber(newReal, newImaginary);
        }

        public override NumberBase Devide(NumberBase other)
        {
            ComplexNumber? complex = other as ComplexNumber;
            if (complex == null) throw new Exception("Different type of number");
            int denominator = complex.RealNumber * complex.RealNumber + complex.ImaginaryNumber * complex.ImaginaryNumber;
            int newReal = (this.RealNumber * complex.RealNumber + this.ImaginaryNumber * complex.ImaginaryNumber) / denominator;
            int newImaginary = (this.ImaginaryNumber * complex.RealNumber - this.RealNumber * complex.ImaginaryNumber) / denominator;
            return new ComplexNumber(newReal, newImaginary);
        }

        public override string ToString()
        {
            return $"{RealNumber} + {ImaginaryNumber}i";
        }
    }
}