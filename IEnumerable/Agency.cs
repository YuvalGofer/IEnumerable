using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    public class Agency 
    {
        public Car[] Cars;

        public IEnumerable<Car> GetCars(int modelYear)
        {
            foreach(var car in Cars)
                if(car.ModelYear == modelYear)
                    yield return car;
            //return Cars.Where(c => c.ModelYear == modelYear).ToArray();
        }
        public IEnumerable<Car> GetCars(string maker)
        {
            foreach(var car in Cars)
                if(car.Maker == maker)
                    yield return car;
            //return Cars.Where(c => c.Maker == maker).ToArray();
        }

        public IEnumerator<Car> GetEnumerator()
        {
            foreach(var car in Cars)
                yield return car;
           //IEnumerator enumerator = Cars.GetEnumerator();
           // while (enumerator.MoveNext())
           //     yield return enumerator.Current;
        }
    }
}
