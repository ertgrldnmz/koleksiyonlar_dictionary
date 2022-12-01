using System.Collections;
internal class Program
{

    public static bool asalmi(int sayi)
        {
            bool durum = false;
            int kontrol = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) 
                {
                    kontrol = 1;
                    break;
                }
            }
            
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            return durum;
        }
        public void soru2()
        {
                int bort = 0, kort = 0, orttoplam = 0;
            int[] sayilar = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Lütfen {0}. Sayıyı Girin : ", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------");
            Array.Sort(sayilar);
            Console.WriteLine($"Dizinin 1. En Büyük Sayısı : {sayilar[19]}  \nDizinin 2. En Büyük Sayısı : {sayilar[18]} \nDizinin 3. En Büyük Sayısı : {sayilar[17]}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Dizinin 1. En Küçük Sayısı : {sayilar[0]}  \nDizinin 2. En Küçük Sayısı : {sayilar[1]} \nDizinin 3. En Küçük Sayısı : {sayilar[2]}");

            bort = (sayilar[19] + sayilar[18] + sayilar[17])/3;
            Console.WriteLine(" 3 En Büyük Sayıların Ortalaması =" + bort);
            kort = (sayilar[0] + sayilar[1] + sayilar[2]) / 3;
            Console.WriteLine(" 3 En Küçük Sayıların Ortalaması =" + kort);
            orttoplam = bort + kort;
            Console.WriteLine("Ortalamaların Toplamları = "+orttoplam);

            Console.ReadLine();

        }
       
        
        
        
        
        
        
        
        static void Main(string[] args)
        {
            int toplam = 0,  ortalama = 0;
            ArrayList asal = new ArrayList();
            ArrayList asalolmayan = new ArrayList();

            for (int i = 0; i < 20; i++)
            { 
            
        try{
            
                Console.Write("Lütfen {0}. Sayıyı Girin : ", i + 1);   
                var s = Convert.ToInt32(Console.ReadLine());
                                 
                     
              if (s%1==0&& s!=0&&s!=1&&s>0)
                {
                    toplam += s;
                    if (asalmi(s))
                    {
                        asal.Add(s);
                    }
                    else
                    {
                        asalolmayan.Add(s);
                    }
                }
                
                
               
                else
                {
                    Console.WriteLine("negatif sayıları ve 0 ve 1  girmeyiniz!!");
                    i--;
                }
                
                
            }
    catch(Exception)
            {
                Console.WriteLine("lütfen numerik bir sayı giriniz");
                i--;
                
            }                                                                
                
                }
                
                
                    
            
            Console.WriteLine("===========================");
            Console.WriteLine("ASAL SAYILAR");
            asal.Sort();
            foreach (int sayi in asal)
            {
                Console.WriteLine(sayi + "    ");
                toplam+=sayi;
                ortalama++;
            }
             Console.WriteLine("Sayıların Adedi:"+ortalama+"  Sayıların ortalaması:"+toplam/ortalama);
            
           
            
            
            
            
            
            Console.WriteLine("ASAL OLMAYAN SAYILAR");
            Console.WriteLine("===========================");
            
            asalolmayan.Sort();
            toplam=0; ortalama=0;
            foreach (int sayi in asalolmayan)
            {
                Console.WriteLine(sayi + "    ");
                toplam+=sayi;
                ortalama++;
            }
            Console.WriteLine("Sayıların Adedi:"+ortalama+"  Sayıların ortalaması:"+toplam/ortalama);
            
             Console.WriteLine("***************************");
            //soru2
            Program program=new Program();
            program.soru2();
            Console.WriteLine("***************************");
            program.soru3();
          
        }
        public void soru3()
        {
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<char> arr = new List<char>() { };
            Console.Write("Lütfen Cümle giriniz: ");
            string bul = Console.ReadLine().ToLower();
            foreach (char karakter in bul)
            {
                foreach (char item in sesliler)
                {
                    if (karakter == item)
                    {
                        arr.Add(karakter);
                    }
                }
            }
            foreach (char item in arr)
            {
                Console.Write( item+"-");
            }
            Console.ReadLine();

        }
        }
    




    
    
