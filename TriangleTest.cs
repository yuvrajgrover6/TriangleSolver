using NUnit.Framework;

[TestFixture]
public class TriangleTests
{
    // 1. Equilateral Triangle Test (All sides are equal)
    [Test]
    public void Check_Sides_Are_Equal()
    {
        // Arrange
        int side1 = 3;
        int side2 = 3;
        int side3 = 3;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Equilateral", result);
    }

    // 2. Isosceles Triangle Test (Two sides are equal)
    [Test]
    public void Check_Two_Sides_Are_Equal()
    {
        // Arrange
        int side1 = 5;
        int side2 = 5;
        int side3 = 8;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Isosceles", result);
    }

    // 3. Scalene Triangle Test (All sides are different)
    [Test]
    public void All_Sides_Are_Different()
    {
        // Arrange
        int side1 = 3;
        int side2 = 4;
        int side3 = 5;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Scalene", result);
    }

    // 4. Not a Triangle (Sum of two sides is less than or equal to the third side)
    [Test]
    public void Check_Not_A_Triangle()
    {
        // Arrange
        int side1 = 1;
        int side2 = 2;
        int side3 = 3;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Not a Triangle", result);
    }

    // 5. Equilateral Triangle Test with larger values
    [Test]
    public void DetermineTriangleType_WhenLargeEqualSides_ShouldReturnEquilateral()
    {
        // Arrange
        int side1 = 1000;
        int side2 = 1000;
        int side3 = 1000;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Equilateral", result);
    }

    // 6. Isosceles Triangle Test with larger values
    [Test]
    public void DetermineTriangleType_WhenLargeTwoSidesEqual_ShouldReturnIsosceles()
    {
        // Arrange
        int side1 = 1200;
        int side2 = 1200;
        int side3 = 500;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Isosceles", result);
    }

    // 7. Scalene Triangle Test with larger values
    [Test]
    public void DetermineTriangleType_WhenLargeDifferentSides_ShouldReturnScalene()
    {
        // Arrange
        int side1 = 1200;
        int side2 = 1500;
        int side3 = 1700;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Scalene", result);
    }

    // 8. Negative Side Length (Invalid input)
    [Test]
    public void DetermineTriangleType_WhenNegativeSideLength_ShouldReturnInvalidInput()
    {
        // Arrange
        int side1 = -3;
        int side2 = 4;
        int side3 = 5;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Invalid Input", result);
    }

    // 9. Zero Side Length (Invalid input)
    [Test]
    public void DetermineTriangleType_WhenZeroSideLength_ShouldReturnInvalidInput()
    {
        // Arrange
        int side1 = 0;
        int side2 = 4;
        int side3 = 5;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Invalid Input", result);
    }

    // 10. One side greater than sum of other two (Not a Triangle)
    [Test]
    public void DetermineTriangleType_WhenOneSideGreaterThanSum_ShouldReturnNotATriangle()
    {
        // Arrange
        int side1 = 10;
        int side2 = 2;
        int side3 = 3;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Not a Triangle", result);
    }

    // 11. Floating-point values rounded down (Should not be a triangle)
    [Test]
    public void DetermineTriangleType_WhenSidesFormNoTriangle_ShouldReturnNotATriangle()
    {
        // Arrange
        int side1 = 2;
        int side2 = 2;
        int side3 = 5;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Not a Triangle", result);
    }

    // 12. Very small numbers (Valid equilateral triangle)
    [Test]
    public void DetermineTriangleType_WhenSmallEqualSides_ShouldReturnEquilateral()
    {
        // Arrange
        double side1 = 0.5;
        double side2 = 0.5;
        double side3 = 0.5;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Equilateral", result);
    }

    // 13. Isosceles Triangle with decimals
    [Test]
    public void DetermineTriangleType_WhenTwoDecimalSidesEqual_ShouldReturnIsosceles()
    {
        // Arrange
        double side1 = 7.5;
        double side2 = 7.5;
        double side3 = 10;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Isosceles", result);
    }

    // 14. Scalene Triangle with decimals
    [Test]
    public void DetermineTriangleType_WhenDifferentDecimalSides_ShouldReturnScalene()
    {
        // Arrange
        double side1 = 6.7;
        double side2 = 8.9;
        double side3 = 10.1;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Scalene", result);
    }

    // 15. Extremely large numbers (Scalene triangle)
    [Test]
    public void DetermineTriangleType_WhenExtremelyLargeSides_ShouldReturnScalene()
    {
        // Arrange
        int side1 = 1000000000;
        int side2 = 1000000001;
        int side3 = 1000000002;

        // Act
        string result = TriangleSolver.DetermineTriangleType(side1, side2, side3);

        // Assert
        Assert.AreEqual("Scalene", result);
    }
}
