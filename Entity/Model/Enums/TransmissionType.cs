using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAgency_WindowsDesktopApp.Entity.Model.Enums
{
    public record TransmissionType
    {
        [Key]
        public Guid Id { get; init; }


        [Required]
        [MaxLength(45)]
        public string Description { get; init; } = string.Empty;

    }

}
