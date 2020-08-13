using System;
using System.Collections.Generic;
using System.Text;

namespace RumahSakit
{
    class User
    {
        //attribut
        public string Nama;
        public int NomorID;
        private double NomorHP;
        protected string RiwayatPasien;
        internal string Bangsal;
        //properties
        public double No
        {
            get { return this.NomorHP; }
            set { this.NomorHP = value; }
        }
        //abtraksi
        public double getNo()
        {
            NomorHP = 0;
            return this.NomorHP;
        }
        public double setNo(double NoBaru)
        {
            this.NomorHP = NoBaru;
            return this.NomorHP;

        }
    }
}
