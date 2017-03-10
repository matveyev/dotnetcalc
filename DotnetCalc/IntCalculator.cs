using System;
namespace DotnetCalc {
    public class IntCalculator: ICalculator<int> {
        public int Add(int left, int right) {
            return left + right;
        }

        public int Subtract(int left, int right) {
            return left - right;
        }

        public int Multiply(int left, int right) {
            return left * right;
        }

        public int Divide(int left, int right) {
            return left/ right;
        }

        public int GetOperandValueFromString(String operandValue) {
            return Convert.ToInt32(operandValue);
        }

        public String OperandValueToString(int value) {
            return value.ToString();
        }
    }
}