using System;
using System.Collections.Generic;
using System.Linq;

namespace лб8
{
    class Program
    {
        public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
        }

        public class Garage
        {
            private readonly List<Car> _vehicles;

            public Garage()
            {
                _vehicles = new List<Car>();
            }

            public void AddVehicle(Car vehicle)
            {
                _vehicles.Add(vehicle);
            }

            public void RemoveVehicle(Car vehicle)
            {
                _vehicles.Remove(vehicle);
            }

            public int Count()
            {
                return _vehicles.Count;
            }

            public List<Car> FindCars(string make = null, string model = null, int? year = null, string color = null)
            {
                return _vehicles.Where(v =>
                    (make == null || v.Make == make) &&
                    (model == null || v.Model == model) &&
                    (year == null || v.Year == year) &&
                    (color == null || v.Color == color)
                ).ToList();
            }
        }
    }
}
