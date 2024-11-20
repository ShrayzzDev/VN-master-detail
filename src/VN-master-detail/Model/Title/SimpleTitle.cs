namespace Model.Title
{
    public class SimpleTitle
    {
        public string latin { get; set; }

        public string title { get; set; }

        public SimpleTitle(string latin, string title)
        {
            this.latin = latin;
            this.title = title;
        }

        public SimpleTitle()
            : this("", "") { }
    }
}
