
using System;
using Microsoft.AspNetCore.Mvc;

namespace DisplayTemplatesEditorTemplates.Models
{
    public class Cliente
    {
        //este modificador especifica que este campo será oculto
        [HiddenInput]
        public int Id{set;get;}
        
        public String Nombre{set;get;}
        public String Email{set;get;}
        public long Telefono{set;get;}
        public String Sexo{set;get;}
    }
}