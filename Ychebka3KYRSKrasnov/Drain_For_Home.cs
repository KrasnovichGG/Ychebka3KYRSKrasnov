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
    
    public partial class Drain_For_Home
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drain_For_Home()
        {
            this.Home_Drain = new HashSet<Home_Drain>();
        }
    
        public int ID_Drain { get; set; }
        public string Drain_Color { get; set; }
        public byte[] Image_Drain { get; set; }
        public Nullable<decimal> Price_Drain { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Home_Drain> Home_Drain { get; set; }
    }
}
