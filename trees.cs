// 1-) Node Design 

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class AgacDugumu
{
    public int veri;
    public AgacDugumu Sol;
    public AgacDugumu Sag;

    public AgacDugumu(int deger)
    {
        veri = deger;
        Sol = null;
        Sag = null;
    } 
}


// 2-) Binary Search Tree
public class İkiliAgac
{

    public AgacDugumu Kok;

    public void Ekle (int veri)
    {
        Kok = EkleRecursive(Kok, deger);
    }


    private AgacDugumu EkleRecursive(AgacDugumu suanki, int deger)
    {
        if (suanki == null)
        return new AgacDugumu(deger);

        if (deger < suanki.veri)
        suanki.Sol = EkleRecursive(suanki.Sol, deger);

        if (deger > suanki.veri)
        suanki.Sag = EkleRecursive(suanki.Sag, deger);

        return suanki;
        
    }
}