using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    public class Car
    {
        private int modelYear;

        public int ModelYear
        {
            get
            {
                return modelYear;
            }

            set
            {
                if (value < 1900) throw new ArgumentOutOfRangeException("Value need to be above 1900");
                modelYear = value;
            }
        }
        public string Maker { get; set; }

        public override string ToString()
        {
            return $"{ModelYear}, {Maker}";
        }
    }
}
