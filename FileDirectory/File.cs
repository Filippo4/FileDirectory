using System;
using System.Collections.Generic;
using System.Text;

namespace FileDirectory
{
    public class File : FileAstratto
    {
        private long dimensione;

        public File(Directory padre, string nome, long dimensione) : base(padre, nome)
        {
            this.dimensione = dimensione;
        }

        public override long GetDimensione()
        {
            return dimensione;
        }

        public void SetDimensione(long d)
        {
            this.dimensione = d;
        }

        public override string Stampa(string tab)
        {
            return $"{base.Stampa(tab)} ({dimensione} MB)";
        }


        public string NomeSenzaEstensione
        {
            get
            {
                int i = Nome.IndexOf('.');
                return Nome.Substring(0, i);
            }
        }

        public string Estensione
        {
            get
            {
                int i = Nome.IndexOf('.');
                return Nome.Substring(i + 1);
            }
        }
    }
}
