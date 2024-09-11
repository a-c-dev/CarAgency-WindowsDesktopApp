using CarAgency_WindowsDesktopApp.Entity.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAgency_WindowsDesktopApp.Entity.Model
{
    record Deal
    {
        [Key]
        public Guid Id { get; init; }

        public uint? Price { get; init; }

        [ForeignKey("Dealers")]
        public Guid? DealerId { get; set; }
        public Dealer? Dealer { get; set; }


        [ForeignKey("SellerTypes")]
        public Guid? SellerTypeId { get; set; }
        public SellerType? SellerType { get; set; }


        [ForeignKey("CarModels")]
        public Guid? CarModelId { get; set; }
        public CarModel? CarModel { get; set; }


        [ForeignKey("CarStatuses")]
        public Guid? CarStatusId { get; set; }
        public SellerType? CarStatus { get; set; }
    }
}
