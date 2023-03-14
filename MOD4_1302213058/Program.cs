// See https://aka.ms/new-console-template for more information
public class KodeBuah
{
    public enum Buah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma,
        Durian, Anggur, Melon, Semangka
    };
    public static string GetKodeBuah(Buah bh)
    {
        string[] Kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00",
            "L00", "M00", "N00", "O00"};
        return Kodebuah[(int)bh];
    }
}

public class PosisiKarakterGame
{
    enum state { berdiri, tengkurap};

    public static void Main()
    {
        Console.WriteLine("Nama Buah " + KodeBuah.Buah.Apel);
        Console.WriteLine("Kode Buah " + KodeBuah.GetKodeBuah(KodeBuah.Buah.Apel));
        Console.WriteLine();

        state state1 = state.berdiri;
        string[] kondisi = { "Posisi Standby", "Posisi istirahat" };
        while(state1 != null)
        {
            Console.WriteLine(kondisi[(int)state1]);
            Console.WriteLine() ;
            Console.WriteLine("Masukan Perintah : ");

            string perintah = Console.ReadLine();

            switch (state1)
            {
                case state.berdiri:
                    if(perintah == "Berdiri")
                    {
                        state1 = state.berdiri;
                    }
                    else if (perintah == "Tengkurap")
                    {
                        state1 = state.tengkurap;
                    }
                    else
                    {
                        state1 = state.berdiri;
                        Console.WriteLine("Perintah tidak sesuai");
                    }
                    Console.WriteLine();
                    break;
                case state.tengkurap:
                    if(perintah == "Berdiri")
                    {
                        state1 = state.berdiri;
                    }
                    else if(perintah == "Tengkurap")
                    {
                        state1 = state.tengkurap;
                    }
                    else
                    {
                        state1 = state.tengkurap;
                        Console.WriteLine("Perintah tidak sesuai");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
            }
        }
    }
}