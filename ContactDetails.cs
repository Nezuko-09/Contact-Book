public class ContactDetails
{
    public string? Name { get; set; }
    public long PhoneNo { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }

    public override string ToString()
    {
        return $"{Name},{Email},{Address},{PhoneNo}";
    }
}


