using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace WinFormsAppDemo.mod
{
    internal class db
    {
        public LiteDatabase DB;
        public db() {
            DB = new(@"data.db");
        
        }
        public void Save(DbData obj) {
            var data = DB.GetCollection<DbData>();
            data.DeleteAll();
            data.Insert(obj);
        }
        public String Load() {
            var data = DB.GetCollection<DbData>();
            DbData[] texts = data.FindAll().ToArray();
            String ret = texts.Length > 0 ? texts[0].text : "";
            return ret;
        }
    }
}
