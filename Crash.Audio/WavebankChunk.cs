namespace Crash.Audio
{
    public sealed class WavebankChunk : EntryChunk
    {
        private WavebankEntry entry;
        private int unknown1;
        private int unknown2;

        public WavebankChunk(WavebankEntry entry,int unknown1,int unknown2)
        {
            this.entry = entry;
            this.unknown1 = unknown1;
            this.unknown2 = unknown2;
        }

        public override short Type
        {
            get { return 4; }
        }

        public WavebankEntry Entry
        {
            get { return entry; }
        }

        public override byte[] Save()
        {
            Entry[] entries = new Entry [1];
            entries[0] = entry;
            return Save(entries,unknown1,unknown2);
        }
    }
}