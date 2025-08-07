
namespace Kalkulator{
public class Fraction : NumberBase {
            public int counter { get; }
            public int denominator { get; }

            public Fraction(int counter, int denominator) {
                  this.counter = counter;
                  this.denominator = denominator;
            }
            public override NumberBase Add( NumberBase other ) {
                  Fraction? f = other as Fraction;
                  if(f == null) throw new ArgumentException("Diffrent type of number");
                  int newCounter = this.counter * f.denominator + f.counter * this.denominator;
                  int newDenominator = this.denominator * f.denominator;

                  Fraction result =  new Fraction(newCounter, newDenominator);
                  return result.Reduce();
            }
            public override NumberBase Multiply( NumberBase other ) {
                  Fraction? f = other as Fraction;
                  if(f == null) throw new ArgumentException("Diffrent type of number");
                  int newCounter = this.counter * f.counter;
                  int newDenominator = this.denominator * f.denominator;

                  Fraction result =  new Fraction(newCounter, newDenominator);
                  return result.Reduce();
            }
            public override NumberBase Substraction( NumberBase other ) {
                  Fraction? f = other as Fraction;
                  if(f == null) throw new ArgumentException("Diffrent type of number");
                  int newCounter = this.counter * f.denominator - f.counter * this.denominator;
                  int newDenominator = this.denominator * f.denominator;

                  Fraction result = new Fraction(newCounter, newDenominator);
                  return result.Reduce();
            }
            public override NumberBase Devide( NumberBase other ) {
                  Fraction? f = other as Fraction;
                  if(f == null) throw new ArgumentException("Diffrent type of number");
                  int newCounter = this.counter * f.denominator;
                  int newDenominator = this.denominator * f.counter;

                  Fraction result =  new Fraction(newCounter, newDenominator);
                  return result.Reduce();
                  
            }
            public Fraction Reduce()
            {
                  int gcd = GCD(counter, denominator);
                  return new Fraction(counter / gcd, denominator / gcd);
            }

            private int GCD(int a, int b)
            {
                  while (b != 0)
                  {       
                  int temp = b;
                  b = a % b;
                  a = temp;
                  }
            return a;
            }
             public override string ToString()
            {
                  return $"{counter}/{denominator}";
            }
            


      
      }
}