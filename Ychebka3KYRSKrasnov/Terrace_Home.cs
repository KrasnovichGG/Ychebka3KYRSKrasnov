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
    
    public partial class Terrace_Home
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Terrace_Home()
        {
            this.Home = new HashSet<Home>();
        }
    
        public int ID_Terrace { get; set; }
        public string Material_Terrace { get; set; }
        public byte[] Image_Terrace { get; set; }
        public Nullable<decimal> Price_Terrace { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Home> Home { get; set; }
    }
}