using System;
using System.ComponentModel.DataAnnotations;
using POLICLINICA_HOPE_.Models;

public class Programare
{
    public int ProgramareId { get; set; }
    [Required]
    public DateTime Data { get; set; }
    [Required]
    public TimeSpan Ora { get; set; }
    [Required]
    public int PacientId { get; set; }
    public Pacient Pacient { get; set; }
    public int DepartamentId { get; set; }
    public Departament Departament { get; set; }
}
