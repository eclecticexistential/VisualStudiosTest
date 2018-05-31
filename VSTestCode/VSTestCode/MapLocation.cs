namespace VSTestCode
{
    class MapLocation : Point //subclass / inheritance
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(this + " is outside the map.");
            }
        }
        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
