using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            int giris = 0;
            string isim, soyisim, tel, bosluk, bosluk2, bosluk3, satir, sil;
            while (giris != 5)
            {
                Console.Write("1- Ekle\n2- Sil\n3- Güncelle\n4- Listele\n5- Çıkış\nSeçiminiz:");
                giris = Convert.ToInt32(Console.ReadLine());

                if(giris==1)
                {
                    bosluk = Convert.ToString("#");
                    StreamWriter wbosluk = new StreamWriter(".\\rehber.txt", true);
                    wbosluk.Write(bosluk);
                    wbosluk.Close();

                    Console.Write("İsim Giriniz: ");
                    isim = Convert.ToString(Console.ReadLine());
                    StreamWriter wisim = new StreamWriter(".\\rehber.txt", true);
                    wisim.Write(isim);
                    wisim.Close();

                    bosluk2 = Convert.ToString(" #");
                    StreamWriter wbosluk2 = new StreamWriter(".\\rehber.txt", true);
                    wbosluk2.Write(bosluk2);
                    wbosluk2.Close();

                    Console.Write("Soyisim Giriniz: ");
                    soyisim = Convert.ToString(Console.ReadLine());
                    StreamWriter wsoyisim = new StreamWriter(".\\rehber.txt", true);
                    wsoyisim.Write(soyisim);
                    wsoyisim.Close();

                    bosluk3 = Convert.ToString(" #");
                    StreamWriter wbosluk3 = new StreamWriter(".\\rehber.txt", true);
                    wbosluk3.Write(bosluk3);
                    wbosluk3.Close();

                    Console.Write("Telofon Numarası Giriniz: ");
                    tel = Convert.ToString(Console.ReadLine());
                    StreamWriter wtel = new StreamWriter(".\\rehber.txt", true);
                    wtel.WriteLine(tel);
                    wtel.Close();

                    Console.WriteLine(isim + " başarıyla eklenmiştir!");
                }

                else if (giris==2)
                {
                    Console.Write("Silinecek kişinin İsmini Giriniz: ");
                    sil = Convert.ToString(Console.ReadLine());
                    sil = "#"+sil;
                    string[] lines = System.IO.File.ReadAllLines(".\\rehber.txt", Encoding.Default);
                    List<String> liste = new List<String>();
                    foreach (string line in lines)
                    {
                        string[] _line = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        if (_line[0] != sil)
                        {
                            liste.Add(line);
                        }
                    }
                    System.IO.File.WriteAllLines(".\\rehber.txt", liste.ToArray(), Encoding.Default);
                }
                else if (giris == 3)
                {
                    Console.Write("Güncellenecek kişinin İsmini Giriniz: ");
                    sil = Convert.ToString(Console.ReadLine());
                    sil = "#" + sil;
                    string[] lines = System.IO.File.ReadAllLines(".\\rehber.txt", Encoding.Default);
                    List<String> liste = new List<String>();
                    foreach (string line in lines)
                    {
                        string[] _line = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        if (_line[0] != sil)
                        {
                            liste.Add(line);
                        }
                    }
                    System.IO.File.WriteAllLines(".\\rehber.txt", liste.ToArray(), Encoding.Default);
                    bosluk = Convert.ToString("#");
                    StreamWriter wbosluk = new StreamWriter(".\\rehber.txt", true);
                    wbosluk.Write(bosluk);
                    wbosluk.Close();
                    Console.WriteLine("Güncellenecek Kişi Bilgileri:");
                    Console.Write("İsim Giriniz: ");
                    isim = Convert.ToString(Console.ReadLine());
                    StreamWriter wisim = new StreamWriter(".\\rehber.txt", true);
                    wisim.Write(isim);
                    wisim.Close();

                    bosluk2 = Convert.ToString(" #");
                    StreamWriter wbosluk2 = new StreamWriter(".\\rehber.txt", true);
                    wbosluk2.Write(bosluk2);
                    wbosluk2.Close();

                    Console.Write("Soyisim Giriniz: ");
                    soyisim = Convert.ToString(Console.ReadLine());
                    StreamWriter wsoyisim = new StreamWriter(".\\rehber.txt", true);
                    wsoyisim.Write(soyisim);
                    wsoyisim.Close();

                    bosluk3 = Convert.ToString(" #");
                    StreamWriter wbosluk3 = new StreamWriter(".\\rehber.txt", true);
                    wbosluk3.Write(bosluk3);
                    wbosluk3.Close();

                    Console.Write("Telofon Numarası Giriniz: ");
                    tel = Convert.ToString(Console.ReadLine());
                    StreamWriter wtel = new StreamWriter(".\\rehber.txt", true);
                    wtel.WriteLine(tel);
                    wtel.Close();

                }
                else if (giris == 4)
                {
                    Console.WriteLine("\nKişi Listesi:");
                    StreamReader srd = new StreamReader(".\\rehber.txt");
                    while (srd.EndOfStream == false)
                    {
                        satir = srd.ReadLine();
                        Console.WriteLine(satir);
                    }
                    srd.Close();
                    Console.Write("\n");
                }
                
            }
        }
    }
}
