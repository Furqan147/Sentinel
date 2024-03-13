namespace Station.Domain.ValueObjects
{
    public class StationAddress
    {
        public string StreetAddress { get; private set; } = default!;
        public string City { get; private set; } = default!;
        public string StateOrProvince { get; private set; } = default!;
        public string PostalCode { get; private set; } = default!;
    }
}
