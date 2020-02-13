using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudicMarinProvjeraZnanja4
{
    public class Student
    {
        private string ime;
        private string prezime;
        private string brojIndexa;
        private DateTime datumRodjenja;
        public Student()
        {

        }
        public string Ime()
        {
            get 
            {
                return ime;
            };
            set
            {
                ime = value;
            };
        }
        public string Prezime()
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }
        public string BrojIndexa()
        {
            get
            {
                return brojIndexa;
            }
            set
            {
                brojIndexa = value;
            }
        }
        public DateTime DatumRođenja()
        {
            get
            {
                return datumRodjenja;
            };
            set
            {
                datumRodjenja = value;
            };
        }
    }
}
    
    


