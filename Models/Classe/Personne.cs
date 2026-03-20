namespace Models.Classe;

public class Personne
{
    //----------
    //PROPRIETES
    //----------
    public string Nom { get; init; }
    public string Prenom { get; init; }
    public DateTime DateNaiss { get; init; }


    //----
    //CTOR
    //----
    public Personne() //=> POUR TESTER QUE TOUT fonctionn, faire constructeur PERSONNE(ps: pas demandé dans le cours)
    {

    }
    // BONNE pratique : serait de retirer init ! 
}
