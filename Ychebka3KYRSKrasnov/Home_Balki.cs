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
    
    public partial class Home_Balki
    {
        public int ID_HB { get; set; }
        public int ID_Balka { get; set; }
        public int ID_Home { get; set; }
    
        public virtual Balki_House Balki_House { get; set; }
        public virtual Home Home { get; set; }
    }
}