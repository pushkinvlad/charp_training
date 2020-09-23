namespace WebAddressbookTests
{
    public class ContactData
    {
        public ContactData(string firtsname, string lastname, string company)
        {
            this.Firstname = firtsname;
            this.Lastname = lastname;
            this.Company = company;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Company { get; set; }
    }
}
