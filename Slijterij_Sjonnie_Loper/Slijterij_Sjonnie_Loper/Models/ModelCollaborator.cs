using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Slijterij_Sjonnie_Loper.Models
{
    public class ModelCollaborator
    {
        public string id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required")]

        public string Password { get; set; }

        public string LoginErrorMessage { get; set; }

    }
}
