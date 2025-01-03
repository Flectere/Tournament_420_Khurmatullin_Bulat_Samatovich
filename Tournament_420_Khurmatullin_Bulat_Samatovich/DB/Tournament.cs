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
    
    public partial class Tournament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tournament()
        {
            this.TournamentStatistic = new HashSet<TournamentStatistic>();
            this.TournamentTeam = new HashSet<TournamentTeam>();
            this.WatcherTournament = new HashSet<WatcherTournament>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Game { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Fond { get; set; }
        public Nullable<int> IdStatus { get; set; }
        public Nullable<int> IdOrganizator { get; set; }
    
        public virtual Organizator Organizator { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TournamentStatistic> TournamentStatistic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TournamentTeam> TournamentTeam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WatcherTournament> WatcherTournament { get; set; }
    }
}
