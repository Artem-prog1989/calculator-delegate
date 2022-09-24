public delegate double? Operation (double a, double b);
// калькулятор на делегатах
enum operationChoice
{
    sumSign,
    divSign,
    subSign,
    multSign,
}
class Programm
{
    static Operation sum = (double a, double b) =>
    {
        return a + b;
    };
    static Operation div = (double a, double b) =>
    {
        if (b==0)
        {
            Console.WriteLine("деление на нуль недопустимо");
            return null;
        }
        return a / b;
    };
    static Operation sub = (double a, double b) =>
    {
        return a - b;
    };
    static Operation mult = (double a, double b) =>
    {
        return a * b;
    };


    public static Operation Calc(operationChoice op) {

        switch (op) 
        {
            case operationChoice.sumSign:
                return sum;
            case operationChoice.divSign:
                return div;
            case operationChoice.subSign:
                return sub;
            case operationChoice.multSign:
                return mult;
            default:
                throw new NotImplementedException();
                
        }
    }

    public static void Main(string[]args)
    {
        Calc(operationChoice.divSign);
        Console.WriteLine(div(1, 0));

        
    }
}


