using System;
using System.Collections.Generic;

namespace ApiInGames.Domains
{
    public partial class Jogo
    {
        public int IdJogo { get; set; }
        public string NomeJogo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeLancamento { get; set; }
        public decimal Valor { get; set; }
        public int? IdEstudio { get; set; }

        public Estudio IdEstudioNavigation { get; set; }
    }
}
