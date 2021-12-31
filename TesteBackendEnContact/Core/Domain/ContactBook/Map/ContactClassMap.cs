using CsvHelper.Configuration;

namespace TesteBackendEnContact.Core.Domain.ContactBook.Map
{
    public class ContactClassMap : ClassMap<Contact>
    {
        public ContactClassMap()
        {
            Map(m => m.Id).Name("id");
            Map(m => m.ContactBookId).Name("contactbookid");
            Map(m => m.Name).Name("name");
            Map(m => m.Phone).Name("phone");
            Map(m => m.Email).Name("email");
            Map(m => m.Address).Name("adress");
        }



    }
}
