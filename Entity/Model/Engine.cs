using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using CarAgency_WindowsDesktopApp.Entity.Model.Enums;

namespace CarAgency_WindowsDesktopApp.Entity.Model
{
    record Engine
    {
        [Key]
        public Guid Id { get; init; }

        public ushort? PowerCC { get; init; }

        [Column(TypeName = "decimal(10,2)")]
        public float? MaxPowerBhp { get; init; }

        public uint? TorqueNm { get; init; }

        public uint? TorqueRpmMin { get; init; }

        public uint? TorqueRpmMax { get; init; }

        [Column(TypeName = "decimal(10,2)")]
        public float? MileageKmpl { get; init; }

        [ForeignKey("FuelType")]
        public Guid? FuelTypeId { get; set; }
        public FuelType? FuelType { get; set; }


        [ForeignKey("TransmissionType")]
        public Guid? TransmissionTypeId { get; set; }
        public TransmissionType? TransmissionType { get; set; }

    }
}
