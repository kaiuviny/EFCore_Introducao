using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Introducao.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
    }
}
