namespace ilis.Models;

public class PacienteSearchView
{
    public string SearchTerm { get; set; }
    public List<Paciente> Pacientes { get; set; }
}