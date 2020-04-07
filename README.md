# C# 6 and .Net Core 1 Tutorial

## Chapter 1 : Hello, C#! Welcome, .Net Core!
### Writing and compiling code using the Developer Command Prompt
- C# compiler converts your source code into Intermediate Language (IL) code and stores the IL in an assembly (a DLL or EXE file)
- IL code statements are like assembly language instructions, but they are executed by the .NET virtual machine known as the Common Language Runtime (CLR)
- At runtime, the CLR loads the IL code from the assembly, JIT compiles it into native CPU instructions and then it is executed by the CPU on your machine.
- The benefit of this two-step compilation process is that Microsoft can create CLRs for Linux and Mac OS X as well as for Windows. The same IL code runs everywhere because of the second compilation process that generates code for the native operating system and CPU instruction set.

### Visual Studio useful windows
- **C# Interactive** Writes interactive c# code.
- **Solution Explorer** Managing all the projects and files
- **Team Explorer** Source code management tools
- **Server Explorer** Managing database connections

### Understanding the .Net Portability Analyzer
- Extensions -> Online -> .Net Portability Analyzer
- Tools -> Options -> .Net Portability Analyzer -> Select all Target Platforms and then Solution -> Right click -> Analyze

### Creating a .Net Core Application
- Include statements available only when .Net Framework is available (conditional compilation symbols)
> #if DNX451
>   Console.BufferHeight = 300;
> #elseif DNXCORE50
>   // Some alternative for .Net Core
> #endif

## Chapter 2 : Speaking C#
- **Comment** - Ctrl + K + C
- **Uncomment** - Ctrl + K + U
- **Quick Replace** - Ctrl + H
- **Replace All** - Alt + A at quick replace windows
- **Autoformatting code** - Ctrl + K, D
- **Code Maid Autoformatting code** - Ctrl + M, Space
- **Go to Definition** - F12
- **Continue** - F5
- **Stop Debugging** - Shift + F5
- **Restart** - Ctrl + Shift + F5
- **Step into** - F11
- **Step over** - F10
- **Step out** - Shift + F11

### The object type
> object name = "Juan";
> int length = ((string)name).Length;

### Dynamic
- Unlike object, the value stored in the variable can have its members invoked without an explicit cast.
> dynamic anotherName = "Juan";
> int length = anotherName.Length;

### Making a value type nullable
> int? ICouldBeNull = null;

### Simplifying the usage of the console in C# 6
> using static System.Console;
> WriteLine("Hi");

## Chapter 3 : Controlling the Flow, Converting Types, and Handling Exceptions
### Selection statements
- **If Else**
- **Switch case**
>    var number = new Random().Next(1, 7);
>    switch (number)
>    {
>        case 1:
>            Console.WriteLine("One");
>            break;
>
>        case 2:
>            Console.WriteLine("Two");
>            goto case 1;
>
>        case 3:
>        case 4:
>            Console.WriteLine("Three or four");
>            goto case 1;
>
>        default:
>            Console.WriteLine("Default");
>            break;
>    }
- **While**
- **Do-While**
- **For**
- **Foreach**
> Works on any type that implements IEnumerable

### Casting from numbers to numbers
> double c = 9.8;
> int d = (int)c;

- Alternative to use cast is **System.Convert** type (can convert Booleans, strings and dates and times)
> double g = 9.8;
> int h = ToInt32(g)

### Converting from any type to a string
> int number = 12;
> Console.WriteLine(number.ToString());

### Parsing from strings to numbers or dates and times
> int age = int.Parse("27");
> DateTime birthday = DateTime.Parse("4 July 1980");

- **TryParse** - Convert the input string and returns true if it can convert it and false if it cannot.
> int count;
> string input = Console.Readline();
> if (int.TryParse(input, out count))
> {
>   Console.WriteLine($"There are {count} eggs");     
> }
> else
> {
>   Console.WriteLine("I could not parse the input.")   
> }

### The try-catch statement
- Catching all exceptions
> catch (Exception ex)

- Catching specific exceptions
> catch (FormatException)

### Finally statemet
- Ensure that some code executes regardless of whether an exception occurs or not.

### Simplifying disposal with the using statement
> using (var file = File.OpenWrite(@"c:\Code")) {}

## Chapter 4 - Using common .Net Types
### Splitting a string
> string cities = "Paris, Berlin, Madrid, New York";
> string[] citiesArray = cities.Split(',');

### Checking a string for content
> string company = "Microsoft";
> company.StartsWith("M");
> company.Contains("N");

### Other string members
- **Trim, TrimStart, and TrimEnd** - These trim whitespace characters such as spaces, tabs and new lines.
- **ToUpper and ToLower** - These convert to uppercase or lowercase.
- **Insert and Remove** - These insert or remove some text.
- **Replace** - This replaces some text.
- **String.Concat** - This concatenates two strings.
- **String.Join** - This concatenates string with a character in between each one.
- **String.IsEmptyOrNull** - This check wheter a string is empty or null.
- **String.Empty** - ("").

### Validating input with regular expressions
> var ageChecker = new Regex(@"\d"); // Digit
> ageChecker.IsMatch(input);

### The syntax of a regular expression
- **^** - Start of input
- **\d** - A single digit
- **\w** - Whitespace
- **[A - Za - z0 - 9]** - Range of characters
- **+** - One or more
- **.** - A single character
- **{3}** - Exactly three
- **{3,}** - Three or more
- **$** - End of input
- **\D** - A single NON-digit
- **\W** - NON-whitespace
- **[AEIOU]** - Set of characters
- **{3, 5}** - Three to five
- **{,3}** - Up to three

### Examples of regular expressions
- **\d** - A single digit somewhere in the input
- **a** - The a character somewhere in the input
- **Bob** - The word Bob somewhere in the input
- **^Bob** - The word Bob at the start of the input
- **^\d{2}$** - Exactly two digits
- **^[0-9]{2}$** - Exactly two digits
- **^[A-Z]{4,}$** - At least 4 uppercase letters only
- **^[A-Za-z]{4,}$** - At least 4 upper or lowercase letters only
- **^[A-Z]{2}\d{3}$** - Two uppercase letters and three digits only
- **^d.g$** - The letter d, then any character, and then the letter g, so it would match both dig and got or any character between the d and g
- **^d\.g$** - The letter d, then a dot (.), and then the letter g, so it would match d.g only

### Storing data with collections
- **System.Collections** - (Avoid this) Store any type that derives from System.Object
- **System.Collections.Generic** - Allow to specify the type you want to store

### Lists
- When you want to manually control the order of items in a collection.
- Index can change after inserting or removing items.

### Dictionaries
- Key - Value (key must be unique)

### Stacks
- Last-in - First-out (LIFO)
- Cannot access the second item in a stack

### Queues
- First-in, First-out (FIFO)

### Sets
- Perform set operations between two collections

### Sorting collections
- A List<T> class can be sorted by calling its Sort method
- Sorting a list of strings or other built-in types works automatically, but if you create a collection of your own type,
  then that type must implement an interface named IComparable.

### Interfaces
- **IEnumerable** - Can foreach, cannot add
- **ICollection** - Can add, cannot index - Implements IEnumerable
- **IList** - Implements IEnumerable and ICollection 

### Avoiding old collections
- ArrayList - Use **List<T>**
- Hashtable, HybridDictionary, ListDictionary - Use **Dictionary<TKey, TValue>**
- Stack - Use **Stack<T>**
- Queue - Use **Queue<T>**
- SortedList - Use **SortedList<T>**
- StringCollection - Use **List<string>**
- StringDictionary - Use **Dictionary<string, string>

## Chapter 5 - Using specialized .Net Types
### Debuggin toolbar
- **Continue** - F5
- **Stop Debugging** - Shift + F5
- **Restart** - Ctrl + Shift + F5
- **Step into** - F11
- **Step over** - F10
- **Step out** - Shift + F11

### Customizing breakpoints
- Right click on a breakpoint and choose additional options (Conditions)

### Writing to the default trace listener
- Output -> Debug
> Debug.WriteLine("Debug says hello");
> Trace.WriteLine("Trace says hello");

### Configuring trace listeners
-Configure two shared listeners, one that writes to a text file and another that writes to the application event log
- Inside App.config
> <system.diagnostics>
>    <sharedListeners>
>      <add name="file" type="System.Diagnostics.TextWriterTraceListener" initializeData="C:\Code\Trace.text" />
>      <add name="appeventlog" type="System.Diagnostics.EventLogTraceListener" initializeData="Application" />
>    </sharedListeners>
>    <trace autoflush="true">
>      <listeners>
>        <add name="file" />
>        <add name="appeventlog" />
>      </listeners>
>    </trace>
>  </system.diagnostics>

### Localizing an application
- Add new item -> Resources file
- Copy and paste the resource, and rename it .fr.resx to add the french version

## Chapter 6 - Building your own Types with Object-Oriented programming
### Talking about OOP
- **Encapsulation** - The combination of the data and actions that are related to an object.
> For example a BankAccount type might have data such as Balance and AccountName, as well as actions such as Deposit and Withdraw.
> When encapsulating, you often want to control what is allowed to access those data and actions.

- **Composition** - is about what an object is made of.
> For example a car is composed of different parts.

- **Aggregation** - Is about what is related to an object.
> For example a person could sit in the driver´js seat and becomes the car´s driver.

- **Inheritance** - Is about reusing code by having a subclass derive from a base or super class.
> All functionality in the base class becomes available in the derived class.

- **Abstraction** - Is about capturing the core idea of an object and ignoring the details or specifics.

- **Polymorphism** - Is about allowing a derived class to override an inherited action to provide custom behavior.

### Defining a class
- **Fields**
- **Constants** - The data in this field never changes.
- **Read-only fields** - The data in this field cannot change after the class is instantiated.
- **Events** - Methods to want to call aotomatically when something happens.

- **Methods**
- **Constructors** - Execute when you use the new keyword to allocate memory and instantiate a class.
- **Properties** - Execute when you want to control access to fields.
- **Indexers** - Execute when you want to control access to fields.
- **Operators** - Execute when you want to apply an operator.

### Defining fields
- **private** (default) - Member is accessible inside the type only
- **internal** - Member is accessible inside the type and any type in the same assembly
- **protected** - Member is accessible inside the type and any type that inherits from the type
- **internal protected** - Member is accessible inside the type, any type in the same assembly and any type that inherits from the type
- **public** - Member is accessible everywhere

### Making a field static
- Static members only has one copy, which is shared across all instances.

### Making a field constant
- If the value of a field will never change, you can use const and assign the value at compile time.
- Constants should be avoided **(better use read-only)**.

### Overloading methods
> SayHello();
> SayHello("Emily");

### Optional parameters
> public void OptionalParameters(string command = "Run");

### Defining read-only properties
- Without lambda
> public string Origin
> {
>   get
>   {
>       return $"{Name} was born";
>   }
> }

- With lambda
> public string Greeting => $"{Name} says Hello";

**See more for EventHandler**

## Chapter 7 - Implementing Interfaces and Inheriting classes
### Common Interfaces
- **IComparable** - Defines a comparison method that a type implements to order or sort its instances
CompareTo(other);

- **IComparer** - Defines a comparison method that a secondary type implements to order or sort instances of a primary type
Compare(first, second)

- **IDisposable** - Defines a disposal method to release unmanaged resources more efficiently than waiting for a finalizer
Dispose();

- **IFormattable** - Defines a culture-aware method to format the value of an object into a string representation
ToString(format, culture)

- **IFormatter** - Defines methods to convert an object to and from a stream of bytes for storage or transfer
Serialize(stream, object);
Deserialize(stream);

### Overriding members
- You can only override members if the base class chooses to allow overriding by applying the **virtual** keyword
> public override string ToString() {}

### Preventing inheritance and overriding
- You can prevent someone from inheriting from your class by applying the **sealed** keyword to its definition.
> public sealed class MrMoneyBags {}

- You can prevent someone from further overriding a method in your class by applying the **sealed** keywork to the method
> public override sealed void Sing() {}

### Polymorphism
- We can hide an inherited method using new (known as non-polymorphic inheritance) or we can override it if it is virtual (polymorphic inheritance).
> var shapes = new List<Shape>
> {
>    new Rectangle(),
>    new Triangle(),
>    new Circle()
> };
> 
> // The virtual method Draw is
> // invoked on each of the derived classes, not the base class.
> foreach (var shape in shapes)
> {
>    shape.Draw(); //Draw Rectangle, Draw Triangle, Draw Circle
> }

- Polymorphism (without new)
> public override void DoWork() {};
> 
> DerivedClass B = new DerivedClass();
> B.DoWork(); // Calls the new method
> 
> BaseClass A = (BaseClass)B;
> A.DoWork(); // Also calls the new method

- Hide new members (with new)
> public new void DoWork() {};
> DerivedClass B = new DerivedClass();
> B.DoWork(); // Calls the new method
> 
> BaseClass A = (BaseClass)B;
> A.DoWork(); // Calls the old method

### Implicit casting
- An instance of a derived type can be stored in a variable of its base type.

### Explicit casting
- Attempting to store an instance of a base type in a variable of a derived type (you must use parentheses to do it)

> Employee e2 = (Employee)aliceInPerson

### Handling casting exceptions
- We can check the current type of the object using the **is** keyword.
> if (aliceInPerson is Employee) {}

- Alternatively you can use the **as** keyword to cast (returns null if the type cannot be cast)
> Employee e3 = aliceInPerson as Employee;

### Inheriting from the Exception class
> public class BankAccountException : Exception
> {
>   public BankAccountException() : base() {}
>   public BankAccountException(string message) : base(message) {}
>   public BankAccountException(string message, Exception innerException) : base(message, innerException) {}
> }

### Using extension methods to reuse functionality
> public static class MyExtensions
> {
>   public static bool IsValidEmail(this string input) {}
> }

- With these inform the compiler that it should treat the method as a method that extends the System.String type
> string email = "a@gmail.com";
> email.IsValidEmail();

## Chapter 8 - Working with Relational Data Using the Entity Framework
### Using ADO.NET
- **ADO.NET** - This is the original .Net data access technology that has classes that inherit from abstract base classes such as DbConnection and DbDataReader.
- **ADO.NET Entity Framework** - This is a layer on top of ADO.NET that adds object-relational mapping (ORM) capabilities

### Connecting to the database
- Add System.Data.Common and System.Data.SqlClient as a Nuget packages (.Net Core)
> var connection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Northwind;Integrated Security=true;");
> connection.Open();

### See all table
> var getCategories = new SqlCommand("SELECT CategoryID, CategoryName FROM Categories", connection);
> 
> using (var reader = getCategories.ExecuteReader())
> {
>    // Find out the index positions of the columns that you want to read
>    int indexOfID = reader.GetOrdinal("CategoryID"); // Index of the column CategoryID (0)
>    int indexOfName = reader.GetOrdinal("CategoryName"); //Index of the column CategoryName (1)
> 
>    while (reader.Read())
>    {
>        // Use the typed GetXXX methods to efficiently read the column values
>        Console.WriteLine($"{reader.GetInt32(indexOfID)} : {reader.GetString(indexOfName)}");
>    }
> }

### Add new category
> var insertCategory = new SqlCommand($"INSERT INTO Categories(CategoryName) VALUES (@NewCategoryName)", connection);
> insertCategory.Parameters.AddWithValue("@NewCategoryName", category);
> 
> var rowsAffected = insertCategory.ExecuteNonQuery();
> Console.WriteLine($"{rowsAffected} row(s) where inserted.");

### Remove category
> var removeCategory = new SqlCommand($"DELETE FROM Categories WHERE CategoryName = @DeleteCategoryName", connection);
> removeCategory.Parameters.AddWithValue("@DeleteCategoryName", category);
> 
> var rowsAffected = removeCategory.ExecuteNonQuery();
> Console.WriteLine($"{rowsAffected} row(s) where deleted.");

### Entiti Framework code first conventions
- If a connection string exists with the same name as the class derived from DbContext, then it is loaded and used to connect to the database automatically.
- The name of a table is assumed to match the name of a DbSet<T> property in the DbContext class.
- The names of the columns are assumed to match the names of properties in the class.
- The string .Net type is assumed to be an nvarchar type in the database.
- The int .Net type is assumed to be an int type in the database.
- A property that is named **ID** or the name of the class has **ID** as the suffix, it is assumed to be a primary key.
- If the property is any integer type or the Guid type, then it is also assumed to be an **IDENTITY** (automatically assigned value when inserting).

### Querying an Entity Data Model
> IQueryable<Products> query = database.Products.Where(product => product.UnitPrice > price).OrderByDescending(product => product.UnitPrice);
> 
> foreach (var item in query)
> {
>   Console.WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
> }

### Logging SQL statements
- We will see all the activity happening between our application and the database, including every time a connection is opened and closed.
> database.Database.Log = new Action<string>(message => { Console.WriteLine(message); });

### Inserting entities
> var newProduct = new Products
> {
>   ProductName = "Bob Burger",
>   UnitPrice = 500M
> };
> 
> database.Products.Add(newProduct);
> 
> database.SaveChanges();

### Updating entities
> var updateProduct = database.Products.Find(78);
> updateProduct.UnitPrice += 20M;
> 
> database.SaveChanges();

### EF Transactions
- Every time you call **SaveChanges** an implicit transaction is started. If every operation succeeds, then the transaction is committed.

- Transactions are **ACID** 
- **A** is for atomic. Either all the operations in the transaction commit or none of them do.
- **C** is for consistent. The state of the database before and after a transaction is consistent.
- **I** is for isolation. During a transaction, changes are hidden from other processes. There are multiple isolation levels.
- **D** is for durable. If a failure occurs during a transaction, it can be recovered.

### Lazy loading entities
- Problem with lazy loading is that multiple round trips to the database server are required to eventually fetch all the data.
> var query = db.Categories;
> foreach (var item in query) 
> {
>   Console.WriteLine(item.CategoryName);  
> }

### Eager loading entities
- Sometimes, it´s better to disable lazy loading and manually specify that all the data is brought across the network immediately using eager loading.
> db.Configuration.LazyLoadingEnabled = false;
> var query = db.Categories.Include("Products");

### Explicit loading entities
- It works similar to lazy loading, but you are in control of exactly which related data is loaded and when.
> var products = db.Entry(item).Collection(c => if (!products.Isloaded) products.Load());

## Chapter 9 - Querying and Manipulating Data with LINQ
### Writing LINQ queries
- **Extension methods** (required) These are Where, OrderBy, Select and so on.
- **LINQ providers** (required) LINQ to Objects, LINQ to Entities, LINQ to XML, LINQ to OData, LINQ to Amazon and so on.
- **Lambda expressions** (optional) These can be used instead of named methods to simplify LINQ extension methods calls.
- **LINQ query comprehension syntax** (optional) These include from, in, where, orderby. descending, select, and so on.

### Filtering entities with Where
> private static bool NameLongerThanFour(string name)
> {
>   return name.Length > 4;
> }
> 
> var names = new string[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed" };
> var query = names.Where(new Func<string, bool>(NameLongerThanFour));
> 
> foreach (var name in query)
> {
>   Console.WriteLine(name);
> }

- You can simplify the code
> var query = names.Where(name => name.Length > 4);

### Sorting sequences with OrderBy
- Extension methods can be chained if the previous method returns another sequence, that is, a type that implements the IEnumerable<T> class.
> var query = names.Where(new Func<string, bool>(NameLongerThanFour)).OrderBy(name => name.Length);

### Sorting by multiple properties with the ThenBy method
- We might want to sort the array of names by more than one property.
> var query = names.Where(new Func<string, bool>(NameLongerThanFour)).OrderBy(name => name.Length).ThenBy(name => name);

### Projecting entities with Select statement
> var query = database.Products.Where(product => product.UnitPrice < 10M).
>   OrderByDescending(product => product.UnitPrice).
>   Select(product => new { product.ProductID, product.ProductName, product.UnitPrice });

- The sentences implement IQueryable<T> instead of IEnumerable<T>. This is an indication that we are using a LINQ provider that uses deferred execution and builds the query in memory using expressions trees.
- The query will not be executed until the last possible moment and only then will it be converted into another query language.
- Enumerating the query with foreach or calling a method such as ToArray will force immediate execution of the query.

### Joining and grouping
- Join every product to its category
> var queryJoin = categories.Join(products, category => category.CategoryID, product => product.CategoryID,
>                                 (c, p) => new { c.CategoryName, p.ProductName, p.ProductID });

- Group all products by their category to return 8 matches
> var queryGroup = categories.GroupJoin(products, category => category.CategoryID, product => product.CategoryID,
>                                        (c, Products) => new { c.CategoryName, Products });

### Creating your own LINQ extension methods
> public static IEnumerable<T> ProcessSequence<T>(this IEnumerable<T> sequence)
> {
>   return sequence;
> }

## Chapter 10 - Working with Files, Streams and Serialization
### Managing Directories
> Directory.CreateDirectory(dir);
> Directory.DeleteDirectory(dir);

### Managing Files
- Write file
> StreamWriter textWriter = File.CreateText(textFile);
> textWriter.WriteLine("Hello C#!");
> textWriter.Dispose();

- Copy a file
> File.Copy(textFile, backupFile, true);

- Read from a text file
> StreamReader textReader = File.OpenText(backupFile);
> Console.WriteLine(textReader.ReadToEnd());
> textReader.Dispose();

### Managing paths
- Path.GetFileName(textFile);
- Path.GetFileNameWithoutExtension(textFile);
- Path.GetExtension(textFile);

### Gettings file information
> var info = new FileInfo(backup);
> info.Length;
> info.LastAccessTime;
> info.IsReadOnly;

### Reading and writing with streams
- A **stream** is a sequence of bytes.

- In the following tables are some of the common members of Stream class.
- **CanRead, CanWrite** - Determines whether you can read to and write from the stream
- **Length, Position** - Determines the total number of bytes and the current position within the stream
- **Close()** - Closes the stream and releases its resources
- **Flush()** - If the stream has a buffer, then it is cleared and written to the underlying stream
- **Read()** - Reads a specified number of bytes from the stream into a byte array and advances the position
- **Seek()** - Moves the position to the specified position
- **Write()** - Writes the contents of a byte array into the stream
- **WriteByte()** - Writes a byte to the stream

- **Storage streams** The following table has examples of storage stream classes
- **FileStream** - Stored in the filesystem
- **MemoryStream** - Stored in memory in the current process
- **NetworkStream** - Stored at a network location

- **Function stream** can only be plugged onto other streams to add functionality
- **CryptoStream** - Encrypts and decrypts the stream
- **GZipStream, DeflateStream** - Compresses and decompresses the stream
- **AuthenticatedStream** - Sends credentials across the stream

- Here are some helper classes to handle common scenarios
- **StreamReader** - Reads from streams as text
- **StreamWriter** - Writes to streams as text
- **XmlReader** - Reads from streams as XML
- **XmlWriter** - Writes to streams as XML
- **BinaryReader** - Reads from streams as .Net types
- **BinaryWriter** - Writes to streams as .Net types

### Encoding text
- .Net uses a standard called **Unicode** to encode text internally

- The following table shows some alternative encodings
- **ASCII** - Encodes a limited range of characters using the lower seven bites of a byte
- **UTF-8** - Represents each Unicode code point as a sequence of one to four bytes
- **UTF-16** - Represents each Unicode code point as a sequence of one or two 16-bit integers
- **ANSI/ISO** - Provides support for a variety of code pages that are used to support a specific language

> encoder = Encoding.ASCII;
> encoder = Encoding.UTF7;
> encoder = Encoding.UTF8
> byte[] encoded = encoder.GetBytes(message);

### Encoding and decoding text in files
> var reader = new StreamReader(stream, Encoding.UTF7);
> var writer = new StreamWriter(stream, Encoding.UTF7);

## Chapter 11 - Protecting your Data and Applications
### Hashing data
- Avoid MD5 and SHA1 because they have known weaknesses. Choose a larger hash size to improve collision and primage resistance.

### Authenticating and authorizing users
- Authentication mechanisms implement a pair of interfaces: **IIdentity** and **IPrincipal**. The most common mechanism is Windows authentication.
- You can implement your own authentication mechanism using the **GenericIdentity** and **GenericPrincipal** classes.

## Chapter 12 - Improving Performance and Scalability with Multitasking
### Running multiple actions asynchronously using tasks
- Three ways to start the methods using Task instances.
> var taskA = new Task(MethodA);
> taskA.Start();
> var taskB = Task.Factory.StartNew(MethodB);
> var taskC = Task.Run(new Action(MethodC));

### Waiting for tasks
- **Wait** - Waits for this instance of the task to complete execution.
- **WaitAny** - Waits for any of the provided task objects to complete execution
- **WaitAll** - Waits for all of the provided task objects to complete execution
> Task[] tasks = { taskA, taskB, taskC };
> Task.WaitAll(tasks);

### Continuing with another task
- Simulate a call to a web service, that returns an amount that then needs to be used to retrieve how many products cost more than that amount.
> var taskCallWebServiceAndThenStoredProcedure = Task.Factory.StartNew(CallWebService).ContinueWith(previousTask => CallStoredProcedure(previousTask.Result));

### The async and await keywords

