using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Overview_project.Models.viewmodel
{
    public class Contacto
    {
        [Key]
        public long id_entity { get; set; }
        [Required]
        [MaxLength(50)]
        public string name_entity { get; set; }
        [Required]
        [MaxLength(30)]
        public string email_entity { get; set; }
        [Required]
        [MaxLength(30)]
        public string state_entity { get; set; }
        [Required]
        [MaxLength(50)]
        public string city_entity { get; set; }

        public ICollection<departamento> listaMunicipios { get; set; }
    }
}