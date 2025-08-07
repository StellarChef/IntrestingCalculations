using System;
namespace Kalkulator {
      class IntegerNumber : NumberBase
      {
            public int number { get; }

            public IntegerNumber(int number) {
                  this.number = number;
            }
            public override NumberBase Add( NumberBase other ) {

                  IntegerNumber? integer = other as IntegerNumber;
                  if(integer == null) throw new Exception("Diffrent type of number");

                  int result = this.number + integer.number;
                  return new IntegerNumber(result);
            }
            public override NumberBase Substraction( NumberBase other ) {
                  IntegerNumber? integer = other as IntegerNumber;
                  if(integer == null) throw new Exception("Diffrent type of number");

                  int result = this.number - integer.number;
                  return new IntegerNumber(result);
            }
            public override NumberBase Multiply( NumberBase other ) {

                  IntegerNumber? integer = other as IntegerNumber;
                  if(integer == null) throw new Exception("Diffrent type of number");

                  int result = this.number * integer.number;
                  return new IntegerNumber(result);
            }
            public override NumberBase Devide( NumberBase other ) {

                  IntegerNumber? integer = other as IntegerNumber;
                  if(integer == null) throw new Exception("Diffrent type of number");

                  int result = this.number / integer.number;
                  return new IntegerNumber(result);
            }

            public override string ToString() {
                  return number.ToString();
            }

      }
}