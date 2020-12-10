using System;

namespace FileDirectory
{
    public class Directory : FileAstratto
    {
        private List<FileAstratto> figli = new List<FileAstratto>();

        public Directory(Directory padre, string nome) : base(padre, nome) { }

        public void AddFile(FileAstratto f)
        {
            figli.Add(f);
        }

        public override long GetDimensione()
        {
            long d = 0;
            foreach (FileAstratto f in figli)
            {
                d += f.GetDimensione();
            }
            return d;
        }

        public override string Stampa(string tab)
        {
            string s = base.Stampa(tab);
            foreach (FileAstratto f in figli)
            {
                s += "\n" + f.Stampa(tab + "|--");
            }
            return s;
        }
    }
}
