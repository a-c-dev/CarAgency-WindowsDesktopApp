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
    record CarModel
    {
        [Key]
        public Guid Id { get; init; }


        [MaxLength(255)]
        public string? Description { get; init; }

        [ForeignKey("Interiors")]
        public Guid? InteriorId { get; set; }
        public Interior? Interior { get; set; }


        [ForeignKey("Engines")]
        public Guid? EngineId { get; set; }
        public Engine? Engine { get; set; }

    }
}
