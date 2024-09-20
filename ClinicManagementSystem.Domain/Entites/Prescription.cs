using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Domain.Entites
{
    public class Prescription
    {
        public int Id { get; set; }
        public string Medicine { get; set; }
        public DateOnly DatePrescribed { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
