using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICore.Model
{
    public class Provider
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(100, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(14, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 11)]
        public string Document { get; set; }

        public int ProviderType { get; set; }

        public bool Active { get; set; }
    }
}
