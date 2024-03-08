using System;
using System.Collections.Generic;

namespace AgendaYael.ModelEF;

public partial class ReseauxSociaux
{
    public int ReseauxtId { get; set; }

    public int ContactsContactId { get; set; }

    public string? ReseauxNom { get; set; }

    public string? ReseauxLink { get; set; }

    public virtual Contact ContactsContact { get; set; } = null!;
}
