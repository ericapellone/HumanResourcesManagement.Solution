﻿namespace HumanResourcesManagementAPI.Models
{
    public class TitoloDiStudio : AggregateRoot
    {
        public string? Descrizione { get; set; }
        public virtual ICollection<TitoloDiStudioCandidato> TitoliDiStudioCandidato { get; set; }
    }
}
