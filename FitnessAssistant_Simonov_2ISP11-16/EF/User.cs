//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessAssistant_Simonov_2ISP11_16.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int idUser { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public System.DateTime DateBirst { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public string idGender { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Gender Gender { get; set; }
    }
}
