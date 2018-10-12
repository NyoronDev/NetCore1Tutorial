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