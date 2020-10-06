using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace covid_dashboard_aspnet_core.Models
{
    [Table("countries")]
    public class Country
    {
        [Key] // pk com auto incremento
        [Display(Name="Código")] // maneira com que vai aparecer na view
        public int Id { get; set; }

        [Display(Name="Nome")]
        [Required(ErrorMessage="Campo Obrigatório")]
        public string Name { get; set; }

        [Display(Name="Dados")]
        public DataCovid DataCovid { get; set; }

    }
}
