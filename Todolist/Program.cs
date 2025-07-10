Console.WriteLine("Hello world!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODO's");
Console.WriteLine("[A]dd all TODO's");
Console.WriteLine("[R]emove all TODO's");
Console.WriteLine("[E]xit");

//Boolean Operators

var userchoice = Console.ReadLine();
bool isuserinput = userchoice == "ABC"; //BOOLEAN OPERATOR FOR TRUE STATEMENT
bool isuserinput2 = userchoice != "abc"; //BOOLEAN OPERATOR FOR FALSE STATEMENT

Console.ReadKey();

