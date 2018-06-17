using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace BovStickApi.Models
{
    public class Bovino
    {
        public int Id { get; set; }
        public int IdTag { get; set; }
        public int IdPiquete { get; set; }
        public int IdGestacao { get; set; }
        public string Descricao { get; set; }
        public Color cor { get; set; }
        public char Sexo { get; set; }
       


    }
   

}