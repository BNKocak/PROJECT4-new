using System;
using System.Data;
using System.IO;
using SQLite;

namespace sBike
{
    class DBAddress
    {
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int Id { get; set; }

        [MaxLength(50)]
        public string DBLocation { get; set; }
    }
}