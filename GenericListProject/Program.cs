using Project.Collections;

public class Program
{
    static void Main(string[] args)
    {
        
        IFunctions<string> kullan = new GenericListFunctions<string>();

        kullan.Ekle("Çağrı");
        kullan.Ekle("Ahmet");
        kullan.Ekle("Mehmet");
        kullan.Ekle("Arda");
        kullan.Ekle("Fikri");
        Console.WriteLine("Eleman Sayısı: {0}", kullan.ElemanSayisi);

        kullan.Sil(2);
        string[] dizi = { "Ahmet", "Çağrı", "Mehmet", "Çağrı", "Fikri" };
        //int sonuc = kullan.BastanAra(dizi, "Hayri");
        //Console.WriteLine(sonuc);
        //int sonuc1 = kullan.SondanAra(dizi, "Mehmet1");
        //Console.WriteLine(sonuc1);




        Console.ReadKey();

    }
}
