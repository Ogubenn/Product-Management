namespace MethotExample;
class Program:EmptyClass//kalıtım işlemi,kalıtım dosyalar arası erişimi sağlar
{
    static void Main(string[] args)
    {
        //Methodlar
        //1. Değer almayan değer döndürmeyen void methodlar(void)
        //2. Değer alan ama dönüş değeri döndürmeyen(Parametre + void)
        //3.Değer almayan ama değer döndüren method(Return)
        //4.Değer alan ve değer döndüren method(Parametre + return )
        //5.Consturctor metot (classın kendisinde türeyen metot)

        //Methot erişim türleri
        //1.Public = Genel kullanıma açık metot erişim türü
        //2.Private = Sadece kendi classı içinde çalışan metot erişim türü
        //3.Static = Classa gömülü ya da çakılı metot
        //4.Protected = Kalıtım şle başka classlarda kullanılan metot erişim türü

        Program program = new Program();
        program.metot1();
        program.metot2("Ogu");
        int deger = program.metot3();
        string returnDizi = program.metot4("Ogu");
    }
    public void metot1()
    {
        Console.WriteLine("Metot1");
    }
    public void metot2(string name)
    {
        Console.WriteLine("Metot2");
    }
    public int metot3()
    {
        return 10;
    }
    public string metot4(string dizi)
    {
        return "Gelen Değer : " + dizi;
    }

    //Erişim Türlerine göre metot kullanımı

    public static void metot5()
    {
        Console.WriteLine("Ogu");
    }
    private List<string> _liste = new List<string>();

    public List<string> Liste()
    {
        return _liste;
    }
    private void metot2()
    {

    }
    protected void metot3()
    {
        Console.WriteLine("yarı özel metot");
    }
}

