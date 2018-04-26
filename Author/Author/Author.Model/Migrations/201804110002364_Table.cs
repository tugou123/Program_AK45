namespace Author.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        RoleName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserRoleId = c.Long(nullable: false),
                        UserCode = c.String(),
                        UserName = c.String(),
                        Pwd = c.String(),
                        Phone = c.String(),
                        Mail = c.String(),
                        ImageHeadPortrait = c.String(),
                        ImageFacadeIDcard = c.String(),
                        ImageBackIDcard = c.String(),
                        CreateUserId = c.Long(),
                        IsDelete = c.Boolean(nullable: false),
                        DeleteUserId = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        LoginCount = c.Int(nullable: false),
                        LastLoginTime = c.DateTime(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UsersDetails",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IP = c.String(),
                        HostName = c.String(),
                        LastLoginTime = c.DateTime(),
                        StartlandingTime = c.DateTime(),
                        UsersInfoId = c.Long(nullable: false),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UsersInfoId, cascadeDelete: true)
                .Index(t => t.UsersInfoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersDetails", "UsersInfoId", "dbo.Users");
            DropIndex("dbo.UsersDetails", new[] { "UsersInfoId" });
            DropTable("dbo.UsersDetails");
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
        }
    }
}
