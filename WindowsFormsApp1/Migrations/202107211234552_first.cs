namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SVs",
                c => new
                    {
                        MSSV = c.String(nullable: false, maxLength: 128),
                        NameSV = c.String(),
                        ID_Lop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MSSV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SVs");
        }
    }
}
