//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TutorN5.Models.reis.aprendizagem.aulas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pergunta
    {
        public int Id { get; set; }
        public string Pergunta1 { get; set; }
        public Nullable<int> TimeStamp { get; set; }
        public string Resposta { get; set; }
        public Nullable<int> Aula { get; set; }
        public string FonteExtra { get; set; }
        public string FalaExtra { get; set; }
    }
}
