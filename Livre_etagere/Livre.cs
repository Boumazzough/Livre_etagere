using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Livre_etagere
{
    class Livre
    {
        private String code;
        private String titre;
        private Double prix;
        private string Nb_etagere;

        public string Code { get => code; set => code = value; }
        public string Titre { get => titre; set => titre = value; }
        public double Prix { get => prix; set => prix = value; }
        public string Nb_etagere1 { get => Nb_etagere; set => Nb_etagere = value; }

        public Livre(String code,String titre,Double prix,string Nb_etagere)
        {
            this.Code = code;
            this.Nb_etagere = Nb_etagere;
            if (titre.Length >= 4)
            { this.titre = titre; }
            else
            { 
                throw new MonException("le titre doit avoir au moins 4 caracteres"); 
            }
            if (prix > 0)
                this.prix = prix;
            else
            {
                throw new MonException("le prix doit etre >0");
            }
        }
        public override string ToString()
        {
            return "code: " + Code + "titre: " + Titre + "prix: " + Prix;
        }

    }
}
