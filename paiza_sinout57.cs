using System;

class Program
{
    static void Main()
    {
        Console.Write("");
        string input = Console.ReadLine().Trim();

        // 入力の基本チェック
        if (string.IsNullOrEmpty(input) || input.Length != 3)
        {
            Console.WriteLine("入力形式が正しくありません。例: 3+5");
            return;
        }

        char firstChar = input[0];
        char op = input[1];
        char secondChar = input[2];

        // 数字チェック
        if (!char.IsDigit(firstChar) || !char.IsDigit(secondChar))
        {
            Console.WriteLine("1桁の数字を入力してください。");
            return;
        }

        int num1 = firstChar - '0';
        int num2 = secondChar - '0';
        int result;

        try
        {
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case 'x':
                case 'X':
                    result = num1 * num2;
                    break;
                default:
                    Console.WriteLine("演算子は +, -, x のいずれかを使用してください。");
                    return;
            }

            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("エラーが発生しました: {ex.Message}");
        }
    }
}