using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailprofilerTestApp
{
    class Vyrobek
    {
        public string ID { get; set; }
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public string Poznamka { get; set; }
        public string Cena { get; set; }
        public string Zalozeno { get; set; }
        public string Upraveno { get; set; }
        public string PocetDilu { get; set; }

        public Vyrobek(string iD, string name, string description, string note, string price, string created, string lastEdited, string numOfParts)
        {
            ID = iD;
            this.Nazev = name;
            this.Popis = description;
            this.Poznamka = note;
            this.Cena = price;
            this.Zalozeno = created;
            this.Upraveno = lastEdited;
            this.PocetDilu = numOfParts;
        }
    }
}
