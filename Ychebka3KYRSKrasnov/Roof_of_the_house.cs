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
    
    public partial class Roof_of_the_house
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Roof_of_the_house()
        {
            this.Home_Roof = new HashSet<Home_Roof>();
        }
    
        public int ID_Roof { get; set; }
        public string Roof_Color { get; set; }
        public byte[] Image_Roof { get; set; }
        public Nullable<decimal> Price_Roof { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Home_Roof> Home_Roof { get; set; }
    }
}
