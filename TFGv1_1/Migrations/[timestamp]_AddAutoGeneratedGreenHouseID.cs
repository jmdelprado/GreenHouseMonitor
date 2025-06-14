using System.Data.Entity.Migrations;

public partial class AddAutoGeneratedGreenHouseID : DbMigration
{
    public override void Up()
    {
        DropPrimaryKey("dbo.GreenHouses");
        AlterColumn("dbo.GreenHouses", "GreenHouseID", c => c.Int(nullable: false, identity: true));
        AddPrimaryKey("dbo.GreenHouses", "GreenHouseID");
    }
    
    public override void Down()
    {
        DropPrimaryKey("dbo.GreenHouses");
        AlterColumn("dbo.GreenHouses", "GreenHouseID", c => c.Int(nullable: false));
        AddPrimaryKey("dbo.GreenHouses", "GreenHouseID");
    }
} 