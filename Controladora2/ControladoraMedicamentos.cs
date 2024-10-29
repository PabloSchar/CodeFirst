using Microsoft.EntityFrameworkCore;
using Modelo2;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora2
{
    public class ControladoraMedicamentos
    {
        private BloggingContext db;

        public ControladoraMedicamentos() 
        {
            db = new BloggingContext();
        }

        public bool AgregarMedicamento(Medicamento medicamento)
        {
            try
            {
                var existeMedicamento = db.Medicamentos.FirstOrDefault(c => c.NombreComercial == medicamento.NombreComercial);
                if (existeMedicamento == null)
                {
                    db.Medicamentos.Add(medicamento);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ModificarMedicamento(Medicamento medicamento)
        {
            try
            {
                var existeMedicamento = db.Medicamentos.FirstOrDefault(c => c.NombreComercial == medicamento.NombreComercial);
                if (existeMedicamento != null)
                {
                    db.Medicamentos.Update(medicamento);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarMedicamento(Medicamento medicamento)
        {
            try
            {
                var existeMedicamento = db.Medicamentos.FirstOrDefault(c => c.NombreComercial == medicamento.NombreComercial);
                if (existeMedicamento != null)
                {
                    db.Medicamentos.Remove(medicamento);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public ReadOnlyCollection<Medicamento> RecuperarMedicamentos()
        {
            try
            {
                return db.Medicamentos.Include("Droguerias").ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Medicamento>(new List<Medicamento>());
            }
        }

        public ReadOnlyCollection<Drogueria> RecuperarDroguerias()
        {
            try
            {
                return db.Droguerias.ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Drogueria>(new List<Drogueria>());
            }
        }

        public ReadOnlyCollection<Monodroga> RecuperarMonodrogas()
        {
            try
            {
                return db.Monodrogas.ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Monodroga>(new List<Monodroga>());
            }
        }
    }
}
