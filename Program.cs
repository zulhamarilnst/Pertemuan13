using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanList2
{
    public class Program
    {
       static void Main(string[] args)
        {
            //membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Erik";

            //membuat object mhs1
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "Wely";

            //membuat object dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "Jhono";

            //membiat object list
            List<Mahasiswa> list = new List<Mahasiswa>();

            //menambahkan elemen list
            list.Add(mhs1);
            list.Add(mhs2);

            //coba rambahkan objek dosen ke list, apa yang terjadi
            //list.Add(dosen);

            Console.WriteLine(" NIM          NAMA");
            Console.WriteLine("===================");

            foreach(Mahasiswa mhs in list)
            {
                //mengakses elemen list
                //mahasiswa mhs = list[1];
                Console.WriteLine("{0}{1}", mhs.Nim.PadRight(14), mhs.NamaMahasiswa);
            }

            Console.WriteLine("{0}{1}", dosen.Nik.PadRight(14), dosen.NamaDosen);
            Console.ReadKey();
        }
    }
}