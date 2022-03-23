using System;

namespace OrderIn.Storage
{
    public class OrderInContext : DbContext
    {
        //Data to Save, DBSet
        DBSet<User> Users {get;set;}

        public PizzaWorldContext(DbContextOptions<PizzaWorldContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder build)
        {
            build.UseSqlServer("Server=tcp:pizzabox.database.windows.net,1433;Initial Catalog=PizzaBox;Persist Security Info=False;User ID=sqladmin;Password=Password12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        
    }
}
