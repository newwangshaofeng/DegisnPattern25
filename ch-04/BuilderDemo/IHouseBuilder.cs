using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    internal interface IHouseBuilder
    {

        void BuildWalls();
        void BuildRoof();
        void BuildDoors();
        void BuildWindows();
        House GetHouse();
    }

    //复杂房屋
    public class SimpleHouseBuilder2 : IHouseBuilder
    {
        private House house;

        public SimpleHouseBuilder2()
        {
            house = new House();
        }

        public void BuildWalls()
        {
            house.Walls = "土墙";
        }

        public void BuildRoof()
        {
            house.Roof = "圆屋顶";
        }

        public void BuildDoors()
        {
            house.Doors = "玻璃门";
        }

        public void BuildWindows()
        {
            house.Windows = "水晶窗户";
        }

        public House GetHouse()
        {
            return house;
        }
    }




    public class SimpleHouseBuilder : IHouseBuilder
    {
        private House house;

        public SimpleHouseBuilder()
        {
            house = new House();
        }

        public void BuildWalls()
        {
            house.Walls = "砖墙";
        }

        public void BuildRoof()
        {
            house.Roof = "平屋顶";
        }

        public void BuildDoors()
        {
            house.Doors = "木门";
        }

        public void BuildWindows()
        {
            house.Windows = "玻璃窗户";
        }

        public House GetHouse()
        {
            return house;
        }
    }
}
