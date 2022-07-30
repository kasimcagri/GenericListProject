using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Collections
{
    public class GenericListFunctions<T>:IFunctions<T>
    {
        private T[] dizi;
        private int elemanSayisi = 0;
        private int kapasite;

        public int ElemanSayisi => elemanSayisi;

        public GenericListFunctions(int baslangicBoyutu=8)
        {
            if (baslangicBoyutu<1)
            {
                baslangicBoyutu = 1;
            }
            this.kapasite = baslangicBoyutu;
            dizi = new T[baslangicBoyutu];
        }

        public void Ekle(T eleman)
        {
            if (elemanSayisi == kapasite)
            {
                Boyutlandır();
            }

            dizi[elemanSayisi] = eleman;
            elemanSayisi++;
        }

        public void Temizle()
        {
            dizi = new T[kapasite];
            elemanSayisi = 0;
        }

        public int BastanAra(T value) //IndexOf
        {
            int result = -1;
            for (int i = 0; i < elemanSayisi; i++)
            {
                T deger = dizi[i];
                if (deger.Equals(value))
                {
                    return i;
                }
            }
            return result;

        }
        public int SondanAra(T value)//lastindexof
        {
            int result = -1;
            int count = 0;
            for (int i = elemanSayisi - 1; i > 0; i--)
            {
                T deger = dizi[i];
                if (deger.Equals(value))
                {
                    return count;
                }
                count++;
            }
            return result;
        }

        public void Sil(int index)//remove
        {
            var yedekDizi = dizi;
            dizi = new T [yedekDizi.Length - 1];
            int sayac = 0;
            for (int i = 0; i < yedekDizi.Length; i++)
            {
                if (i == index)
                    continue;

                dizi[sayac] = yedekDizi[i];
                sayac++;
            }
        }
        //public void Sil(int index)
        //{
        //    ThrowIfIndexOutOfRange(index);
        //    for (int i = index; i < elemanSayisi - 1; i++)
        //    {
        //        dizi[i] = dizi[i + 1];
        //    }

        //    dizi[elemanSayisi - 1] = default(T);
        //    elemanSayisi--;
        //}


        public void Boyutlandır()
        {
            T[] yeniBoyutlu = new T[kapasite * 2];
            for (int i = 0; i < kapasite; i++)
            {
                yeniBoyutlu[i] = dizi[i];
            }
            dizi = yeniBoyutlu;
            kapasite = kapasite * 2;
        }
        public void DiziCevir()//reverse
        {
            var yedekdizi = dizi;
            int diziEleman = 0;
            for (int i = elemanSayisi - 1; i >= 0; i--)
            {
                dizi[diziEleman] = yedekdizi[i];
                diziEleman++;
            }
            Console.WriteLine(dizi[0]);
        }
    }
}
