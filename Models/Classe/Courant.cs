namespace Models.Classe;

public class Courant : Compte
{
    //----------
    //PROPRIETES
    //----------
    private double _ligneDeCredit;
    public double LigneDeCredit
    {
        get { return _ligneDeCredit; }
        set
        {
            if (value < 0)
                return; //Erreur!!!

            _ligneDeCredit = value;
        }
    }


    //public Courant(string numero, Personne titulaire,double ligneDeCredit) :base(numero, titulaire)
    //{
    //    this.LigneDeCredit = ligneDeCredit; 
    //}

    //--------
    //METHODES
    //--------
    public override void Retrait(double montant)
    {
        Retrait(montant, LigneDeCredit);
    }

    protected override double CalculInteret()
    {
        return Solde * (Solde > 0 ? 0.03 : 0.0975);
    }
}
