namespace TwoNumOp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TryGetOperation_Given_Null_Should_ReturnFalse()
        {
            //Arrange
            string? input = null;

            //Act
            var result = Program.TryGetOperation(input, out var operationType);
            
            //Assert
            Assert.False(result);
            Assert.Null(operationType);
        }

        [Theory]
        [InlineData("Add", OperationTypes.Add)]
        [InlineData("Addition", OperationTypes.Add)]
        [InlineData("+", OperationTypes.Add)]
        [InlineData("Subtract", OperationTypes.Subtract)]
        [InlineData("subtract", OperationTypes.Subtract)]
        [InlineData("subtraction", OperationTypes.Subtract)]
        [InlineData("-", OperationTypes.Subtract)]
        [InlineData("Multiply", OperationTypes.Multiply)]
        [InlineData("multiplication", OperationTypes.Multiply)]
        [InlineData("*", OperationTypes.Multiply)]
        [InlineData("x", OperationTypes.Multiply)]
        [InlineData("Divide", OperationTypes.Divide)]
        [InlineData("division", OperationTypes.Divide)]
        [InlineData("/", OperationTypes.Divide)]
        public void TryGetOperation_Given_ValidInput_ShouldPutOut_ExpectedOperationType(string input, OperationTypes expectedOperationType)
        {
            //Arrange
            OperationTypes? actualType = null;

            //Act
            var result = Program.TryGetOperation(input, out actualType);

            //Assert
            Assert.True(result);
            Assert.Equal(expectedOperationType, actualType);

        }
    }
}