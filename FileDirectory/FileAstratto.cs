using System;
using System.Collections.Generic;
using System.Text;

namespace FileDirectory
{
    public abstract class FileAstratto
    {
        public string Nome { get; private set; }
        public Directory Padre { get; private set; }

        public FileAstratto(Directory padre, string nome)
        {
            Padre = padre;
            Nome = nome;
        }

        public abstract long GetDimensione();

        public virtual string Stampa(string tab)
        {
            return tab + Nome;
        }
    }
}
