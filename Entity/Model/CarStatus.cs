using CarAgency_WindowsDesktopApp.Entity.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAgency_WindowsDesktopApp.Entity.Model
{
    record CarStatus
    {

        [Key]
        public Guid Id { get; init; }

        [Range(0, 500000)]
        public uint? KmsDriven { get; init; }

        public DateOnly? Year { get; init; }

        [ForeignKey("OwnerTypes")]
        public Guid? OwnerTypeId { get; set; }
        public OwnerType? OwnerType { get; set; }

    }
}
