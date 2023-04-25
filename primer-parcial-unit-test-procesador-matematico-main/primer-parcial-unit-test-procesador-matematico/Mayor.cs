using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_unit_test_procesador_matematico
{
    public class Mayor
    {
        int resultado;
        public int CalcularMayor(int primerNumero, int segundoNumero)
        {
            if (primerNumero > segundoNumero)
            {
                this.resultado = primerNumero;
            }
            else if (primerNumero < segundoNumero)
            {
                this.resultado = segundoNumero;
            }
            else
            {
                this.resultado = segundoNumero;
            }

            return resultado;
        }
    }
}
