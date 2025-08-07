using System;

namespace Kalkulator {
    class UserInterface {
        public static void Run() {
            string? input;

            while (true) {
                Console.WriteLine("Write the equation or exit:");
                input = Console.ReadLine();

                if (input == null) {
                    Console.WriteLine("No input provided. Please try again.");
                    continue;
                }

                if (input == "exit") break;

                try {
                    // USUWANIE WSZYSTKICH SPACJI
                    input = input.Replace(" ", "");

                    // Szukamy operatora (+, -, *, /) od drugiego znaku (żeby nie złapać minusa z liczby)
                    int opIndex = input.IndexOfAny(new char[] { '+', '-', '*', '/' }, 1);
                    if (opIndex == -1) {
                        Console.WriteLine("Invalid input format. Example: 1/2+3/4, 1+3i-2+6i, 1+4");
                        continue;
                    }

                    string firstRaw = input.Substring(0, opIndex);
                    string symbol = input.Substring(opIndex, 1);
                    string secondRaw = input.Substring(opIndex + 1);

                    NumberBase first = ParseAuto(firstRaw);
                    NumberBase second = ParseAuto(secondRaw);

                    NumberBase result;

                    if (symbol == "+") {
                        result = first.Add(second);
                    } else if (symbol == "-") {
                        result = first.Substraction(second);
                    } else if (symbol == "*") {
                        result = first.Multiply(second);
                    } else if (symbol == "/") {
                        result = first.Devide(second);
                    } else {
                        throw new Exception("Invalid operator");
                    }

                    Console.WriteLine();
                    Console.WriteLine($"= {result}");
                    Console.WriteLine();
                } catch (Exception ex) {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private static NumberBase ParseAuto(string input) {
        input = input.Trim();

            if (input.Contains("i")) {
                return Parser.ParseComplexNumber(input);
            }
            else if (input.Contains("/")) {
                return Parser.ParseFraction(input);
            }
            else {
                return Parser.ParseNumber(input);
            }
        }
    }
}