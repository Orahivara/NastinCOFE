//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NastinCOFE.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int IDUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string IDGender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<int> IDUserType { get; set; }
        public string Patronimic { get; set; }
    
        public virtual Check Check { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual UserType UserType { get; set; }
    }
}