using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace covid_dashboard_aspnet_core.Models
{
    [Table("datas")]
    public class DataCovid
    {
        [Key]
        [Display(Name="Código")]
        public int Id { get; set; }
        
        [Display(Name="Casos Confirmados")]
        [Required(ErrorMessage="Campo Obrigatório")]
        public int ConfirmedCase { get; set; }

        [Display(Name="Mortes")]
        [Required(ErrorMessage="Campo Obrigatório")]
        public int Death { get; set; }

        [Display(Name="Recuperados")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Recovered { get; set; }

        [Display(Name="País")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        [Display(Name="País")]
        public Country Country { get; set; }

    }
}
