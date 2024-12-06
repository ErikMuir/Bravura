using System;

namespace Bravura.Common.Types;

public class Incrementable(int value = 0)
{
    public int Value { get; private set; } = value;

    public int Increment(int amount = 1) => amount >= 0 ? Value += amount : throw new ArgumentException();

    public int IncrementIf(bool doApply, int amount = 1) => doApply ? Increment(amount) : Value;

    public int Decrement(int amount = 1) => Value -= amount;

    public int DecrementIf(bool doApply, int amount = 1) => doApply ? Decrement(amount) : Value;
}
