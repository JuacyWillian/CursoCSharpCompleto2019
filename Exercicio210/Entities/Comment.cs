namespace Exercicio210.Entities
{
    public class Comment
    {
        public string Text { get; set; }
        public Comment(string text)
        {
            Text = text;
        }
    }
}