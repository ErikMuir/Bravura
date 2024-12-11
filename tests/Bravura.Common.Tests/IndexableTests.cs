using System;
using System.Collections.Generic;

namespace Bravura.Common.Tests;

public class IndexableTests
{
    [Fact]
    public void Constructor_SetsProperties()
    {
        List<string> objects = ["foo", "bar", "baz"];
        const int startingIndex = 1;
        var testObject = new Indexable<string>(objects, startingIndex);
        Assert.Equal(objects, testObject.Objects);
        Assert.Equal(startingIndex, testObject.Index);
    }

    [Fact]
    public void Constructor_WhenNotProvidedStartingIndex_ThenDefaultsToZero()
    {
        List<string> objects = ["foo", "bar", "baz"];
        var testObject = new Indexable<string>(objects);
        Assert.Equal(0, testObject.Index);
    }

    [Fact]
    public void Count_ReturnsNumberOfObjects()
    {
        List<string> objects = ["foo", "bar", "baz"];
        var testObject = new Indexable<string>(objects);
        Assert.Equal(3, testObject.Count);
    }

    [Fact]
    public void Current_ReturnsObjectAtCurrentIndex()
    {
        List<string> objects = ["foo", "bar", "baz"];
        var testObject = new Indexable<string>(objects, 1);
        Assert.Equal("bar", testObject.Current);
    }

    [Fact]
    public void MoveNext_IncrementsIndex()
    {
        List<string> objects = ["foo", "bar", "baz"];
        var testObject = new Indexable<string>(objects);
        testObject.MoveNext();
        Assert.Equal(1, testObject.Index);
    }

    [Fact]
    public void MoveNext_Throws_WhenGoingOutOfRange()
    {
        List<string> objects = ["foo", "bar", "baz"];
        var testObject = new Indexable<string>(objects, 2);
        Assert.Throws<IndexOutOfRangeException>(() => testObject.MoveNext());
    }

    [Fact]
    public void Reset_SetsIndexToZero()
    {
        List<string> objects = ["foo", "bar", "baz"];
        var testObject = new Indexable<string>(objects, 2);
        testObject.Reset();
        Assert.Equal(0, testObject.Index);
    }

    [Fact]
    public void MoveNextOrReset_IncrementsIndex()
    {
        List<string> objects = ["foo", "bar", "baz"];
        var testObject = new Indexable<string>(objects);
        testObject.MoveNextOrReset();
        Assert.Equal(1, testObject.Index);
    }

    [Fact]
    public void MoveNextOrReset_SetsIndexToZero()
    {
        List<string> objects = ["foo", "bar", "baz"];
        var testObject = new Indexable<string>(objects, 2);
        testObject.MoveNextOrReset();
        Assert.Equal(0, testObject.Index);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public void JumpTo_SetsIndexToProvidedValue(int index)
    {
        List<string> objects = ["foo", "bar", "baz"];
        var testObject = new Indexable<string>(objects);
        testObject.JumpTo(index);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(3)]
    public void JumpTo_Throws_WhenValueIsOutOfRange(int index)
    {
        List<string> objects = ["foo", "bar", "baz"];
        var testObject = new Indexable<string>(objects);
        Assert.Throws<IndexOutOfRangeException>(() => testObject.JumpTo(index));
    }
}
