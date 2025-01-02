using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class CitiesEntity
    {
        [Key] public int CityID { get; set; }
        public string CityName { get; set; }
        public int? WarehouseID { get; set; }
        public List<WarehousesEntity> Warehouses { get; set; }
    }
}
