using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoSoma.Modelo
{
    public class Controle
    {

        #region Atributos

        private String num1;
        private String num2;
        private String op;
        private String resposta;

        #endregion

        #region Construtor

        public Controle()
        {
        }
        #endregion

        #region Metodos
        public void Calcular()
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
        #endregion
            
        #region Propriedades
            try
            {
                n1 = Convert.ToDouble(num1);
                n2 = Convert.ToDouble(num2);
                if (op.Equals("+"))
                    resultado = n1 + n2;
                if (op.Equals("-"))
                    resultado = n1 - n2;
                if (op.Equals("*"))
                    resultado = n1 * n2;
                resposta = resultado.ToString();
                if (op.Equals("/"))
                    if (n2 == 0)
                        resposta = "Divisão por 0";
                    else
                    {
                        resultado = n1 / n2;
                        resposta = resultado.ToString();
                    }
            }
            catch (FormatException)
            {
                resposta = "Escreva um número correto";
            }

        }

        public String Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }



        public String Op
        {
            set { op = value; }
        }


        public String Num2
        {
            set { num2 = value; }
        }


        public String Num1
        {
            set { num1 = value; }
        }
            #endregion
    }

}
