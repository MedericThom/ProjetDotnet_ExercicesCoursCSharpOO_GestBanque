using Models.Interface;

namespace Models.Classe
{
    public abstract class Compte : ICustomer, IBanker
    {
        //----------
        //PROPRIETES
        //----------
        public string Numero { get; private set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; private set; }

        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Montant invalide");
                return; //Erreur!!!
            }

            Solde += montant;
        }


        //----
        //CTOR
        //----
        protected Compte(string numero, Personne titulaire) //Protected CAR classe ABSTRACT !!!!
        {
            this.Numero = numero;
            this.Titulaire = titulaire;
        }

        protected Compte(string numero, Personne titulaire, double solde) //Cas base de données
        {
            this.Numero = numero;
            this.Titulaire = titulaire;
            this.Solde = solde;
        }


        //--------
        //METHODES
        //--------
        public static double operator +(double value, Compte compte)
        {
            return (value < 0 ? 0 : value) + (compte.Solde < 0 ? 0 : compte.Solde);
        }

        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0D);
        }

        protected void Retrait(double montant, double ligneDeCredit)
        {
            if (ligneDeCredit < 0)
            {
                Console.WriteLine("Ligne de crédit invalide");
                return; //Erreur!!!
            }

            if (montant <= 0)
            {
                Console.WriteLine("Montant invalide");
                return; //Erreur!!!
            }

            if (Solde - montant < -ligneDeCredit)
            {
                Console.WriteLine("Solde insuffisant");
                return; //Erreur!!!
            }

            Solde -= montant;
        }

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        protected abstract double CalculInteret();

    }
}