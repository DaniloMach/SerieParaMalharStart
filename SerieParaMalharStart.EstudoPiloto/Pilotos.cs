using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.EstudoPiloto
{
    internal class Pilotos
    {
        /*
         * Propriedade automatica
         * encapsulamento
         * ser get
         * Propriedade e Privada
         * get e set é Publico
         * Encapsulamento
         */
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string GerarNomeCompletoMaiuculo()
        {
            return $"{Nome}{Sobrenome}".ToUpper();
        }
        public string GerarNomeCompletoMinusculo()
        {
            return $"{Nome}{Sobrenome}".ToLower();

        }

    }
}
