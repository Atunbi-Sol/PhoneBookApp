namespace PhoneBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, from the console phoneBook App");
            Console.WriteLine("Select operation");
            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 View all contacts");
            Console.WriteLine("4 Search for contacts for a given name");
            Console.WriteLine("5 Edit contact by number");
            Console.WriteLine("press 'X' to exit");
            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("Contact number to search");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        break;

                    case "3":
                        phoneBook.DisplayAllContact();
                        break;

                    case "4":
                        Console.WriteLine("Name search phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;

                    case "5":
                        Console.WriteLine("Contact number to edit");
                        var editNumber = Console.ReadLine();
                        var contactToEdit = phoneBook.SearchContact(editNumber);
                        if (contactToEdit == null)
                        {
                            Console.WriteLine("Contact not found");
                            break;
                        }
                        Console.WriteLine("Enter new name (leave blank to keep current value)");
                        var newName = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newName))
                        {
                            contactToEdit.Name = newName;
                        }
                        Console.WriteLine("Enter new number (leave blank to keep current value)");
                        var newNumber = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newNumber))
                        {
                            contactToEdit.Number = newNumber;
                        }
                        Console.WriteLine("Contact updated successfully");
                        break;

                    case "x":
                        return;

                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }

                Console.WriteLine("Select operation");

                userInput = Console.ReadLine();
            }
        }
    }
}