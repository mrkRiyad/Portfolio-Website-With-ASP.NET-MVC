Drop Database ScratchPortfolio
GO
Create Database ScratchPortfolio
GO
Use ScratchPortfolio
GO
Create Table Projects (
    ProjectID int Identity,
    ProjecName varchar(100) not null,
    ProjectDescription text null,
    ProjectTechnology varchar(255) null,
    DisplayOrder int null,
    IsActive bit null,
    Primary Key(ProjectID)
)
GO
Create Table Categories (
    CategoryID int Identity,
    CatName varchar(100) not null,
    DisplayOrder int null,
    IsActive bit null,
    Primary Key(CategoryID)
)
Go
Create Table CatProjectRef (
    CPRID int Identity,
    fkProjectID int not null,
    fkCategoryID int not null,
    Primary Key(CPRID),
    Foreign Key(fkProjectID) References Projects(ProjectID),
    Foreign Key(fkCategoryID) References Categories(CategoryID),
)
GO
Create Table MediaGalleries (
    MGID int Identity,
    Caption varchar(255) null,
    FilePathOrLink varchar(255) not null,
    IsDefault bit null,
    IsThumbnail bit null,
    IsActive bit null,
    Primary Key(MGID)
)
GO
Create Table ProductGalleryRef (
    PGRID int Identity,
    fkProjectID int not null,
    fkMGID int not null,
    Primary Key(PGRID),
    Foreign Key(fkProjectID) References Projects(ProjectID),
    Foreign Key(fkMGID) References MediaGalleries(MGID)
)
GO
Create Table Services (
    ServiceID int Identity,
    ServiceName varchar(100) not null,
    ServiceDescription text not null,
    Icon varchar(25) null,
    DisplayOrder bit null,
    IsActive bit null,
    Primary Key(ServiceID)
)
GO
Create Table Sliders (
    SliderID int Identity,
    SliderTitle varchar(100) not null,
    SliderDescription varchar(300) null,
    SliderImageUrl varchar(255) not null,
    DisplayOrder bit null,
    IsActive bit null,
    Primary Key(SliderID)
)