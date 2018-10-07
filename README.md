# C# 6 and .Net Core 1 Tutorial
## Chapter 1 : Hello, C#! Welcome, .Net Core!
### Writing and compiling code using the Developer Command Prompt
- C# compiler converts your source code into Intermediate Language (IL) code and stores the IL in an assembly (a DLL or EXE file)
- IL code statements are like assembly language instructions, but they are executed by the .NET virtual machine known as the Common Language Runtime (CLR)
- At runtime, the CLR loads the IL code from the assembly, JIT compiles it into native CPU instructions and then it is executed by the CPU on your machine.
- The benefit of this two-step compilation process is that Microsoft can create CLRs for Linux and Mac OS X as well as for Windows. The same IL code runs everywhere because of the second compilation process that generates code for the native operating system and CPU instruction set.
