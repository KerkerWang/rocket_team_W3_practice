namespace rocket_team_W3_practice;

class Program
{
    static void Main(string[] args)
    {

        //for陳述式
        //for (int i = 1; i <= 5; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.ReadKey();


        //while迴圈
        //int i = 0;
        //while (i < 5)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}
        //Console.ReadKey();


        //讀入五個整數，求這五個整數的和。//for loop
        //int sum = 0;
        //int tmp;
        //for (int i = 1; i <= 5; i++)
        //{
        //    Console.WriteLine($"請輸入第{i}個整數");
        //    tmp = Convert.ToInt32(Console.ReadLine());
        //    sum = sum + tmp;
        //}
        //Console.WriteLine($"總和為{sum}");
        //Console.ReadKey();


        //讀入五個整數，求這五個整數的和。//while loop
        //int sum = 0;
        //int i = 1;
        //while (i <= 5)
        //{
        //    int tmp;
        //    Console.WriteLine($"請輸入第{i}個整數");
        //    tmp = Convert.ToInt32(Console.ReadLine());
        //    sum = sum + tmp;
        //    i++;
        //}
        //Console.WriteLine($"總和為{sum}");
        //Console.ReadKey();


        //求N個整數的和，N由使用者輸入。//for loop
        //Console.WriteLine("請輸入整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //Console.WriteLine($"請輸入{N}個數字，將進行加總");
        //for (int i = 1; i <= N; i++)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    int tem = Convert.ToInt32(Console.ReadLine());
        //    sum = sum + tem;
        //    Console.WriteLine($"總和為{sum}");
        //}
        //Console.ReadKey();


        //求N個整數的和，N由使用者輸入。//while loop
        //Console.WriteLine("請輸入整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //Console.WriteLine($"請輸入{N}個數字，將進行加總");
        //int i = 1;
        //while (i <= N)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    int tem = Convert.ToInt32(Console.ReadLine());
        //    sum = sum + tem;
        //    Console.WriteLine($"總和為{sum}");
        //    i++;
        //}
        //Console.ReadKey();


        //假設有N個正整數，求其中的最大值。//for loop
        //Console.WriteLine("請輸入整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"請輸入{N}個正整數");
        //int Max = 0;
        //for (int i = 1; i <= N; i++)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    int tem = Convert.ToInt32(Console.ReadLine());
        //    while (tem <= 0)
        //    {
        //        Console.WriteLine($"此數非正整數，請輸入第{i}個數字");
        //        tem = Convert.ToInt32(Console.ReadLine());
        //    }
        //    if (tem >= Max)
        //    {
        //        Max = tem;
        //    }
        //    Console.WriteLine($"最大數為{Max}");
        //}
        //Console.ReadKey();


        //假設有N個正整數，求其中的最大值。//while loop
        //Console.WriteLine("請輸入整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"請輸入{N}個正整數");
        //int Max = 0;
        //int i = 1;
        //while (i <= N)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    int tem = Convert.ToInt32(Console.ReadLine());
        //    while (tem <= 0)
        //    {
        //        Console.WriteLine($"此數非正整數，請輸入第{i}個數字");
        //        tem = Convert.ToInt32(Console.ReadLine());
        //    }
        //    if (tem >= Max)
        //    {
        //        Max = tem;
        //    }
        //    Console.WriteLine($"最大數為{Max}");
        //    i++;
        //}
        //Console.ReadKey();


        //假設有N個正整數，求最大奇數值。//for loop
        //Console.WriteLine("請輸入正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine($"此數非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine($"請輸入{N}個正整數，將求最大奇數值");
        //int Max = 0;
        //for (int i = 1; i <= N; i++)
        //{
        //    Console.WriteLine($"請輸入第{i}個正整數");
        //    int tem = Convert.ToInt32(Console.ReadLine());
        //    while (tem <= 0)
        //    {
        //        Console.WriteLine($"此數非正整數，請輸入第{i}個數字");
        //        tem = Convert.ToInt32(Console.ReadLine());
        //    }
        //    if (tem % 2 == 1 && tem >= Max)
        //    {
        //        Max = tem;
        //        Console.WriteLine($"目前最大奇數值為{Max}");
        //    }            
        //}
        //if (Max == 0)
        //{
        //    Console.WriteLine("輸入的數均為偶數");
        //}
        //else
        //{
        //    Console.WriteLine($"最大奇數值為{Max}");
        //}
        //Console.ReadKey();


        //假設有N個正整數，求最大奇數值。//while loop
        //Console.WriteLine("請輸入正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine($"此數非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine($"請輸入{N}個正整數，將求最大奇數值");
        //int Max = 0;
        //int i = 1;
        //while (i <= N)
        //{
        //    Console.WriteLine($"請輸入第{i}個正整數");
        //    int tem = Convert.ToInt32(Console.ReadLine());
        //    while (tem <= 0)
        //    {
        //        Console.WriteLine($"此數非正整數，請輸入第{i}個數字");
        //        tem = Convert.ToInt32(Console.ReadLine());
        //    }
        //    if (tem % 2 == 1 && tem >= Max)
        //    {
        //        Max = tem;
        //        Console.WriteLine($"目前最大奇數值為{Max}");
        //    }
        //    i++;
        //}
        //if (Max == 0)
        //{
        //    Console.WriteLine("輸入的數均為偶數");
        //}
        //else
        //{
        //    Console.WriteLine($"最大奇數值為{Max}");
        //}
        //Console.ReadKey();


        //求N階層，即求1×2×3×…×N。
        //請求輸入N，讓for迴圈自2依序乘到N。//for loop
        //Console.WriteLine("請輸入數字N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("此數非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //int sum = 1;
        //for (int i = 1; i <= N; i++)
        //{
        //    sum = sum * i;           
        //}
        //Console.WriteLine(sum);
        //Console.ReadKey();


        //求N階層，即求1×2×3×…×N。
        //請求輸入N，讓for迴圈自2依序乘到N。//while loop
        //Console.WriteLine("請輸入正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("此數非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //int sum = 1;
        //int i = 1;
        //while (i <= N)
        //{
        //    sum = sum * i;
        //    i++;
        //}
        //Console.WriteLine(sum);
        //Console.ReadKey();


        //巢狀迴圈
        //for(int i = 0; i < 3; i++)
        //{
        //    for(int j = 0; j < 3; j++)
        //    {
        //        Console.WriteLine($"第{i}組為i={i},j={j}");
        //    }
        //}
        //Console.ReadKey();


        //int i = 0;       
        //while (i < 3)
        //{
        //    int j = 0;
        //    while (j < 3)
        //    {
        //        Console.WriteLine($"第{i}組為i={i},j={j}");
        //        j++;
        //    }
        //    i++;
        //}
        //Console.ReadKey();


        //輸出一個九九乘法表//for loop
        //Console.WriteLine("開始輸出九九乘法表");
        //for(int i = 1; i <= 9; i++)
        //{
        //    for(int j = 1; j <= 9; j++)
        //    {
        //        Console.WriteLine($"{i} x {j} = {i*j}");
        //    }
        //}
        //Console.ReadKey();


        //輸出一個九九乘法表//while loop
        //Console.WriteLine("開始輸出九九乘法表");
        //int i = 1;
        //while (i <= 9)
        //{
        //    int j = 1;
        //    while (j <= 9)
        //    {
        //        Console.WriteLine($"{i} x {j} = {i * j}");
        //        j++;
        //    }
        //    i++;
        //}
        //Console.ReadKey();


        //將程式改成如下輸出//for loop
        //Console.WriteLine("開始輸出九九乘法表");
        //for (int i = 1; i <= 9; i += 3)
        //{
        //    for (int j = 1; j <= 9; j++)
        //    {
        //        for (int k = i; k <= i + 2; k++)
        //        {
        //            if (k % 3 == 0)
        //            {
        //                Console.Write($"{k} * {j} = {k * j}\n");
        //            }
        //            else
        //            {
        //                Console.Write($"{k} * {j} = {k * j}\t");
        //            }
        //        }
        //    }
        //    Console.WriteLine("");
        //}
        //Console.ReadKey();


        //將程式改成如下輸出//while loop
        //Console.WriteLine("開始輸出九九乘法表");
        //int i = 1;
        //while (i <= 9)
        //{
        //    int j = 1;
        //    while (j <= 3)
        //    {
        //        if (j % 3 == 0)
        //        {
        //            Console.Write($"{j} * {i} = {i * j}\n");
        //        }
        //        else
        //        {
        //            Console.Write($"{j} * {i} = {i * j}\t");
        //        }
        //        j++;
        //    }
        //    i++;
        //}
        //Console.WriteLine("");
        //int k = 1;
        //while (k <= 9)
        //{
        //    int j = 4;
        //    while (j <= 6)
        //    {
        //        if (j % 3 == 0)
        //        {
        //            Console.Write($"{j} * {k} = {k * j}\n");
        //        }
        //        else
        //        {
        //            Console.Write($"{j} * {k} = {k * j}\t");
        //        }
        //        j++;
        //    }
        //    k++;
        //}
        //Console.WriteLine("");
        //int l = 1;
        //while (l <= 9)
        //{
        //    int j = 7;
        //    while (j <= 9)
        //    {
        //        if (j % 3 == 0)
        //        {
        //            Console.Write($"{j} * {l} = {l * j}\n");
        //        }
        //        else
        //        {
        //            Console.Write($"{j} * {l} = {l * j}\t");
        //        }
        //        j++;
        //    }
        //    l++;
        //}
        //Console.WriteLine("");
        //Console.ReadKey();


        //3-1.寫一程式，輸入10個整數，求其最小值。//for loop
        //Console.WriteLine("輸入10個整數，將求其最小值");
        //int min, tem;
        //Console.WriteLine($"請輸入第1個整數");
        //min = Convert.ToInt32(Console.ReadLine());
        //for (int i = 2; i <= 10; i++)
        //{
        //    Console.WriteLine($"請輸入第{i}個整數");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem <= min)
        //    {
        //        min = tem;
        //    }
        //}
        //Console.WriteLine($"最小值為{min}");
        //Console.ReadKey();


        //3-1.寫一程式，輸入10個整數，求其最小值。//while loop
        //Console.WriteLine("輸入10個整數，將求其最小值");
        //int min, tem;
        //Console.WriteLine($"請輸入第1個整數");
        //min = Convert.ToInt32(Console.ReadLine());
        //int i = 2;
        //while (i <= 10)
        //{
        //    Console.WriteLine($"請輸入第{i}個整數");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem <= min)
        //    {
        //        min = tem;
        //    }
        //    i++;
        //}
        //Console.WriteLine($"最小值為{min}");
        //Console.ReadKey();


        //3-2.寫一程式，輸入N個整數，求其最小值。//for loop
        //Console.WriteLine("請輸入正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine($"請輸入第1個整數");
        //int min = Convert.ToInt32(Console.ReadLine());
        //int tem;
        //if (N >= 2)
        //{
        //    for(int i =2;i <= N; i++)
        //    {
        //        Console.WriteLine($"請輸入第{i}個整數");
        //        tem = Convert.ToInt32(Console.ReadLine());
        //        if (tem <= min)
        //        {
        //            min = tem;
        //        }
        //    }
        //}
        //Console.WriteLine($"最小值為{min}");
        //Console.ReadKey();


        //3-2.寫一程式，輸入N個整數，求其最小值。//while loop
        //Console.WriteLine("請輸入正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine($"請輸入第1個整數");
        //int min = Convert.ToInt32(Console.ReadLine());
        //int tem;
        //if (N >= 2)
        //{
        //    int i = 2;
        //    while (i <= N)
        //    {
        //        Console.WriteLine($"請輸入第{i}個整數");
        //        tem = Convert.ToInt32(Console.ReadLine());
        //        if (tem <= min)
        //        {
        //            min = tem;
        //        }
        //        i++;
        //    }
        //}
        //Console.WriteLine($"最小值為{min}");
        //Console.ReadKey();


        //3-3.寫一程式，輸入10個整數，列出其中所有大於12的數字。//for loop
        //string biggerThan12 = "";
        //int tem;
        //Console.WriteLine("請輸入10個整數，將列出所有大於12的數字");
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine($"請輸入第{i}個整數");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem > 12)
        //    {
        //        biggerThan12 += tem + ",";
        //    }
        //}
        //if (biggerThan12 == "")
        //{
        //    Console.WriteLine("10個整數均小於12");
        //}
        //else
        //{
        //    Console.WriteLine(biggerThan12 + "為大於12的數字");
        //}
        //Console.ReadKey();


        //3-3.寫一程式，輸入10個整數，列出其中所有大於12的數字。//while loop
        //string biggerThan12 = "";
        //int tem;
        //Console.WriteLine("請輸入10個整數，將列出所有大於12的數字");
        //int i = 1;
        //while (i <= 10)
        //{
        //    Console.WriteLine($"請輸入第{i}個整數");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem > 12)
        //    {
        //        biggerThan12 += tem + ",";
        //    }
        //    i++;
        //}
        //if (biggerThan12 == "")
        //{
        //    Console.WriteLine("10個整數均小於12");
        //}
        //else
        //{
        //    Console.WriteLine(biggerThan12 + "為大於12的數字");
        //}
        //Console.ReadKey();


        //3-4.寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。//for loop
        //int sum = 0;
        //int tem;
        //Console.WriteLine("請輸入10個整數，將列出所有大於12的數字的總和");
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine($"請輸入第{i}個整數");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem > 12)
        //    {
        //        sum += tem;
        //    }
        //}
        //if (sum == 0)
        //{
        //    Console.WriteLine("10個整數均小於12");
        //}
        //else
        //{
        //    Console.WriteLine($"大於12的數字的總和為{sum}");
        //}
        //Console.ReadKey();


        //3-4.寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。//while loop
        //int sum = 0;
        //int tem;
        //Console.WriteLine("請輸入10個整數，將列出所有大於12的數字的總和");
        //int i = 1;
        //while (i <= 10)
        //{
        //    Console.WriteLine($"請輸入第{i}個整數");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem > 12)
        //    {
        //        sum += tem;
        //    }
        //    i++;
        //}
        //if (sum == 0)
        //{
        //    Console.WriteLine("10個整數均小於12");
        //}
        //else
        //{
        //    Console.WriteLine($"大於12的數字的總和為{sum}");
        //}
        //Console.ReadKey();


        //3-5.寫一程式，輸入N個數字，求其所有奇數中的最大值。//for loop
        //int max = int.MinValue;
        //int tem;
        //Console.WriteLine("請輸入N個數字，將求其所有奇數中的最大值");
        //Console.WriteLine("請輸入正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //for (int i = 1; i <= N; i++)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem % 2 == 1 && tem >= max)
        //    {
        //        max = tem;
        //    }
        //}
        //if (max == int.MinValue)
        //{
        //    Console.WriteLine("數字中無奇數");
        //}
        //else
        //{
        //    Console.WriteLine($"所有奇數中的最大值為{max}");
        //}
        //Console.ReadLine();


        //3-5.寫一程式，輸入N個數字，求其所有奇數中的最大值。//while loop
        //int max = int.MinValue;
        //int tem;
        //Console.WriteLine("請輸入N個數字，將求其所有奇數中的最大值");
        //Console.WriteLine("請輸入正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //int i = 1;
        //while (i <= N)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem % 2 == 1 && tem >= max)
        //    {
        //        max = tem;
        //    }
        //    i++;
        //}
        //if (max == int.MinValue)
        //{
        //    Console.WriteLine("數字中無奇數");
        //}
        //else
        //{
        //    Console.WriteLine($"所有奇數中的最大值為{max}");
        //}
        //Console.ReadLine();


        //3-6.寫一程式，輸入N個數字，求其所有正數之平方的加總。//for loop
        //Console.WriteLine("輸入N個數字，將加總其所有正數之平方，請輸入正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //double sum = 0;
        //while (N < 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //double tem;
        //for (int i = 1; i <= N; i++)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem > 0)
        //    {
        //        sum += Math.Pow(tem,2);
        //    }
        //}
        //if (sum == 0)
        //{
        //    Console.WriteLine("輸入數字中，均無正數");
        //}
        //else
        //{
        //    Console.WriteLine($"總和為{sum}");
        //}
        //Console.ReadKey();


        //3-6.寫一程式，輸入N個數字，求其所有正數之平方的加總。//while loop
        //Console.WriteLine("輸入N個數字，將加總其所有正數之平方，請輸入正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //double sum = 0;
        //while (N < 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //double tem;
        //int i = 1;
        //while (i <= N)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem > 0)
        //    {
        //        sum += Math.Pow(tem, 2);
        //    }
        //    i++;
        //}
        //if (sum == 0)
        //{
        //    Console.WriteLine("輸入數字中，均無正數");
        //}
        //else
        //{
        //    Console.WriteLine($"總和為{sum}");
        //}
        //Console.ReadKey();


        //3-7.寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如-7會被轉換成7。//for loop
        //Console.WriteLine("輸入N個數字，其中有些是負數，將這些負數轉換成正數，請輸入正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //string output = "";
        //int tem;
        //while (N < 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //for(int i = 1; i <= N; i++)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem < 0)
        //    {
        //        tem = Math.Abs(tem);
        //    }
        //    output += tem + ",";
        //}
        //Console.WriteLine($"{output}以上為這{N}個數字的結果");
        //Console.ReadLine();


        //3-7.寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如-7會被轉換成7。//while loop
        //Console.WriteLine("輸入N個數字，其中有些是負數，將這些負數轉換成正數，請輸入正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //string output = "";
        //int tem;
        //while (N < 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數N");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //int i = 1;
        //while (i <= N)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem < 0)
        //    {
        //        tem = Math.Abs(tem);
        //    }
        //    output += tem + ",";
        //    i++;
        //}
        //Console.WriteLine($"{output}以上為這{N}個數字的結果");
        //Console.ReadLine();


        //補充習題1.判斷101 - 200之間有多少個質數，並輸出所有質數。//for loop      
        //string prime = "";
        //int count = 0;
        //for (int i = 101; i <= 200; i++)
        //{
        //    Boolean isPrime = true;
        //    for (int j = 2; j <= i - 1; j++)
        //    {
        //        if (i % j == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //    }
        //    if (isPrime == true)
        //    {
        //        prime = prime + i + ",";
        //        count += 1;
        //    }
        //}
        //Console.WriteLine(prime);
        //Console.WriteLine($"共有{count}個質數");
        //Console.ReadKey();


        //補充習題1.判斷101 - 200之間有多少個質數，並輸出所有質數。//while loop      
        //string prime = "";
        //int count = 0;
        //int i = 101;
        //while (i <= 200)
        //{
        //    Boolean isPrime = true;
        //    int j = 2;
        //    while (j <= 100)
        //    {
        //        if (i % j == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //        j++;
        //    }
        //    if (isPrime == true)
        //    {
        //        prime = prime + i + ",";
        //        count += 1;
        //    }
        //    i++;
        //}
        //Console.WriteLine(prime);
        //Console.WriteLine($"共有{count}個質數");
        //Console.ReadKey();


        //補充習題2.輸入一個數，輸出其質因數//for loop
        //Console.WriteLine("請輸入一正整數");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N < 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //string output = N + " = ";
        //if (N == 1)
        //{
        //    Console.WriteLine("1 = 1 * 1");
        //}
        //else
        //{
        //    for (int i = 2; i <= N; i++)
        //    {
        //        if (N % i == 0)
        //        {
        //            int count = 0;
        //            for (int j = 0; N % i == 0; j++)
        //            {
        //                N = N / i;
        //                count++;
        //            }
        //            output = output + i + " ^ " + count + " * ";
        //        }
        //    }
        //    output = output.Substring(0, output.Length - 3);
        //    Console.WriteLine(output);
        //}
        //Console.ReadKey();


        //補充習題2.輸入一個數，輸出其質因數//while loop
        //Console.WriteLine("請輸入一正整數");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N < 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //string output = N + " = ";
        //if (N == 1)
        //{
        //    Console.WriteLine("1 = 1 * 1");
        //}
        //else
        //{
        //    int i = 2;
        //    while (i <= N)
        //    {
        //        if (N % i == 0)
        //        {
        //            int count = 0;
        //            while (N % i == 0)
        //            {
        //                N = N / i;
        //                count++;
        //            }
        //            output = output + i + " ^ " + count + " * ";
        //        }
        //        i++;
        //    }
        //    output = output.Substring(0, output.Length - 3);
        //    Console.WriteLine(output);
        //}
        //Console.ReadKey();


        //補充習題3.求100到300中可以被3與7整除的個數。//for loop
        //int count = 0;
        //for (int i =100; i <= 300; i++)
        //{
        //    if (i % 21 == 0)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine($"100到300中可以被3與7整除的個數共有{count}個");
        //Console.ReadKey();


        //補充習題3.求100到300中可以被3與7整除的個數。//while loop
        //int count = 0;
        //int i = 100;
        //while (i <= 300)
        //{
        //    if (i % 21 == 0)
        //    {
        //        count++;
        //    }
        //    i++;
        //}
        //Console.WriteLine($"100到300中可以被3與7整除的個數共有{count}個");
        //Console.ReadKey();


        //while迴圈指令
        //假設輸入的都是正數，一旦讀到負數就終止。
        //Console.WriteLine("請輸入整數");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N >= 0)
        //{
        //    Console.WriteLine("此數為正數，請輸入整數");
        //     N = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine("此數為負數");
        //Console.ReadKey();


        //輾轉相除法：兩數相除，取餘數重複進行相除，直到餘數為0時，前一個除數即為最大公約數。
        Console.WriteLine("請輸入整數x");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("請輸入整數y");
        int y = Convert.ToInt32(Console.ReadLine());
        int tem;
        if (x >= y)
        {
            while (x % y != 0)
            {
                tem = x % y;
                x = y;
                y = tem;
            }
            Console.WriteLine($"最大公約數為{Math.Abs(y)}");
        }
        else
        {
            while (y % x != 0)
            {
                tem = y % x;
                y = x;
                x = tem;
            }
            Console.WriteLine($"最大公約數為{Math.Abs(x)}");
        }
        Console.ReadKey();


        //計算N個數字的和。檢查i有沒有超過N，超過就不做了。
        //Console.WriteLine("請輸入一正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //int sum = 0;
        //int i = 1;
        //while (i <= N)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    int tem = Convert.ToInt32(Console.ReadLine());
        //    sum += tem;
        //    i++;
        //}
        //Console.WriteLine($"此{N}個數字總和為{sum}");
        //Console.ReadKey();


        //4-1.利用while寫一程式求N個數字的最大值。
        //Console.WriteLine("請輸入一正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine("請輸入第一個數字");
        //int Max = Convert.ToInt32(Console.ReadLine());
        //int i = 2;
        //if (N >= 2)
        //{
        //    while (i <= N)
        //    {
        //        Console.WriteLine($"請輸入第{i}個數字");
        //        int tem = Convert.ToInt32(Console.ReadLine());
        //        if (tem >= Max)
        //        {
        //            Max = tem;
        //        }
        //        i++;
        //    }
        //}
        //Console.WriteLine($"{N}個數字中最大值為{Max}");
        //Console.ReadKey();


        //4-2.利用while寫一程式求一個等差級數數字的和，
        //一共有N個數字，程式應該輸入最小的起始值以及數字間的差。
        //(即從起始值開始，間格差，共N個 的總和)
        //Console.WriteLine("將求N個數字的等差級數的和");
        //Console.WriteLine("請輸入一正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine("請輸入起始值");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("請輸入差");
        //int r = Convert.ToInt32(Console.ReadLine());
        //int sum = a;
        //int i = 1;
        //if (N > 1)
        //{
        //    while (i <= N - 1)
        //    {
        //        sum += (a + r * i); 
        //        i++;
        //    }
        //}
        //Console.WriteLine($"總和為{sum}");
        //Console.ReadKey();


        //4-3.利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和。
        //Console.WriteLine("將讀入N個數字，然後找出所有小於13的數，再求這些數字的和。");
        //Console.WriteLine("請輸入一正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //int sum = 0;
        //string lowerThan13 = "";
        //int i = 1;
        //while (i <= N)
        //{
        //    Console.WriteLine($"請輸入第{i}個數字");
        //    int tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem < 13)
        //    {
        //        sum += tem;
        //        lowerThan13 = lowerThan13 + tem + ", ";
        //    }
        //    i++;
        //}
        //if (lowerThan13.Length > 0)
        //{
        //    lowerThan13 = lowerThan13.Substring(0, lowerThan13.Length - 2);
        //}
        //Console.WriteLine($"所有小於13的數字為{lowerThan13}");
        //Console.WriteLine($"總和為{sum}");
        //Console.ReadKey();


        //4-4.利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字。
        //Console.WriteLine("讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字。");
        //Console.WriteLine("請輸入一正整數N");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //int i = 1;
        //while (i <= N)
        //{
        //    Console.WriteLine("請輸入數字");
        //    int tem = Convert.ToInt32(Console.ReadLine());
        //    if (tem > 7 && tem<10)
        //    {
        //        Console.WriteLine($"第一個大於7而小於10的數字為{tem}");
        //        break;
        //    }
        //    i++;
        //}
        //if (i > N)
        //{
        //    Console.WriteLine("均無大於7而小於10的數字");
        //}
        //Console.ReadKey();


        //4-5.利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai > bi，即停止，並列印出ai及bi。
        //int a1=0, a2=0, a3=0, a4=0, a5=0;
        //int i = 1;
        //int tem;
        //while (i <= 5)
        //{
        //    Console.WriteLine($"請輸入數字a{i}");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    switch (i)
        //    {
        //        case 1:
        //            a1 = tem;
        //            break;
        //        case 2:
        //            a2 = tem;
        //            break;
        //        case 3:
        //            a3 = tem;
        //            break;
        //        case 4:
        //            a4 = tem;
        //            break;
        //        case 5:
        //            a5 = tem;
        //            break;
        //    }
        //    i++;
        //}
        //Console.WriteLine($"a1={a1}, a2={a2}, a3={a3}, a4={a4}, a5={a5}");
        //int j = 1;
        //Boolean biggerThanB = false;
        //while (j <= 5)
        //{
        //    Console.WriteLine($"請輸入數字b{j}");
        //    tem = Convert.ToInt32(Console.ReadLine());
        //    switch (j)
        //    {
        //        case 1:
        //            if (tem < a1)
        //            {
        //                biggerThanB = true;
        //                Console.WriteLine($"a1為{a1}, b1為{tem}, {a1}>{tem}");
        //            }
        //            break;
        //        case 2:
        //            if (tem < a2)
        //            {
        //                biggerThanB = true;
        //                Console.WriteLine($"a2為{a2}, b2為{tem}, {a2}>{tem}");
        //            }
        //            break;
        //        case 3:
        //            if (tem < a3)
        //            {
        //                biggerThanB = true;
        //                Console.WriteLine($"a3為{a3}, b3為{tem}, {a3}>{tem}");
        //            }
        //            break;
        //        case 4:
        //            if (tem < a4)
        //            {
        //                biggerThanB = true;
        //                Console.WriteLine($"a4為{a4}, b4為{tem}, {a4}>{tem}");
        //            }
        //            break;
        //        case 5:
        //            if (tem < a5)
        //            {
        //                biggerThanB = true;
        //                Console.WriteLine($"a5為{a5}, b5為{tem}, {a5}>{tem}");
        //            }
        //            break;
        //    }
        //    if (biggerThanB == true)
        //    {
        //        break;
        //    }
        //    j++;
        //}       
        //Console.ReadKey();


        //Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，
        //因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。
        //假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。
        //Console.WriteLine("請輸入一時間數N(分鐘)");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N <= 0)
        //{
        //    Console.WriteLine("非正整數，請輸入正整數");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //int count = 0;
        //if (N >= 5)
        //{
        //    while (N >= 5)
        //    {
        //        N -= 5;
        //        count++;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("小於5分鐘，一個漢堡都吃不完！");
        //}
        //Console.WriteLine($"總共吃完{count}個漢堡");
        //Console.ReadKey();


        //補充題目.小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。
        //int total = 560;
        //int count = 0;
        //while (total > 0)
        //{
        //    total -= 4;
        //    count++;
        //    if (count % 12==0)
        //    {
        //        total -= 1;                
        //    }
        //}
        //Console.WriteLine($"總共需要{count}個月還清");
        //Console.ReadKey();


        //補充題目.系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！，猜錯時，要提示是比較大還是比較小。
        //Console.WriteLine("請輸入介於1-100之間的數字");
        //int N = Convert.ToInt32(Console.ReadLine());
        //while (N < 1 || N > 100)
        //{
        //    Console.WriteLine("請輸入介於1-100之間的數字");
        //    N = Convert.ToInt32(Console.ReadLine());
        //}
        //Random myObject = new Random();
        //int ranNum = myObject.Next(1, 100);
        //while (N != ranNum)
        //{
        //    if (N > ranNum)
        //    {
        //        Console.WriteLine($"該數字小於{N}");
        //        Console.WriteLine("請再次輸入數字");
        //        N = Convert.ToInt32(Console.ReadLine());
        //    }
        //    else
        //    {
        //        Console.WriteLine($"該數字大於{N}");
        //        Console.WriteLine("請再次輸入數字");
        //        N = Convert.ToInt32(Console.ReadLine());
        //    }
        //}
        //Console.WriteLine($"{N}={ranNum}，恭喜答對！");
        //Console.ReadKey();
    }
}

