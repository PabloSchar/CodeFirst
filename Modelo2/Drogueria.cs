namespace Modelo2
{
    public class Drogueria
    {
        public int DrogueriaId { get; set; }
        public long Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        public List<Medicamento> Medicamentos { get; set;}
    }
}
