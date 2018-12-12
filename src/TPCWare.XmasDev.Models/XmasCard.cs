namespace TPCWare.XmasDev.Models
{
    public class XmasCard
    {
        public XmasCard() { }

        public XmasCard(int cardId, string title, string description, string url)
            => (CardId, Title, Description, Url) = (cardId, title, description, url);

        public int CardId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public override string ToString() => Title;
    }
}
