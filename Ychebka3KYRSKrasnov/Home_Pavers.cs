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
    
    public partial class Home_Pavers
    {
        public int ID_HP { get; set; }
        public int ID_Pavers { get; set; }
        public int ID_Home { get; set; }
    
        public virtual Home Home { get; set; }
        public virtual Pavers_House Pavers_House { get; set; }
    }
}
