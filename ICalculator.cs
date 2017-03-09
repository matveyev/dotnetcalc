using System;

public interface ICalculator<T> where T: struct {
    T Add(T left, T right);

    T Subtract(T left, T right);

    T Multiply(T left, T right);

    T Divide(T left, T right);

    T GetOperandValueFromString(String operandValue);

    String OperandValueToString(T value);
}