class Ucgen
{
    public void DikUcgen(int yukseklik)
    {
        for (int i = 1; i <= yukseklik; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }

    public void SagaYatikUcgen(int yukseklik)
    {
        for (int i = 1; i <= yukseklik; i++)
        {
            Console.Write(new string(' ', yukseklik - i));
            Console.WriteLine(new string('*', i));
        }
    }

    public void SolaYatikUcgen(int yukseklik)
    {
        for (int i = yukseklik; i > 0; i--)
        {
            Console.Write(new string(' ', yukseklik - i));
            Console.WriteLine(new string('*', i));
        }
    }

    public void TersUcgen(int yukseklik)
    {
        for (int i = yukseklik; i > 0; i--)
        {
            Console.WriteLine(new string('*', i));
        }
    }
}