//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ychebka3KYRSKrasnov
{
    using System;
    using System.Collections.Generic;
    
    public partial class Home_Solution
    {
        public int ID_HS { get; set; }
        public int ID_Solution { get; set; }
        public int ID_Home { get; set; }
    
        public virtual Home Home { get; set; }
        public virtual Turnkey_solution_for_home Turnkey_solution_for_home { get; set; }
    }
}
