namespace Bravura.Tonality.Analysis;

public class AppliedWeight
{
    public int Weight { get; private set; } = 0;

    public void Apply(int amount)
    {
        Weight += amount;
    }

    public void ApplyIf(int amount, bool doApply)
    {
        if (doApply) Apply(amount);
    }

    public void ApplyIf(bool doApply) => ApplyIf(1, doApply);
}
