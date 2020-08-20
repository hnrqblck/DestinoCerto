using System;

namespace DestinoCerto.Models
{
    public class Usuario
    {
        public int IdUser{get; set;}
        public string NomeUser{get; set;}
        public DateTime DataNascimento{get; set;}
        public string Login {get; set;}
        public string Senha {get; set;}
        public int Tipo{get; set;}
        
    }
}