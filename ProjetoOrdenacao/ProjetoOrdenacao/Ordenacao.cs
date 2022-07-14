﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProjetoOrdenacao
{
    public class Ordenacao
    {
        public int[] trocaPosicao(int a, int b)
        {
            int troca = a;
            a = b;
            b = troca;

            int[] valores = new int[] { a, b };

            return valores;
        }

        public int[] trocaPosicaoManual(int a, int b)
        {
            int troca = a;
            a = b;
            b = troca;

            int[] valores = new int[2];
            valores[0] = a;
            valores[1] = b;

            return valores;

        }

        public int[] OrdemCrescente (int[] valores)
        {
            int troca = 0;

            for(int i = 0; i < valores.Length; i++)
            {
                for(int x = i+1; x<valores.Length; x++)
                {
                    if(valores[i] > valores[x])
                    {
                        troca = valores[i];
                        valores[i] = valores[x];
                        valores[x] = troca;

                    }
                }
            }
            return valores;
        }
    }
}
