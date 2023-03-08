using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijeSpremanje
{
    internal class Osoba
    {
        string ime, prezime, email;
        int godRod;

        public Osoba(string ime, string prezime, string email, int godRod)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.godRod = godRod;
        }

        public override string ToString()
        {
            string ispis = "Ime: " + this.ime +
                " Prezime: " + this.prezime +
                " Email: " + this.email +
                " Godia Rođenja: " + this.godRod;



            return base.ToString();
        }
    }
}
