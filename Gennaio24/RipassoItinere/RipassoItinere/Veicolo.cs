﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoItinere
{
    internal class Veicolo
    {
        string marca, targa, modello;
        int codiceVeicolo;
        static int codice;
        numeroPosti posti;
        public Veicolo()
        {
            codice++;
            codiceVeicolo = codice;
        }
        static public int Code
        {
            get { return codice; }
            set { codice = value; }
        }
        public int Codice
        {
            get { return codiceVeicolo; }
            set { codiceVeicolo = value; }
        }
        public numeroPosti Posti
        {
            get { return posti; }
            set { posti = value; }
        }
        public string Targa
        {
            get { return targa; }
            set { targa = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modello
        {
            get { return modello; }
            set { modello = value; }
        }
        public override string ToString()
        {
            return string.Format($"CODICE: [{Codice}],  TARGA: [{Targa}],  MARCA: [{Marca}], MODELLO:[{Modello}], NUMERO POSTI: [{Posti}]");
        }
    }   
}
