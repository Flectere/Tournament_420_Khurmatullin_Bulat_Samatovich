﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TournamentDB_420_Khurmatullin_Bulat_SamatovichEntities : DbContext
    {
        public TournamentDB_420_Khurmatullin_Bulat_SamatovichEntities()
            : base("name=TournamentDB_420_Khurmatullin_Bulat_SamatovichEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberTeam> MemberTeam { get; set; }
        public virtual DbSet<Organizator> Organizator { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Tournament> Tournament { get; set; }
        public virtual DbSet<TournamentStatistic> TournamentStatistic { get; set; }
        public virtual DbSet<TournamentTeam> TournamentTeam { get; set; }
        public virtual DbSet<Watcher> Watcher { get; set; }
        public virtual DbSet<WatcherTournament> WatcherTournament { get; set; }
    }
}
