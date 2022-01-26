using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public ushort Price { set; get; }

        public int Ammount { set; get; }

        public string Desc { set; get; }

        public string Img { set; get; }
    }
}
