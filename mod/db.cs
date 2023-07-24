using LiteDB;

namespace WinFormsAppDemo.mod;
internal class db {
    //public LiteDatabase DB;
    public db() {
        //DB = new(@"data.db");

    }
    public void Save(DbData obj) {
        using (LiteDatabase DB = new(@"data.db")) {
            var data = DB.GetCollection<DbData>("theData");
            data.DeleteAll();
            data.Insert(obj);
        }
    }
    public String Load() {
        using (LiteDatabase DB = new(@"data.db")) {

            var data = DB.GetCollection<DbData>("theData");
            DbData[] texts = data.FindAll().ToArray();

            String ret = texts.Length > 0 ? texts[0].text : "";

            return ret;
        }
    }
}
