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
    
    public partial class TB_PACIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_PACIENTE()
        {
            this.TB_CONSULTA = new HashSet<TB_CONSULTA>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CONSULTA> TB_CONSULTA { get; set; }
    }
}
