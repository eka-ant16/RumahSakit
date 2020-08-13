using System;

namespace RumahSakit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tDATA RUMAH SAKIT MARGONO\t\t\t\t\t");
            User ruangdoc = new User();
            User ruangpas = new User();
            //BIODATA DOKTER
            Dokter dokter1 = new Dokter();
            Console.WriteLine(dokter1.biodataDokter());
            ruangdoc.Bangsal = "Spesialis Penyakit Dalam";
            Console.WriteLine("Ruang Kerja : " + ruangdoc.Bangsal);//pemanggilan internal user
                                                                   //BIODATA PASIEN
            Pasien pasien1 = new Pasien();
            Console.WriteLine(pasien1.biodataPasien());
            ruangpas.Bangsal = "President Suite";
            Console.WriteLine("Pasien berada pada ruang : " + ruangpas.Bangsal);//pemanggilan internal user
            Console.ReadLine();
        }
    }
}
