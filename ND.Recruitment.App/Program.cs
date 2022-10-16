using ND.Recruitment.Domain;

if (args.Length > 1 || args[0].Length > 1)
{
    Console.Error.WriteLine("Invalid input. Pass only one character.");
    Environment.Exit(1);
}

try
{
    Console.Write(new Diamond(args[0][0]));
}
catch (ArgumentOutOfRangeException exception)
{
    Console.Error.WriteLine(exception.Message);
    Environment.Exit(1);
}
catch (Exception)
{
    Console.Error.WriteLine("Unexpected error.");
    Environment.Exit(1);
}