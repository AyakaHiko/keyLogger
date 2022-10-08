namespace keyLogger
{
    public struct TimeInterval
    {
        //time in ms
        public int Time;
        public string Name;

        public override string ToString()
            => Name;
    }
}