using RGCarWiki.Shared.Enums;

namespace RGCarWiki.Business
{
    public class Body
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public BodyType Type { get; set; }

        public bool IsCurrent { get; set; }

        public bool IsOriginal { get; set; }

        public bool IsReplica { get; set; }

        public Coachbuilder BuiltBy { get; set; }
    }
}
