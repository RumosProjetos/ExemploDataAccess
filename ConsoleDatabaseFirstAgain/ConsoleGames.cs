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
    
    public partial class ConsoleGames
    {
        public System.Guid Id { get; set; }
        public bool MidiaFisica { get; set; }
        public string CaminhoFoto { get; set; }
    
        public virtual Games Games { get; set; }
    }
}
