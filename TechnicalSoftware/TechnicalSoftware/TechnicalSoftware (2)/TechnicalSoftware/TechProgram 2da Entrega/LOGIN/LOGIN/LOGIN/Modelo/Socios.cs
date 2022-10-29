using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliTech.Modelo
{
    class Socios

    {
        private int id_socios;
        private string noms;
        private string apes;
        private string dirs;
        private int tels;
        private int fechanac;

        public Socios()
        {
            this.id_socios = 0;
            this.noms = "";
            this.apes = "";
            this.dirs = "";
            this.tels = 0;
            this.fechanac = 0;
        }

        public int Id_socios
        {
            get
            {
                return id_socios;
            }

            set
            {
                id_socios = value;
            }
        }

        public string Noms
        {
            get
            {
                return noms;
            }

            set
            {
                noms = value;
            }
        }

        public string Apes
        {
            get
            {
                return apes;
            }

            set
            {
                apes = value;
            }
        }

        public string Dirs
        {
            get
            {
                return dirs;
            }

            set
            {
                dirs = value;
            }
        }

        public int Tels
        {
            get
            {
                return tels;
            }

            set
            {
                tels = value;
            }
        }

        public int Fechanac
        {
            get
            {
                return fechanac;
            }

            set
            {
                fechanac = value;
            }
        }
    }

    }
