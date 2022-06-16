using System;

namespace Modulo2Semana3 {
    public class Pessoa {
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

        public int Idade() {
            int idade = DateTime.Now.Year - DataNascimento.Year;
            if (DateTime.Now.Month < DataNascimento.Month || (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day)) {
                idade--;
            }
            return idade;
        }
    }
}
