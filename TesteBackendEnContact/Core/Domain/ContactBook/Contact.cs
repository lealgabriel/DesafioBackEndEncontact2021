using LINQtoCSV;

namespace TesteBackendEnContact.Core.Domain.ContactBook
{
    public class Contact
    {
        [CsvColumn(Name = "id", FieldIndex = 1)]
        public int Id { get;  set; }

        [CsvColumn(Name = "contactbookid", FieldIndex = 2)]
        public int ContactBookId { get;  set; }

        [CsvColumn(Name = "companyid", FieldIndex = 3)]
        public int CompanyId { get; set; }

        [CsvColumn(Name = "name", FieldIndex = 4)]
        public string Name { get; set; }

        [CsvColumn(Name = "phone", FieldIndex = 5)]
        public string Phone { get; set; }

        [CsvColumn(Name = "email", FieldIndex = 6)]
        public string Email { get; set; }

        [CsvColumn(Name = "adress", FieldIndex = 7)]
        public string Address { get; set; }

        public Contact()
        {

        }

        public Contact(int id, int contactBookId, int companyId, string name, string phone, string email, string address)
        {
            Id = id;
            ContactBookId = contactBookId;
            CompanyId = companyId;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
        }
    }
}
