using System;
public class DoubleCalculator: ICalculator<double> {
    public double Add(double left, double right) {
        return left + right;
    }

    public double Subtract(double left, double right) {
        return left - right;
    }

    public double Multiply(double left, double right) {
        return left * right;
    }

    public double Divide(double left, double right) {
        return left/ right;
    }

    public double GetOperandValueFromString(String operandValue) {
        return Convert.ToDouble(operandValue);
    }

    public String OperandValueToString(double value) {
        return value.ToString();
    }
}