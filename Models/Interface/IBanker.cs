using Models.Classe;

namespace Models.Interface
{
    public interface IBanker : ICustomer
    {
        string Numero { get; }
        Personne Titulaire { get; }

        void AppliquerInteret();
    }
}