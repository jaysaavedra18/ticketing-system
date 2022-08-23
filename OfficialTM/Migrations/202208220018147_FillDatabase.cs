namespace OfficialTM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillDatabase : DbMigration
    {
        public override void Up()
        {
            // data into dbo.ProjectModels

            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 1', 'This is a valuable and inuitive description of Project 1')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 2', 'This is a valuable and inuitive description of Project 2')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 3', 'This is a valuable and inuitive description of Project 3')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 4', 'This is a valuable and inuitive description of Project 4')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 5', 'This is a valuable and inuitive description of Project 5')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 6', 'This is a valuable and inuitive description of Project 6')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 7', 'This is a valuable and inuitive description of Project 7')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 8', 'This is a valuable and inuitive description of Project 8')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 9', 'This is a valuable and inuitive description of Project 9')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 10', 'This is a valuable and inuitive description of Project 10')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 11', 'This is a valuable and inuitive description of Project 11')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 12', 'This is a valuable and inuitive description of Project 12')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 13', 'This is a valuable and inuitive description of Project 13')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 14', 'This is a valuable and inuitive description of Project 14')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 15', 'This is a valuable and inuitive description of Project 15')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 16', 'This is a valuable and inuitive description of Project 16')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 17', 'This is a valuable and inuitive description of Project 17')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 18', 'This is a valuable and inuitive description of Project 18')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 19', 'This is a valuable and inuitive description of Project 19')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 20', 'This is a valuable and inuitive description of Project 20')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 21', 'This is a valuable and inuitive description of Project 21')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 22', 'This is a valuable and inuitive description of Project 22')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 23', 'This is a valuable and inuitive description of Project 23')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 24', 'This is a valuable and inuitive description of Project 24')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 25', 'This is a valuable and inuitive description of Project 25')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 26', 'This is a valuable and inuitive description of Project 26')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 27', 'This is a valuable and inuitive description of Project 27')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 28', 'This is a valuable and inuitive description of Project 28')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 29', 'This is a valuable and inuitive description of Project 29')");
            Sql("INSERT INTO dbo.ProjectModels(Name, Description) VALUES('Project 30', 'This is a valuable and inuitive description of Project 30')");

            // data into dbo.TicketModels

            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Bug Problems', 'Bugs in my PC', 'John Dev', 'Open', 1, 'Bug')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Front-End Update', 'Incompatible with mobile devices', 'John Dev', 'Closed', 3, 'Front-End')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Front-End Update', 'Incompatible with mobile devices', 'John Dev', 'Open', 3, 'Front-End')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Optimize Back-End', 'Goal is same execution with 70% of the overhead', 'John Dev', 'Closed', 4, 'Optimize')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Bug Problems', 'Bugs in my PC', 'John Dev', 'Open', 2, 'Bug')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Optimize Back-End', 'Goal is same execution with 70% of the overhead', 'John Dev', 'Closed', 3, 'Optimize')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Front-End Update', 'Incompatible with mobile devices', 'John Dev', 'Open', 3, 'Front-End')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('IT Problems', 'John from IT called me Fat', 'John Dev', 'Closed', 1, 'IT')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Optimize Back-End', 'Goal is same execution with 70% of the overhead', 'John Dev', 'Open', 2, 'Optimize')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Bug Problems', 'Bugs in my PC', 'John Dev', 'Closed', 2, 'Bug')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('IT Problems', 'John from IT called me Fat', 'John Dev', 'Open', 4, 'IT')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Bug Problems', 'Bugs in my PC', 'James Dev', 'Closed', 2, 'Bug')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Optimize Back-End', 'Goal is same execution with 70% of the overhead', 'James Dev', 'Open', 3, 'Optimize')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Front-End Update', 'Incompatible with mobile devices', 'James Dev', 'Closed', 3, 'Front-End')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Bug Problems', 'Bugs in my PC', 'James Dev', 'Open', 2, 'Bug')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Front-End Update', 'Incompatible with mobile devices', 'James Dev', 'Closed', 1, 'Front-End')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('IT Problems', 'John from IT called me Fat', 'James Dev', 'Closed', 3, 'IT')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('IT Problems', 'John from IT called me Fat', 'James Dev', 'Closed', 2, 'IT')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Bug Problems', 'Bugs in my PC', 'James Dev', 'Open', 4, 'Bug')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('IT Problems', 'John from IT called me Fat', 'James Dev', 'Open', 2, 'IT')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Optimize Back-End', 'Goal is same execution with 70% of the overhead', 'James Dev', 'Closed', 1, 'Optimize')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Front-End Update', 'Incompatible with mobile devices', 'Jane Dev', 'Closed', 1, 'Front-End')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('IT Problems', 'John from IT called me Fat', 'Jane Dev', 'Open', 3, 'IT')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Optimize Back-End', 'Goal is same execution with 70% of the overhead', 'Jane Dev', 'Closed', 2, 'Optimize')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Bug Problems', 'Bugs in my PC', 'Jane Dev', 'Closed', 1, 'Bug')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('IT Problems', 'John from IT called me Fat', 'Jane Dev', 'Open', 4, 'IT')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Front-End Update', 'Incompatible with mobile devices', 'Jane Dev', 'Closed', 1, 'Front-End')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Bug Problems', 'Bugs in my PC', 'Jane Dev', 'Closed', 2, 'Bug')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Front-End Update', 'Incompatible with mobile devices', 'Jane Dev', 'Closed', 1, 'Front-End')");
            Sql("INSERT INTO dbo.TicketModels(Title, Description, Submitter, Status, Priority, Type) VALUES('Optimize Back-End', 'Goal is same execution with 70% of the overhead', 'Jane Dev', 'Open', 3, 'Optimize')");



        }

        public override void Down()
        {
        }
    }
}
