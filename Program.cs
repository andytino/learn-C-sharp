using System;

namespace HelloWorld
{
    class Program
    {
        static double Input(string? label, int condition = 0)
        {
            string? txt;
            Console.Write($"Nhap {label}: ");
            txt = Console.ReadLine();

            if (condition == 1 && txt == "0")
            {
                Console.WriteLine($"{label} phải khác 0");
                return Input(label);
            }

            double number;
            if (Double.TryParse(txt, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số tự nhiên.");
                return Input(label);
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
                Console.WriteLine("Vui lòng nhập số tự nhiên.");
                return InputInt(label);
            }
        }
        static void numberOne(double A = 0, double B = 0, double C = 0, double delta = 0)
        {
            double? sqrtDelta;
            delta = B * B - 4 * A * C;
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phương trình có nghiệm kép");
                Console.Write("x1 = x2 = ");
                Console.Write(-B / (2 * A));

            }
            else if (delta > 0)
            {
                sqrtDelta = Math.Sqrt(delta);
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt");
                Console.Write("x1 = ");
                Console.WriteLine((-B + sqrtDelta) / (2 * A));
                Console.Write("x2 = ");
                Console.WriteLine((-B - sqrtDelta) / (2 * A));
            }
        }
        static void numberTwo(int A = 0, int B = 0, int C = 0, int D = 0)
        {
            int[] arr = { A, B, C, D };
            Console.Write("Kết quả số nhỏ nhất là: ");
            Console.WriteLine(arr.Min());
        }
        static void Main(string[] args)
        {
            string? numberSelect;

            Console.WriteLine("Hãy chọn loại bài tập.");
            Console.WriteLine("1. Phương trình ax2 + bx + c = 0.");
            Console.WriteLine("2. Nhập 4 số nguyên, tìm số nhỏ nhất");
            Console.WriteLine("3. Thoát");
            Console.WriteLine("==================");
            Console.Write("Chọn bài số: ");
            numberSelect = Console.ReadLine();
            switch (numberSelect)
            {
                case "1":
                    Console.WriteLine("---- GIẢI PHƯƠNG TRÌNH ax2 + bx + c = 0 ----");
                    numberOne(Input("a", 1), Input("b"), Input("c"));
                    break;
                case "2":
                    Console.WriteLine("---- TÌM SỐ NHỎ NHẤT ----");
                    numberTwo(InputInt("số thứ nhất"), InputInt("số thứ hai"), InputInt("số thứ ba"), InputInt("số thứ 4"));
                    break;
                case "3":
                    Console.WriteLine("Tạm biệt!");
                    break;
                default:
                    Console.WriteLine("Tạm biệt!");
                    break;
            }
        }
    }
}