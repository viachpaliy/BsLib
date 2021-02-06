namespace BsLib
{
    interface Macro
    {
        string Name { get; }
        public string ToBpp();
        public string ToCix();
    }
}