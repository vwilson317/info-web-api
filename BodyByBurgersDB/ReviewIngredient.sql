CREATE TABLE [dbo].[ReviewIngredient]
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ReviewId INT NOT NULL,
    IngredientId INT NOT NULL
)