bool program = true;
while (program)
{
    Getinput1();
    Continue("Продолжим? Y/N", ref program);
}

static void Getinput1()
{
    Console.WriteLine("\nВведите координаты вектора A: ");

    int[] V1 = new int[3];

    V1[0] = Getinput("\nкоординаты x:");
    V1[1] = Getinput("координаты y:");
    V1[2] = Getinput("координаты z:");

    Console.WriteLine("\nВведите координаты вектора B: ");

    int[] V2 = new int[3];

    V2[0] = Getinput("\nкоординаты x:");
    V2[1] = Getinput("координаты y:");
    V2[2] = Getinput("координаты z:");

    Console.Write($"\nКоординаты вектора A: x = {V1[0]} y = {V1[1]} z = {V1[2]}");
    Console.WriteLine($"\nКоординаты вектора B: x = {V2[0]} y = {V2[1]} z = {V2[2]}");

    var value = Math.Sqrt(V1[0] * V1[0] + V1[1] * V1[1] + V1[2] * V1[2]);
    Console.WriteLine($"\nдлина вектора А = {value} ");
    var value1 = Math.Sqrt(V2[0] * V2[0] + V2[1] * V2[1] + V2[2] * V2[2]);
    Console.WriteLine($"длина вектора B = {value1}");
    var value3 = V1[0] * V2[0] + V1[1] * V2[1] + V1[2] * V2[2];
    Console.WriteLine($"скалярное произведение векторов = {value3}");
    var value4 = (V1[1] * V2[2] - V1[2] * V2[1], V1[2] * V2[0] - V1[0] * V2[2], V1[0] * V2[1] - V1[1] * V2[0]);
    Console.WriteLine($"векторное произведение = {value4}");
    var value5 = value3 / (value * value1);
    Console.WriteLine($"угол между векторами = {value5}");
    var value6 = (V1[0] + V2[0], V1[1] + V2[1], V1[2] + V2[2]);
    Console.WriteLine($"сумма векторов A и B = {value6}");
    var value7 = (V1[0] - V2[0], V1[1] - V2[1], V1[2] - V2[2]);
    Console.WriteLine($"разность векторов A и B = {value7}");   
}

 static bool Continue (string str,ref bool program)
{
    Console.WriteLine(str);
    var input = Console.ReadLine();
    if (input =="Y" || input == "y")
    {
        program = true;
    }
    else
        program = false;

    return program;
}

static int Getinput(string str)
{
    Console.Write($"{str} ");
    int value = 0;
    string input = Console.ReadLine();
    bool converted = int.TryParse(input, out value);

    while (!converted)
    {
        Console.Write("введите корректное значение: ");
        input = Console.ReadLine();
        converted = int.TryParse(input, out value);
    }
    return value;
}