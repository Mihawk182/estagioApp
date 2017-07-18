using SQLite.Net;

namespace ControLab
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
        SQLiteConnection GetConnection(string DBFileName);
        string GetDBPath();
        void SaveDBFile(string fileName, byte[] file);
        bool FileExists(string fileName);
    }
}
