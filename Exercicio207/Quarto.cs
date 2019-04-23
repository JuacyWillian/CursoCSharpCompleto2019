namespace Exercicio207
{
    class Quarto
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        override public string ToString()
        {
            return $"{Numero}: {Nome}, {Email}";
        }
    }
}