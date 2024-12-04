namespace Bravura.Common.Types;

public class AppliedWeight
{
    public int Weight { get; private set; } = 0;

    public void Apply(int amount = 1)
    {
        Weight += amount;
    }

    public void ApplyIf(bool doApply, int amount = 1)
    {
        if (doApply) Apply(amount);
    }
}
