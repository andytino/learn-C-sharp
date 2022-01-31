using System;

namespace Exercise
{
    class Program
    {
        static double InputNumber(string? label, int condition = 0)
        {
            string? txt;
            Console.Write($"Nhap {label}: ");
            txt = Console.ReadLine();

            if (condition == 1 && txt == "0")
            {
                Console.WriteLine($"{label} phải khác 0");
                return InputNumber(label);
            }

            double number;
            if (Double.TryParse(txt, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số tự nhiên.");
                return InputNumber(label);
            }
        }
        static int InputInt(string? label, int condition = 0)
        {
            string? txt;
            Console.Write($"Nhap {label}: ");
            txt = Console.ReadLine();

            if (condition == 1 && txt == "0")
            {
                Console.WriteLine($"{label} phải khác 0");
                return InputInt(label);
            }

            int number;
            if (int.TryParse(txt, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số tự nguyên.");
                return InputInt(label);
            }
        }
        static void Ex1(int n = 0)
        {
            int S = 0;
            int i = 0;
            while (i <= n)
            {
                S += i;
                i++;
            }
            Console.WriteLine($"Kết quả S({n}): {S}");
        }
        static void Ex2(int n = 0)
        {
            double S = 0D;
            int i = 0;
            while (i <= n)
            {
                S += Math.Pow(i, 2);
                i++;
            }
            Console.WriteLine($"Kết quả S({n}): {S}");

        }
        static void Ex3(int n = 1)
        {
            double S = 0D;
            int i = 1;
            while (i <= n)
            {
                S += (1D / i);
                i++;
            }
            Console.WriteLine($"Kết quả S({n}): {S}");

        }
        static void Ex4(int n = 1)
        {
            double S = 0D;
            int i = 1;
            while (i <= n)
            {
                S += (1D / (2 * i));
                i++;
            }
            Console.WriteLine($"Kết quả S({n}): {S}");

        }
        static void Ex5(int n = 1)
        {
            double S = 0D;
            int i = 1;
            while (i <= n)
            {
                S += (1D / (2 * i + 1));
                i++;
            }
            Console.WriteLine($"Kết quả S({n}): {S}");
        }
        static void Ex6(int n = 1)
        {
            double S = 0D;
            int i = 1;
            while (i <= n)
            {
                S += (1D / (i * (i + 1)));
                i++;
            }
            Console.WriteLine($"Kết quả S({n}): {S}");
        }
        static void Ex7(int n = 1)
        {
            double S = 0D;
            double i = 1D;
            while (i <= n)
            {
                S += (i / (i + 1));
                i++;
            }
            Console.WriteLine($"Kết quả S({n}): {S}");
        }
        static void Ex8(int n = 0)
        {
            double S = 0D;
            double i = 0;
            while (i <= n)
            {
                S += ((2 * i + 1) / (2 * i + 2));
                i++;
            }
            Console.WriteLine($"Kết quả S({n}): {S}");
        }
        static void Ex9(int n = 1)
        {
            double T = 1D;
            double i = 1D;
            while (i <= n)
            {
                T *= i;
                i++;
            }
            Console.WriteLine($"Kết quả S({n}): {T}");
        }
        static void Ex10(int x = 1, int n = 1)
        {
            double T = Math.Pow(x, n);
            Console.WriteLine($"Kết quả S({x},{n}): {T}");
        }
        static void Main(string[] args)
        {
            string? numberSelect;

            Console.WriteLine("Hãy chọn loại bài tập.");
            Console.WriteLine("1. Tính S(n) = 1 + 2 + 3 + … + n");
            Console.WriteLine("2. Tính S(n) = 1^2 + 2^2 + … + n^2");
            Console.WriteLine("3. Tính S(n) = 1 + ½ + 1/3 + … + 1/n");
            Console.WriteLine("4. Tính S(n) = ½ + ¼ + … + 1/2n");
            Console.WriteLine("5. Tính S(n) = 1 + 1/3 + 1/5 + … + 1/(2n + 1)");
            Console.WriteLine("6. Tính S(n) = 1/1×2 + 1/2×3 +…+ 1/n x (n + 1)");
            Console.WriteLine("7. Tính S(n) = ½ + 2/3 + ¾ + …. + n / n + 1");
            Console.WriteLine("8. Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2");
            Console.WriteLine("9. Tính T(n) = 1 x 2 x 3…x N");
            Console.WriteLine("10. Tính T(x, n) = x^n");
            Console.WriteLine("==================");
            Console.Write("Chọn bài số: ");
            numberSelect = Console.ReadLine();
            switch (numberSelect)
            {
                case "1":
                    Console.WriteLine("---- 1. Tính S(n) = 1 + 2 + 3 + … + n ----");
                    Ex1(InputInt("n"));
                    break;
                case "2":
                    Console.WriteLine("---- 2. Tính S(n) = 1^2 + 2^2 + … + n^2 ----");
                    Ex2(InputInt("n"));
                    break;
                case "3":
                    Console.WriteLine("---- 3. Tính S(n) = 1 + ½ + 1/3 + … + 1/n -----");
                    Ex3(InputInt("n", 0));
                    break;
                case "4":
                    Console.WriteLine("---- 4. Tính S(n) = ½ + ¼ + … + 1/2n -----");
                    Ex4(InputInt("n", 0));
                    break;
                case "5":
                    Console.WriteLine("---- 5. Tính S(n) = 1 + 1/3 + 1/5 + … + 1/(2n + 1) -----");
                    Ex5(InputInt("n", 0));
                    break;
                case "6":
                    Console.WriteLine("---- 6. Tính S(n) = 1/1×2 + 1/2×3 +…+ 1/n x (n + 1) -----");
                    Ex6(InputInt("n", 0));
                    break;
                case "7":
                    Console.WriteLine("---- 7. Tính S(n) = ½ + 2/3 + ¾ + …. + n / n + 1 -----");
                    Ex7(InputInt("n", 0));
                    break;
                case "8":
                    Console.WriteLine("---- 8. Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2 -----");
                    Ex8(InputInt("n", 0));
                    break;
                case "9":
                    Console.WriteLine("---- 9. Tính T(n) = 1 x 2 x 3…x N -----");
                    Ex9(InputInt("n", 0));
                    break;
                case "10":
                    Console.WriteLine("---- 10. Tính T(x, n) = x^n -----");
                    Ex10(InputInt("x"), InputInt("n"));
                    break;
                default:
                    Console.WriteLine("Tạm biệt!");
                    break;
            }
        }
    }
}