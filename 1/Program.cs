//1 vid
void Method1()
{
    Console.WriteLine("Avtor Zack");
}

Method1();

//2vid

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Text");

void Method21(string msg,int count)
{
    int i=0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}

Method21(msg:"Stroka",count:4);
Method21(count:4,msg:"New Stroka");

//3vid

int Method3()
{
    return DateTime.Now.Year;
}

int year=Method3();
Console.WriteLine(year);

//4vid

// string Method4(int count, string text)
// {
//     int i=0;
//     string result =String.Empty;

//     while(i<count)
//     {
//         result=result+text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    
    string result =String.Empty;
    for(int i =0; i<count;i++)
    
    {
        result=result+text;
        
    }
    return result;
}
string res=Method4(10,"abcd");
Console.WriteLine(res);

for(int i=2;i<=10;i++)
{
    for(int j=2;j<=10;j++)
    {
        Console.WriteLine($"{i}x{j}={i*j}");
    }
    Console.WriteLine();
}