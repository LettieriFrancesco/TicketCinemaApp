using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketCinemaApp
{
    public class Sala
    {
        public string Nome {  get; set; }
        public string Cognome { get; set; }
        public bool TicketRidotto = false;

        public Sala() { }
        public Sala(string _nome, string _cognome, bool _ticketRidotto) 
        {
            Nome = _nome;
            Cognome = _cognome;
            TicketRidotto= _ticketRidotto;
        }
    }
}