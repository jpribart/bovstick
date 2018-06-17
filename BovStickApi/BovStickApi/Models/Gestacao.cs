using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BovStickApi.Models
{
    public class Gestacao
    {
        public int ID { get; set; }
        public int IdBovinoMae { get; set; }
        public int IdPiquete { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Previsao { get; set; }
        public DateTime Termino { get; set; }


    }
}