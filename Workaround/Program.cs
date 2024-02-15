using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Vatandas vatandas1 = new Vatandas();

			Degiskenler();
			SelamVer(isim:"Yeşim");
			SelamVer();
			int sonuc= Topla(3,5);
			//Arrays
			string ogrenci1 = "Yesim";
			string ogrenci2 = "Ayse";

			string[] ogrenciler = new string[4];
			ogrenciler[0] = "Yesim";
			ogrenciler[1] = "Ayse";
			ogrenciler[2] = "Fatma";
			ogrenciler[3] = "yesim2"; 

			Person person1 = new Person();
			person1.FirstName = "yeso";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
				Console.WriteLine(ogrenciler[i]);
            }

			string[] sehirler1 = new[] { "ankara", "istanbul", "izmir" };
			string[] sehirler2 = new[] { "bursa", "antalya", "diyarbakır" };

			sehirler2 = sehirler1;
			sehirler1[0] = "adana";
			Console.WriteLine(sehirler2[0]);  //burada sonuc adanadır

			//fakat int double long gibi sayısal değerlerde farklıdır.



         

			//diziler yerine listeler de kullanılabilir 
			List<string> yeniSehirler1 = new List<string> {"adana1","istanbul","izmir"};
			yeniSehirler1.Add("bolu1");

			foreach (var sehir in yeniSehirler1)
			{
				Console.WriteLine(sehir);
			}

			/*  for (int i = 0; i < yeniSehirler1.Count; i++)
			  {
				  Console.WriteLine(yeniSehirler1[i]);
			  }*/


			PttManager pttManager = new PttManager(new ForeignerManager());
			pttManager.GiveMask(person1);


			Console.ReadLine();
		}

		//resharper??araştir
		
		static void SelamVer(string isim="isimsiz")//herhangi bir değer verilmediğinde isimsizi ekle
		{
			Console.WriteLine("Merhaba Yeşim"+isim);
		}

		static int Topla(int sayi1, int sayi2)
		{
			int sonuc = sayi1 + sayi2;
			Console.WriteLine("Toplam:"+sonuc);
			return sonuc;
		}









		private static void Degiskenler()
		{
			for (int i = 0; i < 9; i++)
			{
				Console.WriteLine("Hello, World!");
			}
			double tutar = 1000;
			Console.WriteLine(tutar * 0.13);
			Console.WriteLine(tutar * 0.19);
		}
	}

	public class Vatandas
	{
        public string Ad { get; set; }
		public string Soyad { get; set;}
		public int DogumYili { get; set;}
		public int TcNo { get; set; }


		//public ile dışarıdan erişim verdik
		/*public string ad = "Yeşim";
		public string soyad = "Gezici";
		public int dogumYili = 1999;
		public long tcNo = 1234478573849;*/
	}
}
