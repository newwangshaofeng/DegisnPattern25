using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    internal class Contractor
    {
        private IHouseBuilder houseBuilder;

        public Contractor(IHouseBuilder builder)
        {
            houseBuilder = builder;
        }

        public House BuildHouse()
        {
            houseBuilder.BuildWalls();
            houseBuilder.BuildRoof();
            houseBuilder.BuildDoors();
            houseBuilder.BuildWindows();

            return houseBuilder.GetHouse();
        }
    }
}
