//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _24052021AgendaConsulta
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_CONSULTA
    {
        internal int id;

        public int id_consulta { get; set; }
        public string horario { get; set; }
        public Nullable<int> id_paciente { get; set; }
    
        public virtual TB_PACIENTE TB_PACIENTE { get; set; }
    }
}
