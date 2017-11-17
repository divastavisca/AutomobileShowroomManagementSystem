using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem.Contracts;

namespace CoreSystem
{
    public class Automobile
    {
        public string Id { get; }
        public VehicalType Type { get; }
        public string Brand { get; }
        public string ModelSeries { get; }
        public string ModelId { get; }
        public DateTime ManufacturingDate { get; }
        public double ShowroomPrice { get; }

        public Automobile(string id,VehicalType typeOfVehical,string brand,string modelSeries,string modelId,DateTime manufacturingDate,double showroomPrice)
        {
            Id = id;
            Type = typeOfVehical;
            Brand = brand;
            ModelSeries = modelSeries;
            ModelId = modelId;
            ManufacturingDate = manufacturingDate;
            ShowroomPrice = showroomPrice;
        }
    }
}
