using System;

namespace Chuabai.Session6
{
    // Khai bao 1 delegate  tra  ve int va co hai tham so int
    public delegate int IntegerToInteger(int a, int b);
    public class Program
    {
        public static void Main(string[] args)
        {
            // tao 1 doi tuong delegate
            IntegerToInteger ii = new IntegerToInteger(Calculator.Add);// tham chiu den o nho cua ham
            ii += Calculator.Subtract;//nap them chuoi thuc hien cua delegate mo
            ii += Calculator.division;
            int a = ii(5,2);// Thực thi các ham nạp bào delegate
            Console.WriteLine("a ="+ a);
            // Calculator.Add(2, 5);
             //Calculator.Subtract(2, 5);
             //luon chay 2 dong voimoi cap
             //Calculator.Add(7, 3);
             //Calculator.Subtract(7, 3);
             TaxMoney tm = TaxCalc.GetTax("VN");// tm là 1 delegate;
             float tax = tm(1000000);
             Console.WriteLine("Thue phai nop:"+ tax);
             
             TaxMoney tm2 = delegate(float salary) { return salary * 40 / 100;};
             float frTax = tm2(10000);
             Console.WriteLine("Thue tai Phap:" + frTax);
        }
     }
 }