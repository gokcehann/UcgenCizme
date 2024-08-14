//13.08.2024 Bu uygulama konsolda normal, sağa ve sola yatık, ters üçgen ve kalp çizdirir. 
//Gökçehan Özdemir

using System;

namespace UcgenCizdirme
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen çizmek istediğiniz şekli giriniz: ");
            Console.WriteLine("1)Dik Üçgen\n2)Sağa Yatık Üçgen\n3)Sola Yatık Üçgen\n4)Ters Üçgen");
            var secenek = Console.ReadLine();
            Ucgen ucgenTipi = new Ucgen();

            if (secenek=="1" || secenek=="2" || secenek=="3"|| secenek == "4") { 
                Console.WriteLine("Lütfen üçgenin yüksekliğini belirleyiniz: ");
                var yukseklik = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                switch (secenek)
                {
                    case "1":
                        ucgenTipi.DikUcgen(yukseklik);
                        break;

                    case "2":
                        ucgenTipi.SagaYatikUcgen(yukseklik);
                        break;
                    case "3":
                        ucgenTipi.SolaYatikUcgen(yukseklik);
                        break;
                    case "4":
                        ucgenTipi.TersUcgen(yukseklik);
                        break;
                }
            }
            else
            {
                throw new ArgumentException("Geçersiz bir parametre girdiniz. ");
            }
        }
        
    }
}