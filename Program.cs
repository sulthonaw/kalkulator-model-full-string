namespace Kalkulator
{
    class Program
    {
        public static string[] _dataAngkaString = { "nol", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas", "belas", "puluh" };

        public static string[] _dataOperanString = { "ditambah", "+", "dikurangi", "-", "dikali", "*", "dibagi", "/" };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Input kata : ");
                string input = Console.ReadLine();

                string[] inputArr = input.Split(' ');

                int pertama = 0, kedua = 0;
                char operan = ' ';

                for (int i = 0; i < _dataAngkaString.Length; i++)
                {
                    if (inputArr[0] == _dataAngkaString[i])
                    {
                        pertama = i;
                        break;
                    }
                }

                for (int i = 0; i < _dataOperanString.Length; i++)
                {
                    if (inputArr[1] == _dataOperanString[i]) { operan = Convert.ToChar(_dataOperanString[i + 1]); break; }
                }

                for (int i = 0; i < _dataAngkaString.Length; i++)
                {
                    if (inputArr[2] == _dataAngkaString[i])
                    {
                        kedua = i;
                        break;
                    };
                }

                perhitungan(pertama, operan, kedua);

                Console.Write("Apakah anda ingin melanjutkan? (y/n) ");
                char aksi = Convert.ToChar(Console.ReadLine());
                if (aksi == 'n') break;
            }

        }

        static void perhitungan(int pertama, char operan, int kedua)
        {
            int hasil = 0;
            switch (operan)
            {
                case '+':
                    hasil = pertama + kedua;
                    break;
                case '-':
                    hasil = pertama - kedua;
                    break;
                case '*':
                    hasil = pertama * kedua;
                    break;
                case '/':
                    hasil = pertama / kedua;
                    break;
            }

            if (hasil >= 0 && hasil < 12)
            {
                Console.WriteLine($"Hasil : {_dataAngkaString[hasil]}");
            }
            else if (hasil >= 12 && hasil < 20)
            {
                hasil -= 10;
                Console.WriteLine($"Hasil : {_dataAngkaString[hasil]} {_dataAngkaString[12]}");
            }
            else if (hasil < 0)
            {
                if (hasil < -12)
                {
                    hasil *= -1;
                    Console.WriteLine($"Hasil : negatif {_dataAngkaString[hasil]} {_dataAngkaString[12]}");
                }
                else
                {
                    hasil *= -1;
                    Console.WriteLine($"Hasil : negatif {_dataAngkaString[hasil]}");
                }
            }
            else
            {
                Console.WriteLine($"Hasil : {hasil}");
            }
        }
    }
}
