using System;
using System.Collections.Generic;
using System.Text;

namespace RumahSakit
{
    class Dokter : User
    {
        public string biodataDokter()
        {
            User namadoc = new User();
            User IDdoc = new User();
            User Nodoc = new User();
            namadoc.Nama = "Siti";
            IDdoc.NomorID = 1504;
            Nodoc.No = 085725630563;
            Console.WriteLine("\n============= BIODATA DOKTER =============");
            Console.WriteLine("Nama Dokter : " + namadoc.Nama);
            Console.WriteLine("ID Dokter : " + IDdoc.NomorID);
            Console.WriteLine("No Hp : " + Nodoc.No);
            Console.Write("Riwayat Penyakit : " + RiwayatPasien);
            base.RiwayatPasien = "Sehat";
            return RiwayatPasien;

        }
    }
}
