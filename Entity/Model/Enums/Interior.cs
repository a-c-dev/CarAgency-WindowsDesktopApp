using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAgency_WindowsDesktopApp.Entity.Model.Enums
{
    record Interior
    {

        [Key]
        public Guid Id { get; init; }

        public ushort? SeatsNumber { get; init; }
    }
}
