using System;
using System.Collections.Generic;

namespace AgendaYael.ModelEF;

public partial class Todolist
{
    public int Id { get; set; }

    public string? Statut { get; set; }

    public string? Taches { get; set; }

    public DateOnly? Date { get; set; }

    public string? Priorite { get; set; }
}
