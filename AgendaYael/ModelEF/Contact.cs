using System;
using System.Collections.Generic;

namespace AgendaYael.ModelEF;

public partial class Contact
{
    public string Prenom { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public int ContactId { get; set; }

    public string EMail { get; set; } = null!;

    public string? Adresse { get; set; }

    public int? NumeroDeTel { get; set; }

    public DateOnly DateDeNaissance { get; set; }

    public string? ResauxSociaux { get; set; }

    public virtual ICollection<ReseauxSociaux> ReseauxSociauxes { get; set; } = new List<ReseauxSociaux>();
}
