namespace Exercicio207
{
    class Pensao
    {
        private Quarto[] Quartos = new Quarto[10];

        public void AlugarQuarto(int numero, string nome, string email)
        {
            Quartos[numero] = new Quarto()
            {
                Numero = numero,
                Nome = nome,
                Email = email
            };
        }

        override public string ToString()
        {
            string msg = "";
            foreach (var q in Quartos)
            {
                if (q != null)
                {
                    msg += q.ToString() + "\n";
                }
            }

            return msg;
        }
    }
}
