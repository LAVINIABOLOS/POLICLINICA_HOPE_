using POLICLINICA_HOPE_.Models;

public class Procedura
{
    public int ProceduraId { get; set; }
    public string Denumire { get; set; }
    public string Descriere { get; set; }
    public int Pret { get; set; }
    public int MedicId { get; set; }
    public Medic Medic { get; set; }
    public int DepartamentId { get; set; }
    public Departament Departament { get; set; }
}
