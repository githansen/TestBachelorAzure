namespace TestBachelorAzure.Data
{
    public class DBInit
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DB>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var p = new Person()
                {
                    fornavn = "Kjell-Bjarne",
                    etternavn = "Mathisen"
                };
                context.Add(p);
                var p2 = new Person()
                {
                    fornavn = "Petter",
                    etternavn = "Hansen"
                };
                context.Add(p2);
                context.SaveChanges();
            }
        }

    }
}

