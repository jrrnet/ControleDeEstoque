﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String StringDeConexao
        {
            get
            {
                return "server=CEREBRO\\SQLEXPRESS;database=ControleEstoque;user=sa;pwd=12345";
            }
        }
    }
}
