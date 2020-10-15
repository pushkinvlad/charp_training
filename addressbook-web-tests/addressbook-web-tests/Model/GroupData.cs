namespace WebAddressbookTests
{
    public class GroupData
    {
        public GroupData(string name)
        {
            this.Name = name;
        }

        public GroupData(string name, string header, string footer)
        {
            this.Name = name;
            this.Header = header;
            this.Footer = footer;
        }

        public string Name { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
    }
}
