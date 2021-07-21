namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsApp1.CSDL>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WindowsFormsApp1.CSDL context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.SVs.AddOrUpdate(p => p.MSSV,
                new SV()
                {
                    MSSV = "1",
                    NameSV = "NVA",
                    ID_Lop = 1
                },
                new SV()
                {
                    MSSV = "2",
                    NameSV = "NVB",
                    ID_Lop = 2
                },
                new SV()
                {
                    MSSV = "3",
                    NameSV = "NVC",
                    ID_Lop = 1
                }
            );
        }
    }
}
