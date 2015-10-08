using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Market.Models
{

    //.NET Framework data-access tech = Entity Framework
    // development paradigm: Code First
    public class Books
    {
        [Key]
        public int userID { get; set; }
        public int ISBN { get; set; }
        public string Name { get; set; }  
        public string Author { get; set; }
        public DateTime Published { get; set; }
    }

    public class Bookimage
    {
        [Key]
        public int userID { get; set; }
        public int ISBN { get; set; }
        public string imgPath { get; set; }
    }

 


    /*
    class represents the Entity Framework movie database context,
    which handles fetching, storing, and updating Movie class instances in a database.
    The MovieDBContext derives from the DbContext base class provided by the Entity Framework.
    */


    public class BooksDBContext: DbContext
    {
        // inits a object of Books which contains the fields from the database.
        public DbSet<Books> Books { get; set; }
        public DbSet<Bookimage> Bookimage { get; set; }
        //Using Books to class to represent movies in a database.  Each instance of a 
        // Books object will correspond to a row within a database table.
        // each property of Books will map to a column
    }

}