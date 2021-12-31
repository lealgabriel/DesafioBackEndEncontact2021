namespace TesteBackendEnContact.Core.Domain.ContactBook
{
    public class Company
    {
        public int Id { get; set; }
        public int ContactBookId { get; set; }
        public string Name { get; set; }

        public Company(int id, int contactBookId, string name)
        {
            Id = id;
            ContactBookId = contactBookId;
            Name = name;
        }
    }
}
