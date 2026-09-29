namespace AgendaContato.ArquivoClasses
{
    public class Contato
    {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }

        public Contato () { }

        public bool TentarDefinirNome(string nomeDigitado)
        {
            if (string.IsNullOrEmpty(nomeDigitado)) return false;

            nomeDigitado = nomeDigitado.Trim().ToLower();

            if (!nomeDigitado.All(c => char.IsLetter(c) || c == ' ' || c == '-' || c == '\''))
                return false;

            string[] excecoes = { "da", "de", "do", "das", "dos", "e" };

            string[] palavras = nomeDigitado.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < palavras.Length; i++)
            {
                string palavraAtual = palavras[i];

                if (excecoes.Contains(palavraAtual) && i > 0)
                {
                    palavras[i] = palavraAtual;
                }
                else
                {
                    palavras[i] = char.ToUpper(palavraAtual[0]) + palavraAtual.Substring(1);
                }
            }

            Nome = string.Join(" ", palavras);
            return true;
        }

        public bool TentarDefinirTelefone(string telefoneDigitado)
        {
            if (string.IsNullOrEmpty(telefoneDigitado)) return false;

            string apenasNumeros = telefoneDigitado.Replace(" ", "").Replace("-", "");

            if (!apenasNumeros.All(c => char.IsDigit(c))) return false;

            if (apenasNumeros.Length != 10 && apenasNumeros.Length != 11)
                return false;

            string ddd = apenasNumeros.Substring(0, 2);

            if (apenasNumeros.Length == 10)
            {
                string primeiraParte = apenasNumeros.Substring(2, 4);

                string segundaParte = apenasNumeros.Substring(6, 4);

                Telefone = $"({ddd}) {primeiraParte}-{segundaParte}";
            }

            if (apenasNumeros.Length == 11)
            {
                string primeiraParte = apenasNumeros.Substring(2, 5);

                string segundaParte = apenasNumeros.Substring(7, 4);

                Telefone = $"({ddd}) {primeiraParte}-{segundaParte}";
            }
            
            return true;
        }
        
    }
}
