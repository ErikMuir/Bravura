namespace Bravura
{
    public struct Key
    {
        public Pitch Root { get; }
        public KeyMode Mode { get; }

        public Key(Pitch root, KeyMode mode)
        {
            Root = root;
            Mode = mode;
        }
    }

    public enum KeyMode
    {
        Major,
        Minor,
    }
}