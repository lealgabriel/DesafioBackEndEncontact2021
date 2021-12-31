namespace TesteBackendEnContact.Core.Domain.ContactBook
{
    public class ContactBook
    {
        public int Id { get;  set; }
        public string Name { get;  set; }

        public ContactBook(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
