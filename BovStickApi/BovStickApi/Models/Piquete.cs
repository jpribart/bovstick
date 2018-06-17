using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BovStickApi.Models
{
    public class Piquete
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Alqueiro { get; set; }
        public EstadoPiquete estado { get; set; }
      

    }
    public enum EstadoPiquete
    {
        Verde =0,
        amarelo =1,
        vermelho =2
    }

}