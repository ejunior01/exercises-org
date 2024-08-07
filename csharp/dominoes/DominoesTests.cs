using System;
using Xunit;

public class DominoesTests
{
    [Fact]
    public void Empty_input_empty_output()
    {
        var dominoes = Array.Empty<(int, int)>();
        Assert.True(Dominoes.CanChain(dominoes));
    }

    [Fact]
    public void Singleton_input_singleton_output()
    {
        var dominoes = new[] { (1, 1) };
        Assert.True(Dominoes.CanChain(dominoes));
    }

    [Fact]
    public void Singleton_that_cant_be_chained()
    {
        var dominoes = new[] { (1, 2) };
        Assert.False(Dominoes.CanChain(dominoes));
    }

    [Fact]
    public void Three_elements()
    {
        var dominoes = new[] { (1, 2), (3, 1), (2, 3) };
        Assert.True(Dominoes.CanChain(dominoes));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Can_reverse_dominoes()
    {
        var dominoes = new[] { (1, 2), (1, 3), (2, 3) };
        Assert.True(Dominoes.CanChain(dominoes));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Cant_be_chained()
    {
        var dominoes = new[] { (1, 2), (4, 1), (2, 3) };
        Assert.False(Dominoes.CanChain(dominoes));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Disconnected_simple()
    {
        var dominoes = new[] { (1, 1), (2, 2) };
        Assert.False(Dominoes.CanChain(dominoes));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Disconnected_double_loop()
    {
        var dominoes = new[] { (1, 2), (2, 1), (3, 4), (4, 3) };
        Assert.False(Dominoes.CanChain(dominoes));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Disconnected_single_isolated()
    {
        var dominoes = new[] { (1, 2), (2, 3), (3, 1), (4, 4) };
        Assert.False(Dominoes.CanChain(dominoes));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Need_backtrack()
    {
        var dominoes = new[] { (1, 2), (2, 3), (3, 1), (2, 4), (2, 4) };
        Assert.True(Dominoes.CanChain(dominoes));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Separate_loops()
    {
        var dominoes = new[] { (1, 2), (2, 3), (3, 1), (1, 1), (2, 2), (3, 3) };
        Assert.True(Dominoes.CanChain(dominoes));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Nine_elements()
    {
        var dominoes = new[] { (1, 2), (5, 3), (3, 1), (1, 2), (2, 4), (1, 6), (2, 3), (3, 4), (5, 6) };
        Assert.True(Dominoes.CanChain(dominoes));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Separate_three_domino_loops()
    {
        var dominoes = new[] { (1, 2), (2, 3), (3, 1), (4, 5), (5, 6), (6, 4) };
        Assert.False(Dominoes.CanChain(dominoes));
    }
}
