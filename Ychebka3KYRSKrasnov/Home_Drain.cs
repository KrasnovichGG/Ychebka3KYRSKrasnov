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
    
    public partial class Home_Drain
    {
        public int ID_HDR { get; set; }
        public int ID_Drain { get; set; }
        public int ID_Home { get; set; }
    
        public virtual Drain_For_Home Drain_For_Home { get; set; }
        public virtual Home Home { get; set; }
    }
}
