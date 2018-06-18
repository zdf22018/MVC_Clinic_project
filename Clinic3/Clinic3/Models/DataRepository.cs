using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinic3.Models
{
    public class DataRepository
    {
        ModelClinic context = new ModelClinic();
             
        //get all the patient records
        public List<patient> getAllPatients()
        {
            return (from p in context.patients select p).ToList();
        }

        // get a single doctor
        public doctor getDoctorById (int Id)
        {
            var doctor =(from d in context.doctors where d.Id == Id select d).SingleOrDefault();
            return doctor;
        }

        // display doctors' schedules
        public List<doctor_schedule> getDoctorSchedule (int id)
        {
            var doctorS = (from s in context.doctor_schedule where s.DoctorId == id select s).ToList();
            return doctorS;
        }
        // Add Availability
        public void AddAvailability()
        {

        }


    }
}