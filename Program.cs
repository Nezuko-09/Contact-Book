// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Menu menu = new();
menu.MainMenu();

var aList = new List<int>();
aList = [9, 1, 2, 4, 5, 6, 78, 74,];


var firstContact = new ContactDetails() { Name = "Mr A", Email = "mra@somemail.com", Address = "somewhere", PhoneNo = 12345678, AccountBalance = 5000 };
var secondContact = new ContactDetails() { Name = "Mr B", Email = "mrb@somemail.com", Address = "nowhere", PhoneNo = 87654321, AccountBalance = 97000 };
var thirdContact = new ContactDetails() { Name = "Mr C", Email = "mrc@somemail.com", Address = "anywhere", PhoneNo = 56781234, AccountBalance = -4000 };
var fourthContact = new ContactDetails() { Name = "Ms D", Email = "msd@somemail.com", Address = "Oak Street 12", PhoneNo = 67891234, AccountBalance = 2500 };
var fifthContact = new ContactDetails() { Name = "Dr E", Email = "dre@somemail.com", Address = "Maple Avenue", PhoneNo = 78912345, AccountBalance = 0 };
var sixthContact = new ContactDetails() { Name = "Mrs F", Email = "mrsf@somemail.com", Address = "Green Hills", PhoneNo = 89123456, AccountBalance = -1500 };
var seventhContact = new ContactDetails() { Name = "Mr G", Email = "mrg@somemail.com", Address = "Sunset Boulevard", PhoneNo = 91234567, AccountBalance = 7200 };
var eighthContact = new ContactDetails() { Name = "Miss H", Email = "missh@somemail.com", Address = "Riverbank Close", PhoneNo = 12345678, AccountBalance = 310000 };
var ninthContact = new ContactDetails() { Name = "Chief I", Email = "chiefi@somemail.com", Address = "Hilltop Estate", PhoneNo = 23456789, AccountBalance = -980 };
var tenthContact = new ContactDetails() { Name = "Prof J", Email = "profj@somemail.com", Address = "Palm Drive", PhoneNo = 34567890, AccountBalance = 1500000 };
var contactList = new List<ContactDetails>();

contactList.AddRange([firstContact, secondContact, thirdContact, fourthContact, fifthContact, sixthContact, seventhContact, eighthContact, ninthContact, tenthContact]);

var linqQuery = contactList.Find(x => x.AccountBalance <= 0);
var anotherLinqQuery = contactList.Where(x => x.AccountBalance < 0);


var debtorsList = anotherLinqQuery.ToList();

if (linqQuery is null)
{
    Console.WriteLine("Unable to find your value");
    return;
}

foreach (var contact in anotherLinqQuery)
{
    Console.WriteLine($"Name: {contact.Name}");
    Console.WriteLine($"Address: {contact.Address}");
    Console.WriteLine($"Phone no: {contact.PhoneNo}");
    Console.WriteLine($"Account balance: {contact.AccountBalance}");
    Console.WriteLine("--------------------");
}

//use linq queries to search contacts in your contact assignment
//use first, find, first or default, where
// add ID to the contact details
// delete by Id
//do a view contact by Id
//do update by Id
