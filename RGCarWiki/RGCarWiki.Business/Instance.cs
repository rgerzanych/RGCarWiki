using System.Collections.Generic;

namespace RGCarWiki.Business
{
    public class Instance
    {
        public Instance()
        {
            Bodies = new List<Body>();
            RegNumbers = new List<string>();
        }

        public int Id { get; set; }

        public string ChassisNumber { get; set; }

        public IList<Body> Bodies { get; set; }

        public IList<string> RegNumbers { get; set; }

        public int? Year { get; set; }
    }
}
