using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mod3_ativ1.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
