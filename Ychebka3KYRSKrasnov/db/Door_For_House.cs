//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ychebka3KYRSKrasnov.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Door_For_House
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Door_For_House()
        {
            this.Home_Door = new HashSet<Home_Door>();
        }
    
        public int ID_Door { get; set; }
        public string Door_Color { get; set; }
        public byte[] Image_Dooor { get; set; }
        public Nullable<int> Price_Door { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Home_Door> Home_Door { get; set; }
    }
}
