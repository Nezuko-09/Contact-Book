public class Contact
{
    public string desktopPath;
    public string folderPath;
    public Contact()
    {
        desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        folderPath = Path.Combine(desktopPath, "ContactBook");
        Directory.CreateDirectory(folderPath);
    }
    public string CreateContact(ContactDetails contactDetails)
    {
        string fileName = Path.Combine(folderPath, "Contacts.txt");
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine(contactDetails.ToString());
        }
        return "contacts has been created successfully. yay!!".ToUpper();
    }
    public void ReadContacts()
    {
        string fileName = Path.Combine(folderPath, "Contacts.txt");
         if(!File.Exists(fileName))
        {
            Console.WriteLine("no contact file found");
        }
        List<string> viewedContact = File.ReadAllLines(fileName).ToList();
       
        if(viewedContact.Count == 0)
        {
            Console.WriteLine("there are no contacts in your contact book");
        }
        foreach (var contact in viewedContact)
        {
            Console.WriteLine(contact);
        }
    }
    public void UpdateContact(string oldname,ContactDetails contactDetails)
    {
        string fileName = Path.Combine(folderPath, "Contacts.txt");
        List<string> contacts = File.ReadAllLines(fileName).ToList();
          if (contacts.Count == 0)
        {
            Console.WriteLine("you currently have no contacts");
        }
        var indexOfContact = contacts.FindIndex(c => c.StartsWith(oldname + ","));
        if (indexOfContact != -1)
        {
            contacts[indexOfContact] = contactDetails.ToString();
            using (StreamWriter writer = new StreamWriter(fileName,false))
            {
                foreach(var contact in contacts)
                {
                writer.WriteLine(contact);
                }
            }
            
        }
        else
        {
            Console.WriteLine("contact doesnt exist");
        }

    }
    public void DeleteContact(string name)
    {
        string fileName = Path.Combine(folderPath,"Contacts.txt");
         List<string> contacts = File.ReadAllLines(fileName).ToList();
         if (contacts.Count == 0)
        {
            Console.WriteLine("you currently have no contacts");
        }
         int indexOfContact = contacts.FindIndex(c => c.StartsWith(name + ","));
        if(indexOfContact != -1)
        {
            contacts.RemoveAt(indexOfContact);
            using (StreamWriter writer = new StreamWriter(fileName,false))
            {
                foreach(var contact in contacts)
                {
                writer.WriteLine(contact);
                }
            }
            
        }
        else
        {
            Console.WriteLine("this contact doesnt exist".ToUpper());
           
        }
    }
    public void ExitApp()
    {
        Console.WriteLine("thanks for using this app\ncome back for more lovely experiences and i hope you love it\nensure to rate it well\n....exiting.....".ToUpper().Trim());
    }
}