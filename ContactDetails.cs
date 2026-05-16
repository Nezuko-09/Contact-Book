public class ContactDetails
{
    public string? Name { get; set; }
    public long PhoneNo { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public int AccountBalance{get;set;}
     public string? ID {get;}
    public override string ToString()
    {
        return $"{Name},{Email},{Address},{PhoneNo}";
    }
}


