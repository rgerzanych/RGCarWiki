using System;
using System.Collections.Generic;
using System.Text;

namespace RGCarWiki.Business
{
    public class Model
    {
        public Model()
        {
            Series = new List<Series>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Series> Series { get; set; }
    }
}
