using System;
using System.Collections.Generic;

class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara.";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun, ";
    }
}

class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    public override string Suara()
    {
        return "Mamalia ini bersuara.";
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $"Jumlah kaki: {JumlahKaki}.";
    }
}

class Reptil : Hewan
{
    public double PanjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override string Suara()
    {
        return "Reptil ini bersuara.";
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $"Panjang tubuh: {PanjangTubuh} meter.";
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override string Suara()
    {
        return "Singa mengaum.";
    }

    public void Mengaum()
    {
        Console.WriteLine($"{Nama} sedang mengaum.");
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override string Suara()
    {
        return "Gajah menderum.";
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Ular mendesissst.";
    }

    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang merayap.");
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Buaya bersuara 'Kalau aku chat kamu gini ada yang marah ngga'";
    }
}

class KebunBinatang
{
    public List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan()); 
            Console.WriteLine(hewan.Suara());
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Tio", 5, 4);
        Gajah gajah = new Gajah("Yuda", 10, 4);
        Ular ular = new Ular("Richie", 3, 2.5);
        Buaya buaya = new Buaya("Ken", 7, 4.5);
        Reptil reptil = new Buaya("Almas", 8, 2.3); //Untuk soal No.5

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);
        kebunBinatang.TambahHewan(reptil); //Untuk soal No.5

        kebunBinatang.DaftarHewan();

        Console.WriteLine("\nDemonstrasi Polymorphism:");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara()); 
        Console.WriteLine(buaya.Suara()); 
        Console.WriteLine(reptil.Suara()); //Untuk soal No.5

        Console.WriteLine("\nMethod Khusus:");
        singa.Mengaum();
        ular.Merayap();
    }
}
