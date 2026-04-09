/* ALGORİTMA ANALİZİ VE KARMASİKLİK

(Big-O)Her şey "En iyi kod hangisi?" sorusuyla başlar. 
Bir algoritmanın başarısı, veri miktarı ($n$) arttığında harcadığı zaman ve bellek ile ölçülür.
Big-O ($O$): Algoritmanın "en kötü durum" (worst case) performansını gösterir.
Sık Karşılaşılan Karmaşıklıklar:

$O(1)$: Sabit zaman (Dizi indeksiyle eleman okuma).
$O(n)$: Doğrusal zaman (Dizi içinde arama yapma).
$O(n^2)$: Karesel zaman (İç içe iki döngü). */

using System.Collections.Concurrent;

int [] sayilar = { 10, 20, 30, 40, 50 };

// O(1) örneği : indis ile erişim (anında)
int rakam = sayilar[2];

// O(n) örneği : arama (döngü n kadar döner)
for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] == 40) Console.WriteLine("Bulundu" + sayilar[i]);
}

/* BAGLİ LİSTELER (Linked Lists)


Dizilerin "sabit boyut" ve "araya eleman ekleme zorluğu" problemlerini çözmek için doğmuştur. 
Bellekte veriler dağınıktır; her veri (Node), kendinden sonrakinin adresini tutar.

Tek Yönlü Bağlı Liste (Singly Linked List): */

public class Dugum
{
    public int Veri;
    public Dugum Sonraki; //bir sonraki node'u gösteren referans 
}

public class BagliListe
{
    public Dugum Head; //listenin baslangic noktasi

    public void BasaEkle(int yeniVeri)
    {
        Dugum yeni = new Dugum{Veri = yeniVeri };
        yeni.Sonraki = Head;
        Head = yeni; //yeni eleman listenin başı oldu
    }
}


/* YİGİT (Stack)


LIFO (Last In, First Out) prensibiyle çalışır. 
En son giren, ilk çıkar. 
"Undo" (Geri Al) sistemleri veya parantez kontrolü için kullanılır.

Dizi Tabanlı Stack: */


public class StackYapisi
{
    private int[] dizi = new int[100];
    private int tepe = -1;

    public void Push(int veri)
    {
        if (tepe == 99) return; //owerflow
        dizi[++tepe] = veri; //önce artır, sonra ekle

    }

    public int Pop()
    {
        if (tepe == -1) return -1; //underflow
        return dizi[tepe--]; //veriyi ver, sonra tepeyi düşür
    }
}

/* KUYRUK  (Queue)


FIFO (First In, First Out) prensibiyle çalışır. 
İlk gelen, ilk çıkar. 
İşlemci zamanlaması veya yazıcı kuyrukları temel uygulama alanıdır.

Çevrimsel Kuyruk (Circular Queue):
Doğrusal dizilerde en öndeki eleman çıktığında oluşan boşluğu 
kullanabilmek için dizinin sonundan başına "atlama" yapılır. */

public class Kuyruk
{
    private int[] dizi = new int[5];
    private int bas = 0, son = -1, sayac = 0;

    public void Enqueue(int veri)
    {
        if (sayac == 5) return; //dolu

        // çevrimsel ilerleme formülü
        son = (son + 1) % 5;
        dizi[son] = veri;
        sayac++;
    }

    public int Dequeue()
    {
        if(sayac == 0) return -1;

        int veri = dizi[bas];
        bas = (bas + 1) % 5; //başı da dairesel ilerlet
        sayac--;
        return veri;
    }
}