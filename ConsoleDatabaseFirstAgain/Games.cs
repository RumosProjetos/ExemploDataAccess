//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleDatabaseFirstAgain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Games
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public Nullable<int> Plataforma_Id { get; set; }
        public Nullable<int> Categoria_Id { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public Nullable<bool> Finalizado { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ConsoleGames ConsoleGames { get; set; }
        public virtual Plataforms Plataforms { get; set; }
    }
}
