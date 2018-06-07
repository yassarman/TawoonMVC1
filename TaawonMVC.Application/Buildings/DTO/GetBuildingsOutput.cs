using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Buildings.DTO
{
  public  class GetBuildingsOutput
    {
        public int Id { get; set; }
        public int buildingID { get; set; }
        public int numOfBuildingUnits { get; set; }
        public int numOfFloors { get; set; }
        public string streetName { get; set; }
        public int buildingNo { get; set; }
        public int neighborhoodID { get; set; }
        public int buildingTypeID { get; set; }
        public string GISMAP { get; set; }
        public byte houshProperty { get; set; }
        public string houshName { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
