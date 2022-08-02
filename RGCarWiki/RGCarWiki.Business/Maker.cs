using System.Collections.Generic;

namespace RGCarWiki.Business
{
    public class Maker
    {
        public Maker()
        {
            Models = new List<Model>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Model> Models { get; set; }
    }
}
