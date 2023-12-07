namespace StructKavrami;

class Program
{
    
    static void Main(string[] args)
    {
        //Sınıflar Referans tipindedir. Structlar ise Değer tipindedir.

        Dikdörtgen n1 = new Dikdörtgen();
        n1.kısaK=5;
        n1.uzunK=4;

        Console.WriteLine("Alan: "+n1.AlanHesapla());

        Dikdörtgen_Struct dikdörtgen_Struct = new Dikdörtgen_Struct(); //Bu Şekilde de yapabilirsin.
        //Dikdörtgen_Struct dikdörtgen_Struct; // Struct larda new kullanmadan da nesne oluşturup kullanabilirsin.
        // dikdörtgen_Struct.kısaK=5;
        // dikdörtgen_Struct.uzunK=4;
        Console.WriteLine("Alan: "+dikdörtgen_Struct.AlanHesapla());
    }
}

class Dikdörtgen
{

    public Dikdörtgen() 
    {
        kısaK=2;
        kısaK=5;
    }
    public int kısaK;
    public int uzunK;
    public long AlanHesapla()
    {
        return this.kısaK* this.uzunK;
    }
}

struct Dikdörtgen_Struct
{

    public Dikdörtgen_Struct()
    {
        kısaK=5;
        uzunK=5;
    }

    public int kısaK;
    public int uzunK;
    public long AlanHesapla()
    {
        return this.kısaK* this.uzunK;
    }
}
