Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i, t;
int i_1 = 1;
int i_2 = 0;
string m = "";
if(number == 0) m = "0 ";
else if(number == 1) m = "0 1";
    else
    {
        m = "0 1";
        for(i = 2; i <= number; i++)
        {
            t = i_1 + i_2;
            i_2 = i_1;
            i_1 = t;
            m = m + " " + t;
        }
    }
Console.WriteLine(m);