public class Menu
{
    public void MainMenu()
    {

        Contact contact = new();

        Console.WriteLine("Welcome to Contact App. Click Enter To Continue");
        Console.ReadLine();
        bool run = true;
        while (run)
        {
            Console.WriteLine("Pick an option below:\n1.create a contact\n2.view contacts\n3.edit contacts\n4.delete contacts\n5.exit app ".ToUpper());
            int option = 0;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("invalid input please try again");
                option = int.Parse(Console.ReadLine()!);

            }
            switch (option)
            {
                case 1:
                    ContactDetails contactDetails = new();
                    Console.WriteLine("lets create a contact for you\n please cooperate and answer these questions below");
                    Console.Write("contact name:".ToUpper());
                    contactDetails.Name = Console.ReadLine();
                    Console.Write("contact email(optional):".ToUpper());
                    string? input = Console.ReadLine();
                    contactDetails.Email = string.IsNullOrWhiteSpace(input) ? null : input;
                    Console.Write("address(opional):".ToUpper());
                    string? input2 = Console.ReadLine();
                    contactDetails.Address = string.IsNullOrWhiteSpace(input2) ? null : input2;
                    Console.Write("phone number:".ToUpper());
                    long input3;
                    while (!long.TryParse(Console.ReadLine()!, out input3))
                    {
                        Console.WriteLine("invalid phone number");
                        input3 = long.Parse(Console.ReadLine()!);

                    }
                    contactDetails.PhoneNo = input3;

                    contact.CreateContact(contactDetails);
                    break;
                case 2:

                    Console.WriteLine("your contacts will be displayed shortly");
                    contact.ReadContacts();
                    Task.Delay(300);
                    break;
                case 3:
                    ContactDetails contactDetails1 = new();
                    Console.WriteLine("howdy!! please input the contact name you want to edit");
                    string name = Console.ReadLine()!.ToLower();
                    Console.WriteLine("please provide the following info");
                    Console.Write("New Name:");
                    contactDetails1.Name = Console.ReadLine()!;
                    Console.Write("Email(optional: press enter to continue):");
                    string? newEmail = Console.ReadLine();
                    contactDetails1.Email = string.IsNullOrWhiteSpace(newEmail) ? null : newEmail;
                    Console.Write("Address(optional: press enter to continue):".ToUpper());
                    string? newAddress = Console.ReadLine();
                    contactDetails1.Address = string.IsNullOrWhiteSpace(newAddress) ? null : newAddress;
                    Console.Write("PhoneNo : ");
                    long phone;
                    while (!long.TryParse(Console.ReadLine()!, out phone))
                    {
                        Console.WriteLine("invalid phone number");
                        phone = long.Parse(Console.ReadLine()!);
                    }
                    contactDetails1.PhoneNo = phone;
                    contact.UpdateContact(name, contactDetails1);
                    Console.WriteLine("contacts has been updated successfully");
                    break;
                case 4:
                    Console.WriteLine("input the name of contact you want to delete");
                    string answer = Console.ReadLine()!.ToLower();
                    contact.DeleteContact(answer);
                    Console.WriteLine("contacts has been deleted successfully");
                    break;
                case 5:
                    run = false;
                    contact.ExitApp();
                    break;
                default:
                    Console.WriteLine("invalid option picked\npick within the range of options given ");
                    break;
            }
        }
    }
}
