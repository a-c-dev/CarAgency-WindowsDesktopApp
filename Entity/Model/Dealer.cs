using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAgency_WindowsDesktopApp.Entity.Model
{
    internal class Dealer
    {
        [Key]
        public Guid Id { get; init; }

        [MaxLength(5)]
        public string? Appellation { get; init; }

        [MaxLength(45)]
        public string? Name { get; init; }

        [MaxLength(45)]
        public string? Surname { get; init; }

    }
}
