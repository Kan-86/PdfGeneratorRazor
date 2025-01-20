using Bogus;

namespace PDFGenConsole.Invoices;
public class InvoiceGenerator
{
    public static Invoice Generate()
    {
        var faker = new Faker();

        var invoice = new Invoice
        {

            Number = faker.Random.Number(1000, 9999).ToString(),
            IssueDate = faker.Date.SoonDateOnly(0),
            DueDate = faker.Date.SoonDateOnly(0).AddMonths(1),
            CustomerAddress = new Address
            {
                CompanyName = "ABC Inc.",
                Street = "123 Main St.",
                City = "Springfield",
                PostalCode = "12345",
                Country = "USA",
                Phone = faker.Phone.PhoneNumber(),
                Email = faker.Internet.Email(),
            },
            SellerAddress = new Address
            {
                CompanyName = "ABC Inc.",
                Street = "123 Main St.",
                City = "Springfield",
                PostalCode = "12345",
                Country = "USA",
                Phone = faker.Phone.PhoneNumber(),
                Email = faker.Internet.Email(),
            },
            Items = new List<OrderItem>
            {
                new OrderItem
                {
                    Name = "Widget",
                    Price = 9.99m,
                    Quantity = 10
                },
                new OrderItem
                {
                    Name = "Gadget",
                    Price = 19.99m,
                    Quantity = 5
                }
            },
        };
        return invoice;
    }
}
