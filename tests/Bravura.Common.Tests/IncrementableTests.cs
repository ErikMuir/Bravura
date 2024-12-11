using System;

namespace Bravura.Common.Tests;

public class IncrementableTests
{
    #region Constructor

    [Fact]
    public void Constructor_SetsProvidedValue()
    {
        var testObject = new Incrementable(4);
        Assert.Equal(4, testObject.Value);
    }

    [Fact]
    public void Constructor_DefaultsValueToZero()
    {
        var testObject = new Incrementable();
        Assert.Equal(0, testObject.Value);
    }

    #endregion

    #region Increment

    [Theory]
    [InlineData(1)]
    [InlineData(7)]
    [InlineData(13)]
    public void Increment_AddsProvidedAmount(int amount)
    {
        var testObject = new Incrementable(3);
        testObject.Increment(amount);
        Assert.Equal(3 + amount, testObject.Value);
    }

    [Fact]
    public void Increment_AddsDefaultAmountOfOne()
    {
        var testObject = new Incrementable();
        testObject.Increment();
        Assert.Equal(1, testObject.Value);
    }

    [Fact]
    public void Increment_ReturnsResultingValue()
    {
        var testObject = new Incrementable();
        var result = testObject.Increment();
        Assert.Equal(testObject.Value, result);
    }

    [Fact]
    public void Increment_ThrowsWhenAmountIsNegative()
    {
        var testObject = new Incrementable();
        Assert.Throws<ArgumentException>(() => testObject.Increment(-1));
    }

    #endregion

    #region IncrementIf

    [Fact]
    public void IncrementIf_IncrementsIfDoApplyIsTrue()
    {
        var testObject = new Incrementable();
        const bool doApply = true;
        testObject.IncrementIf(doApply, 3);
        Assert.Equal(3, testObject.Value);
    }

    [Fact]
    public void IncrementIf_DoesNotIncrementIfDoApplyIsFalse()
    {
        var testObject = new Incrementable();
        const bool doApply = false;
        testObject.IncrementIf(doApply);
        Assert.Equal(0, testObject.Value);
    }

    [Fact]
    public void IncrementIf_ReturnsResultingValue()
    {
        var testObject = new Incrementable();
        const bool doApply = true;
        var result = testObject.IncrementIf(doApply, 3);
        Assert.Equal(testObject.Value, result);
    }

    [Fact]
    public void IncrementIf_ThrowsWhenAmountIsNegative()
    {
        var testObject = new Incrementable();
        Assert.Throws<ArgumentException>(() => testObject.IncrementIf(true, -1));
    }

    #endregion

    #region Decrement

    [Theory]
    [InlineData(1)]
    [InlineData(7)]
    [InlineData(13)]
    public void Decrement_SubtractsProvidedAmount(int amount)
    {
        var testObject = new Incrementable(20);
        testObject.Decrement(amount);
        Assert.Equal(20 - amount, testObject.Value);
    }

    [Fact]
    public void Decrement_SubtractsDefaultAmountOfOne()
    {
        var testObject = new Incrementable();
        testObject.Decrement();
        Assert.Equal(-1, testObject.Value);
    }

    [Fact]
    public void Decrement_ReturnsResultingValue()
    {
        var testObject = new Incrementable();
        var result = testObject.Decrement();
        Assert.Equal(testObject.Value, result);
    }

    [Fact]
    public void Decrement_ThrowsWhenAmountIsNegative()
    {
        var testObject = new Incrementable();
        Assert.Throws<ArgumentException>(() => testObject.Decrement(-1));
    }

    #endregion

    #region DecrementIf

    [Fact]
    public void DecrementIf_DecrementsIfDoApplyIsTrue()
    {
        var testObject = new Incrementable();
        const bool doApply = true;
        testObject.DecrementIf(doApply, 3);
        Assert.Equal(-3, testObject.Value);
    }

    [Fact]
    public void DecrementIf_DoesNotDecrementIfDoApplyIsFalse()
    {
        var testObject = new Incrementable();
        const bool doApply = false;
        testObject.DecrementIf(doApply, 3);
        Assert.Equal(0, testObject.Value);
    }

    [Fact]
    public void DecrementIf_ReturnsResultingValue()
    {
        var testObject = new Incrementable();
        const bool doApply = true;
        var result = testObject.DecrementIf(doApply, 3);
        Assert.Equal(testObject.Value, result);
    }

    [Fact]
    public void DecrementIf_ThrowsWhenAmountIsNegative()
    {
        var testObject = new Incrementable();
        Assert.Throws<ArgumentException>(() => testObject.DecrementIf(true, -1));
    }

    #endregion
}
