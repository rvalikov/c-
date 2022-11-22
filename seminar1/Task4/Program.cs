// Task4 Программа принимает на вход три числа, и выдает максимальное из них
Console.Clear();
Console.Write("Ввведите первое число ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите второе число ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите третье число ");
int с=Convert.ToInt32(Console.ReadLine());
int max=a;
int i=1;
while(i<3){
    if (b>max) max=b;
else {if(с>max) max=с;
i++;
};
}
 Console.Write(max);



