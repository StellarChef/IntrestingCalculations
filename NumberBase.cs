using System;
namespace Kalkulator {
      public abstract class NumberBase {
            abstract public NumberBase Add( NumberBase other );
            abstract public NumberBase Multiply( NumberBase other );
            abstract public NumberBase Devide( NumberBase other );
            abstract public NumberBase Substraction( NumberBase other);

      }
}