using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula08.Models
{
    public enum Marca
    {
        VW, Ford, Honda
    }
    public enum Combustivel
    {
        Flex, Etanol, Gasolina, Diesel, Gas
    }
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        public Marca Marca { get; set; }
        public string Modelo { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
        [DisplayName("Preço")]
        public decimal Preco { get; set; }
        public string Estado { get; set; }
        public Combustivel Combustivel { get; set; }
        public bool Publicar { get; set; }
    }
}