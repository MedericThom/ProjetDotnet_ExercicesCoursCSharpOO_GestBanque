namespace Models
{
    public class Banque
    {
        private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();
        public string Nom { get; set; }

        public Courant this[string numero]
        {
            get => _comptes[numero];
        }

        public void Ajouter(Courant compte)
        {
            _comptes.Add(compte.Numero, compte);
        }

        public void Supprimer(string numero)
        {
            if (!_comptes.ContainsKey(numero))
                return;

            _comptes.Remove(numero);
        }
    }
}
