using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB
{
    public class Membresia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_membresia { get; set; }
        public string nombre_membresia { get; set; }
        public decimal costo { get; set; }
        public int duracion_dias { get; set; }
    }
}
