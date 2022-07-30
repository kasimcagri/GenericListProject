using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Collections
{
    public interface IFunctions<T>
    {
        void Sil(int index);
        void Ekle(T newElement);

        int BastanAra(T value);

        void Temizle();

        int SondanAra(T value);

        void Boyutlandır();

        void DiziCevir();

        int ElemanSayisi { get; }


    }
}
