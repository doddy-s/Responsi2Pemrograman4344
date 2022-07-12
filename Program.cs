namespace ProjectPenjualan
{
    public class DataPenjualan
    {
        public int? nota, totalNota;
        public string? tanggal, customer, status;

        public DataPenjualan()
        {
            Console.Write("Nota\t:");
            nota = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tanggal\t:");
            tanggal = Convert.ToString(Console.ReadLine());

            Console.Write("Customer:");
            customer = Convert.ToString(Console.ReadLine());

            Console.Write("Jenis [T/K]\t:");
            string? s = Convert.ToString(Console.ReadLine());
            if(s == "T" || s == "t")
            {
                status = "Tunai";
            }
            else if(s == "K" || s == "k")
            {
                status = "Kredit";
            }

            Console.Write("Total Nota\t:");
            totalNota = Convert.ToInt32(Console.ReadLine());
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<DataPenjualan> daftarPenjualan = new List<DataPenjualan>();
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                Console.Clear();
                
                Console.WriteLine("Pilih Menu\n\n1. Tambah Penjualan\n2. Tampilkan Penjualan\n3. Keluar");

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (nomorMenu)
                {
                    case 1:
                        Console.WriteLine("Tambah Data Penjualan");
                        DataPenjualan temp = new DataPenjualan();
                        daftarPenjualan.Add(temp);
                        break;

                    case 2:
                        Console.WriteLine("Data Penjualan");
                        int i = 1;
                        foreach(DataPenjualan data in daftarPenjualan)
                        {
                            Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", i, data.nota, data.tanggal, data.customer, data.status, data.totalNota);
                            i++;
                        }
                        Console.ReadKey();
                        break;

                    case 3: // keluar dari program
                        Console.ReadKey();
                        return;

                    default:
                        break;
                }
            }
        }
    }
}
