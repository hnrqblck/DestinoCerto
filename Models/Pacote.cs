using System;

namespace DestinoCerto.Models
{
    public class Pacote
    {
        public int IdPacote{get; set;}
        public string NomePacote{get; set;}
        public DateTime Saida{get; set;}
        public DateTime Retorno{get; set;}
        public string Origem {get; set;}
        public string Destino {get; set;}
        public string Atrativos {get; set;}
        public string  Usuario {get; set;}
    }
}