using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace lig_turnuvası
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title=("YBS Turnuvası");
            Console.WriteLine("Rastgele lig turnuvamıza hoşgeldınız");
            Console.WriteLine("Katılan tüm takımlara YBS bölümü olarak başarılar dileriz");
            int gs = 0;
            int fb = 0;
            int bjk = 0;
            int ts = 0;
            int sayac = 1;
            
            int a1, a2, a3;
            int b1, b2, b3;
            int c1, c2, c3;
            int d1, d2, d3;
            Random r = new Random();
            if (sayac == 1)
            {
                a1 = r.Next(0, 6);
                b1 = r.Next(0, 6);
                c1 = r.Next(0, 6);
                d1 = r.Next(0, 6);
                Console.WriteLine("1. Hafta Skorları");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Galatasaray " + a1 + "-" + b1 + " FenerBahçe");
                if (a1 > b1)
                {
                    gs += 3;
                }
                if (b1 > a1)
                {
                    fb += 3;
                }
                if (a1 == b1)
                {
                    gs += 1;
                    fb += 1;
                }
                Console.WriteLine("Beşiktaş " + c1 + "-" + d1 + " Trabzonspor\n");
                if (c1 > d1)
                {
                    bjk += 3;
                }
                if (d1 > c1)
                {
                    ts += 3;
                }
                if (c1 == d1)
                {
                    ts += 1;
                    bjk += 1;
                }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 2)
            {
                a2 = r.Next(0, 6);
                b2 = r.Next(0, 6);
                c2 = r.Next(0, 6);
                d2 = r.Next(0, 6);
                Console.WriteLine("2. Hafta Skorları");
                Console.WriteLine("-------------------------------");

                Console.WriteLine("Fenerbahçe " + b2 + "-" + c2 + " Beşiktaş");
                if (b2 > c2)
                {
                    fb += 3;
                }
                if (c2 > b2)
                {
                    bjk += 3;
                }
                if (b2 == c2)
                {
                    bjk += 1;
                    fb += 1;
                }
                Console.WriteLine("Trabzonspor " + d2 + "-" + a2 + " Galatasaray\n");
                if (d2 > a2)
                {
                    ts += 3;
                }
                if (a2 > d2)
                {
                    gs += 3;
                }
                if (a2 == d2)
                {
                    gs++;
                    ts++;
                }
                sayac++;
                Console.ReadLine();
            }
            if (sayac == 3)
            {
                a3 = r.Next(0, 6);
                b3 = r.Next(0, 6);
                c3 = r.Next(0, 6);
                d3 = r.Next(0, 6);
                Console.WriteLine("3. Hafta Skorları");
                Console.WriteLine("-------------------------------");

                Console.WriteLine("Trabzonspor " + d3 + "-" + b3 + " FenerBahçe");
                if (d3 > b3)
                {
                    ts += 3;
                }
                if (b3 > d3)
                {
                    fb += 3;
                }
                if (b3 == d3)
                {
                    fb++;
                    ts++;
                }
                Console.WriteLine("Beşiktaş " + c3 + "-" + a3 + " Galatasaray\n");
                if (c3 > a3)
                {
                    bjk += 3;
                }
                if (a3 > c3)
                {
                    gs += 3;
                }
                if (c3 == a3)
                {
                    gs++;
                    bjk++;
                }
                sayac++;
                Console.ReadLine();
            }
            if (sayac == 4)
            {
                Console.WriteLine("Maçlar Tamamlandı...");
                Console.WriteLine("Puan Tablosu\n");
                Console.WriteLine("-------------------");
                Console.WriteLine("Galatasaray: " + gs);
                Console.WriteLine("Fenerbagçe: " + fb);
                Console.WriteLine("Beşiktaş: " + bjk);
                Console.WriteLine("Trabzonspor: " + ts);
            }
            SoundPlayer ses = new SoundPlayer();
            string yol;
            int enbuyuk = fb;
            if (gs > fb)
            {
                enbuyuk = gs;
                yol = @"C:\Users\reela\OneDrive\Masaüstü\gs.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }
            if (ts > enbuyuk)
            {
                enbuyuk = ts;
                yol = @"C:\Users\reela\OneDrive\Masaüstü\ts.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }
            if (bjk > enbuyuk)
            {
                enbuyuk = bjk;
                yol = @"C:\Users\reela\OneDrive\Masaüstü\bjk.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }
            else
            {
                yol = @"C:\Users\reela\OneDrive\Masaüstü\fb.wav";
                ses.SoundLocation = yol;
                ses.Play();
            }
            Console.Read();
        }
    }
}
