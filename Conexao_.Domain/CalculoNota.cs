using System;
using System.Collections.Generic;
using System.Text;

namespace Conexao_.Domain
{
    interface ICalculoNota
    {
        decimal Calcular(decimal n1, decimal n2, decimal n3);

        bool VerificarAprovacao();

        public bool CalculaMedia(decimal n1, decimal n2, decimal n3)
        {
            decimal media = (n1 + n2 + n3) / 3;


            if (media >= 6)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
