using modul5_103022300084;

class Program
{
    static void Main(string[] args)
    {
        PemrosesData data = new PemrosesData();
        data.DapatkanNilaiTerbesar(1030, 2230, 0084);
        
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(1030);
        db.AddNewData(2230);
        db.AddNewData(0084);
        db.PrintAllData();

        SimpleDataBase<String> dataString = new SimpleDataBase<String>();
        dataString.PrintAllData();
    }
}