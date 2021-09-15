using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mc3s.Odos.Domain.Northwind
{
    partial class Patient
    {

        public Patient() { }

        public Patient(IEnumerable<PatientRecord> patientRecords, bool active, Physician physician)
        {
            this.active = active;
            this.physician = physician;
            foreach (var record in this.patientRecords)
            {
                this.patientRecords.Add(record);
            }
            foreach (var record in this.patientRecords)
            {
                record.Patient = this;
            }
        }
    }
}
