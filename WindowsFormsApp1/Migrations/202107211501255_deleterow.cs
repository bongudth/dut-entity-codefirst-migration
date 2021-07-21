namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleterow : DbMigration
    {
        public override void Up()
        {
            Sql("delete from SVs where MSSV = '4'");
        }
        
        public override void Down()
        {
        }
    }
}
