//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExemploDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telefone
    {
        public int Id { get; set; }
        public string NumeroTelefone { get; set; }
        public Nullable<int> AlunoId { get; set; }
        public string Prefixo { get; set; }
    
        public virtual Aluno Aluno { get; set; }
    }
}