using System;
using System.Collections.Generic;
using System.Text;

namespace RumahSakit
{
    class Pasien : User
    {
        public string biodataPasien()
        {
            User namapas = new User();
            User IDpas = new User();
            User Nopas = new User();
            namapas.Nama = "Slamet";
            IDpas.NomorID = 001;
            Console.WriteLine("\n============= BIODATA PASIEN =============");
            Console.WriteLine("Nama Pasien : " + namapas.Nama);
            Console.WriteLine("ID Pasien : " + IDpas.NomorID);
            Console.WriteLine("No Hp : " + Nopas.setNo(6281225877846));
            Console.Write("Riwayat Penyakit : " + RiwayatPasien);
            base.RiwayatPasien = "Demam Berdarah";
            return RiwayatPasien;

        }
    }
}
