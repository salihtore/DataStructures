// 1-) lineer probing : eger yer doluysa bir sonraki adrese bakar

public class LineerProbing
{

    //yerin bos oldugnu anlamak icin int? (nullable int) kullanıyoruz ki bos yerler null dönsün
    private int?[] tablo = new int?[10];
    private int TABLO_BOYUTU = 10;

    // temel hash fonksiyonu
    private int Hash1(int anahtar) => anahtar % TABLO_BOYUTU;


    public void Ekle (int anahtar)
    {
        int indis = Hash1(anahtar);
        int i = 0; //deneme sayacı

        //kontrol döngüsü : yer boş olana kadar döner.
        while(tablo[indis] != null)
        {
            i++ ;
            indis = (Hash1(anahtar) + i) % TABLO_BOYUTU;

            if (i == TABLO_BOYUTU)
            {
                Console.WriteLine("bos yer yok");
                return;
            }
        }

        tablo[indis] = anahtar;
    }
}


// 2-) Quadratic Probing : eger yer doluysa karesel olarak sonraki yerlere bakar
public class QuadraticProbing
{
    private int?[] tablo = new int?[10];
    private int TABLO_BOYUTU = 10;

    private int Hash1(int anahtar) => anahtar % TABLO_BOYUTU;

    public void Ekle(int anahtar)
    {
        int indis = Hash1(anahtar);
        int i = 0; 

        while (tablo[indis] != null)
        {
            i++; 
            // lineer probingden tek farkı burada i*i yapıyor
            indis = (Hash1(anahtar) + (i * i)) % TABLO_BOYUTU; 

            if (i == TABLO_BOYUTU) return; 
        }

        tablo[indis] = anahtar;
    }
}