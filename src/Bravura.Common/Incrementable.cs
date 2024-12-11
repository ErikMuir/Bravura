using System;

namespace Bravura.Common;

public class Incrementable(int value = 0)
{
    public int Value { get; private set; } = value;

    public int Increment(int amount = 1) => amount >= 0
        ? Value += amount
        : throw new ArgumentException($"The value must be >= 0, but was {amount}.", nameof(amount));

    public int IncrementIf(bool doApply, int amount = 1) => doApply ? Increment(amount) : Value;

    public int Decrement(int amount = 1) => amount >= 0
        ? Value -= amount
        : throw new ArgumentException($"The value must be >= 0, but was {amount}.", nameof(amount));

    public int DecrementIf(bool doApply, int amount = 1) => doApply ? Decrement(amount) : Value;
}
