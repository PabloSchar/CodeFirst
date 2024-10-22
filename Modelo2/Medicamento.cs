using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo2
{
    public class Medicamento
    {
        public int MedicamentoId { get; set; }
        public string NombreComercial { get; set; }
        public bool EsVentaLibre {  get; set; }
        public decimal PrecioVenta {  get; set; }
        public int Stock {  get; set; }
        public int StockMinimo { get; set; }

        public int MonodrogaId { get; set; }
        public Monodroga Monodroga { get; set; }

        public List<Drogueria> Droguerias { get; set; } = new List<Drogueria> ();

        

        public bool AgregarDrogueria(Drogueria drogueria)
        {
            var existeDrogueria = Droguerias.FirstOrDefault(c => c.Cuit == drogueria.Cuit);
            if (existeDrogueria == null)
            {
                Droguerias.Add(drogueria);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarDrogueria(Drogueria drogueria)
        {
            var existeDrogueria = Droguerias.FirstOrDefault(c => c.Cuit == drogueria.Cuit);
            if (existeDrogueria != null)
            {
                Droguerias.Remove(drogueria);
                return true;
            }
            else
            {
                return false;
            }
        }

      
    }
}
