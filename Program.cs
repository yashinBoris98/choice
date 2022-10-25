Console.WriteLine("enter array lenghth");
int arrLength = Convert.ToInt32(Console.ReadLine());
String[] arr = new string[arrLength];

String? a="";
for (int i = 0; i < arrLength; i++)
{
    a=Console.ReadLine();
    if(a!=null)
    arr[i]=a;
}

String[] arr1 = new string[arrLength];
for (int i = 0; i < arrLength; i++)
{
    int num = new Random().Next(1,3);
    if(num>arr[i].Length)
        arr1[i]=arr[i];
    else
        arr1[i]=arr[i].Substring(0,num);

}

foreach (var item in arr1)
{
    Console.WriteLine(item);
}


