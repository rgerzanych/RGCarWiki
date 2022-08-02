using System.Collections.Generic;

namespace RGCarWiki.Business
{
    public class Series
    {
        public Series() 
        {
            Instances = new List<Instance>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Instance> Instances { get; set; }
    }
}
