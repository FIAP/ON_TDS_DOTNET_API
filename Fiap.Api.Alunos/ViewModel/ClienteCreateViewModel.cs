﻿namespace Fiap.Web.Alunos.ViewModel
{
    public class ClienteCreateViewModel
    {

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Observacao { get; set; }
        public int RepresentanteId { get; set; }

    }
}