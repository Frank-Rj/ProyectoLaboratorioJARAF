//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_LaboratorioJARAF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CITAS
    {
        public int IdCita { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int IdExamenes { get; set; }
        public int IdPaciente { get; set; }
    
        public virtual EXAMENES EXAMENES { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
