//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_420_Khurmatullin_Bulat_Samatovich.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Watcher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Watcher()
        {
            this.WatcherTournament = new HashSet<WatcherTournament>();
        }
    
        public int ID { get; set; }
        public string Login { get; set; }
        public Nullable<int> IdFavorite { get; set; }
    
        public virtual Team Team { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WatcherTournament> WatcherTournament { get; set; }
    }
}
