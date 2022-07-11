using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Tren_win_form.Data
{
    class ApplicationContecst:DbContext
    {
        public DbSet<Food> Foods { get; set; }

        //DefaultConnection взято из строки родключения app.config
        public ApplicationContecst() : base("DefaultConnection") { }
    }
}
