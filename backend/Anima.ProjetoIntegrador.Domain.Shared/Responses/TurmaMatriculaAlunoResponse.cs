﻿namespace Anima.ProjetoIntegrador.Domain.Responses
{
    public class TurmaMatriculaAlunoResponse : BaseResponse
    {
        public string? IdTurma { get; set; }
        public string? NomeTurma { get; set; }
        public string? NomeProfessor { get; set; }
        public bool Matriculado { get; set; }
    }
}
