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
    
    public partial class TournamentStatistic
    {
        public int ID { get; set; }
        public Nullable<int> IdTournament { get; set; }
        public Nullable<int> CountMatch { get; set; }
        public Nullable<int> IdBest { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
