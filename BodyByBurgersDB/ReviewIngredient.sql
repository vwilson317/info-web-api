CREATE TABLE [dbo].[ReviewIngredient]
(
    ReviewId INT NOT NULL,
    IngredientId INT NOT NULL,
    CONSTRAINT PK_ReviewIngredient PRIMARY KEY (ReviewId, IngredientId),
    CONSTRAINT FK_ReviewIngredient_Review FOREIGN KEY (ReviewId) REFERENCES Review(Id) ON DELETE CASCADE,
    CONSTRAINT FK_ReviewIngredient_Ingredient FOREIGN KEY (IngredientId) REFERENCES Ingredient(Id) ON DELETE CASCADE
)