using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 秒懂设计模式.建造者模式
{

    public class BuildTest
    {
        public static void Show()
        {            
            Director director = new Director();
            //别墅
            director.SetBuilder(new HouseBuilder());
            director.Direct().Show();
            //公寓
            director.SetBuilder(new ApartmentBuilder());
            director.Direct().Show() ;
        }
    }

    /// <summary>
    /// 建筑物
    /// </summary>
    public class Building
    {
        private List<string> buildingComponents = new List<string>();
        /// <summary>
        /// 地基
        /// </summary>
        public void SetBasement(string basement)
        {
            buildingComponents.Add(basement);
        }
        /// <summary>
        /// 墙
        /// </summary>
        /// <param name="wall"></param>
        public void SetWall(string wall)
        {
            buildingComponents.Add(wall);
        }
        /// <summary>
        /// 屋顶
        /// </summary>
        /// <param name="roof"></param>
        public void SetRoof(string roof)
        {
            this.buildingComponents.Add(roof);
        }

        public void Show()
        {
            StringBuilder sb = new StringBuilder();

            buildingComponents.ForEach(item => sb.Append(item));

            Console.WriteLine(sb.ToString()); 
        }
    }
    /// <summary>
    /// 施工方案
    /// </summary>
    public interface Builder
    {
        public void BuildBasement();
        public void BuildWall();

        public void BuildRoof();

        public Building GetBingding();
    }
    /// <summary>
    /// 别墅
    /// </summary>
    public class HouseBuilder : Builder
    {
        private Building house;
        public HouseBuilder()
        {
            house = new Building();
        }

        public void BuildBasement()
        {
            house.SetBasement("别墅地基");
        }

        public void BuildRoof()
        {
            house.SetRoof("别墅屋顶");
        }

        public void BuildWall()
        {
            house.SetWall("别墅墙");
        }

        public Building GetBingding()
        {
            return house;
        }
    }
    /// <summary>
    /// 多层公寓
    /// </summary>
    public class ApartmentBuilder : Builder
    {
        private Building apartment;

        public ApartmentBuilder()
        {
            apartment = new Building();
        }
        public void BuildBasement()
        {
            apartment.SetBasement("公寓地基");
        }

        public void BuildRoof()
        {
            apartment.SetRoof("公寓屋顶");
        }

        public void BuildWall()
        {
            apartment.SetWall("公寓墙");
        }

        public Building GetBingding()
        {
            return apartment;
        }
    }

    /// <summary>
    /// 工程总监
    /// </summary>
    public class Director
    {
        private Builder builder;

        public Director()
        {

        }
        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void SetBuilder(Builder builder)
        {
            this.builder = builder;
        }
        public Building Direct()
        {
            builder.BuildBasement();
            builder.BuildWall();
            builder.BuildRoof();
            return builder.GetBingding();
        }
    }
}
