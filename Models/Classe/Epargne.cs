namespace Models.Classe;

public class Epargne : Compte
{
    //----------
    //PROPRIETES
    //----------
    public DateTime DernierRetrait { get; private set; }


    //----
    //CTOR
    //----
    public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
    {

    }


    //--------
    //METHODES
    //--------
    public override void Retrait(double montant)
    {
        double oldSolde = Solde;
        base.Retrait(montant);

        if (Solde != oldSolde)
        {
            DernierRetrait = DateTime.Now;
        }
    }

    protected override double CalculInteret()
    {
        return Solde * 0.045;
    }
}
