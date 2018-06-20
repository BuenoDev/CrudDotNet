using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crudNetWeb.Models
{
    public class PacienteModel
    {
        [Key]
        public int cod { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public DateTime dataNasc { get; set; }
        public Double valorPlano { get; set; }
    }
}