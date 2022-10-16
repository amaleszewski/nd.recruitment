using System;
using FluentAssertions;
using ND.Recruitment.Domain;
using Xunit;

namespace ND.Recruitment.Tests.Domain;

public class DiamondTests
{
    [Theory]
    [InlineData('a')]
    [InlineData('b')]
    [InlineData('y')]
    [InlineData('z')]
    [InlineData('!')]
    [InlineData('@')]
    public void Diamond_CharacterOutOfRange_ShouldThrowAnArgumentOutOfRangeException(char character)
    {
        Action act = () => new Diamond(character);

        act.Should().Throw<ArgumentOutOfRangeException>().WithMessage("Character is out of range. Please use a letter from 'A' to 'Z'");
    }
    
    [Theory]
    [InlineData('A')]
    [InlineData('B')]
    [InlineData('C')]
    [InlineData('X')]
    [InlineData('Y')]
    [InlineData('Z')]
    public void Diamond_CharacterInRange_ShouldHaveLineBreaksTwiceAsCharacterPosition(char character)
    {
        var diamond = new Diamond(character);

        diamond.ToString().Should().Contain(Environment.NewLine, Exactly.Times((character - 65) * 2));
    }
    
    [Fact]
    public void Diamond_A_ShouldPrintOnlyA()
    {
        var diamond = new Diamond('A');

        diamond.ToString().Should().Be("A");
    }

    [Fact]
    public void Diamond_B_ShouldPrintDiamond()
    {
        var diamond = new Diamond('B');

        diamond
            .ToString()
            .Should()
            .Be(
                " A " + Environment.NewLine +
                "B B" + Environment.NewLine +
                " A ");
    }
    
    [Fact]
    public void Diamond_C_ShouldPrintDiamond()
    {
        var diamond = new Diamond('C');

        diamond
            .ToString()
            .Should()
            .Be(
                "  A  " + Environment.NewLine +
                " B B " + Environment.NewLine +
                "C   C" + Environment.NewLine +
                " B B " + Environment.NewLine +
                "  A  ");
    }
    
    [Fact]
    public void Diamond_D_ShouldPrintDiamond()
    {
        var diamond = new Diamond('D');

        diamond
            .ToString()
            .Should()
            .Be(
                "   A   " + Environment.NewLine +
                "  B B  " + Environment.NewLine +
                " C   C " + Environment.NewLine +
                "D     D" + Environment.NewLine +
                " C   C " + Environment.NewLine +
                "  B B  " + Environment.NewLine +
                "   A   ");
    }
    
    [Fact]
    public void Diamond_X_ShouldPrintDiamond()
    {
        var diamond = new Diamond('X');

        diamond
            .ToString()
            .Should()
            .Be(
                "                       A                       " + Environment.NewLine +
                "                      B B                      " + Environment.NewLine +
                "                     C   C                     " + Environment.NewLine +
                "                    D     D                    " + Environment.NewLine +
                "                   E       E                   " + Environment.NewLine +
                "                  F         F                  " + Environment.NewLine +
                "                 G           G                 " + Environment.NewLine +
                "                H             H                " + Environment.NewLine +
                "               I               I               " + Environment.NewLine +
                "              J                 J              " + Environment.NewLine +
                "             K                   K             " + Environment.NewLine +
                "            L                     L            " + Environment.NewLine +
                "           M                       M           " + Environment.NewLine +
                "          N                         N          " + Environment.NewLine +
                "         O                           O         " + Environment.NewLine +
                "        P                             P        " + Environment.NewLine +
                "       Q                               Q       " + Environment.NewLine +
                "      R                                 R      " + Environment.NewLine +
                "     S                                   S     " + Environment.NewLine +
                "    T                                     T    " + Environment.NewLine +
                "   U                                       U   " + Environment.NewLine +
                "  V                                         V  " + Environment.NewLine +
                " W                                           W " + Environment.NewLine +
                "X                                             X" + Environment.NewLine +
                " W                                           W " + Environment.NewLine +
                "  V                                         V  " + Environment.NewLine +
                "   U                                       U   " + Environment.NewLine +
                "    T                                     T    " + Environment.NewLine +
                "     S                                   S     " + Environment.NewLine +
                "      R                                 R      " + Environment.NewLine +
                "       Q                               Q       " + Environment.NewLine +
                "        P                             P        " + Environment.NewLine +
                "         O                           O         " + Environment.NewLine +
                "          N                         N          " + Environment.NewLine +
                "           M                       M           " + Environment.NewLine +
                "            L                     L            " + Environment.NewLine +
                "             K                   K             " + Environment.NewLine +
                "              J                 J              " + Environment.NewLine +
                "               I               I               " + Environment.NewLine +
                "                H             H                " + Environment.NewLine +
                "                 G           G                 " + Environment.NewLine +
                "                  F         F                  " + Environment.NewLine +
                "                   E       E                   " + Environment.NewLine +
                "                    D     D                    " + Environment.NewLine +
                "                     C   C                     " + Environment.NewLine +
                "                      B B                      " + Environment.NewLine +
                "                       A                       ");
    }
    
    [Fact]
    public void Diamond_Y_ShouldPrintDiamond()
    {
        var diamond = new Diamond('Y');

        diamond
            .ToString()
            .Should()
            .Be(
                "                        A                        " + Environment.NewLine +
                "                       B B                       " + Environment.NewLine +
                "                      C   C                      " + Environment.NewLine +
                "                     D     D                     " + Environment.NewLine +
                "                    E       E                    " + Environment.NewLine +
                "                   F         F                   " + Environment.NewLine +
                "                  G           G                  " + Environment.NewLine +
                "                 H             H                 " + Environment.NewLine +
                "                I               I                " + Environment.NewLine +
                "               J                 J               " + Environment.NewLine +
                "              K                   K              " + Environment.NewLine +
                "             L                     L             " + Environment.NewLine +
                "            M                       M            " + Environment.NewLine +
                "           N                         N           " + Environment.NewLine +
                "          O                           O          " + Environment.NewLine +
                "         P                             P         " + Environment.NewLine +
                "        Q                               Q        " + Environment.NewLine +
                "       R                                 R       " + Environment.NewLine +
                "      S                                   S      " + Environment.NewLine +
                "     T                                     T     " + Environment.NewLine +
                "    U                                       U    " + Environment.NewLine +
                "   V                                         V   " + Environment.NewLine +
                "  W                                           W  " + Environment.NewLine +
                " X                                             X " + Environment.NewLine +
                "Y                                               Y" + Environment.NewLine +
                " X                                             X " + Environment.NewLine +
                "  W                                           W  " + Environment.NewLine +
                "   V                                         V   " + Environment.NewLine +
                "    U                                       U    " + Environment.NewLine +
                "     T                                     T     " + Environment.NewLine +
                "      S                                   S      " + Environment.NewLine +
                "       R                                 R       " + Environment.NewLine +
                "        Q                               Q        " + Environment.NewLine +
                "         P                             P         " + Environment.NewLine +
                "          O                           O          " + Environment.NewLine +
                "           N                         N           " + Environment.NewLine +
                "            M                       M            " + Environment.NewLine +
                "             L                     L             " + Environment.NewLine +
                "              K                   K              " + Environment.NewLine +
                "               J                 J               " + Environment.NewLine +
                "                I               I                " + Environment.NewLine +
                "                 H             H                 " + Environment.NewLine +
                "                  G           G                  " + Environment.NewLine +
                "                   F         F                   " + Environment.NewLine +
                "                    E       E                    " + Environment.NewLine +
                "                     D     D                     " + Environment.NewLine +
                "                      C   C                      " + Environment.NewLine +
                "                       B B                       " + Environment.NewLine +
                "                        A                        ");
    }
    
    [Fact]
    public void Diamond_Z_ShouldPrintDiamond()
    {
        var diamond = new Diamond('Z');

        diamond
            .ToString()
            .Should()
            .Be(
                "                         A                         " + Environment.NewLine +
                "                        B B                        " + Environment.NewLine +
                "                       C   C                       " + Environment.NewLine +
                "                      D     D                      " + Environment.NewLine +
                "                     E       E                     " + Environment.NewLine +
                "                    F         F                    " + Environment.NewLine +
                "                   G           G                   " + Environment.NewLine +
                "                  H             H                  " + Environment.NewLine +
                "                 I               I                 " + Environment.NewLine +
                "                J                 J                " + Environment.NewLine +
                "               K                   K               " + Environment.NewLine +
                "              L                     L              " + Environment.NewLine +
                "             M                       M             " + Environment.NewLine +
                "            N                         N            " + Environment.NewLine +
                "           O                           O           " + Environment.NewLine +
                "          P                             P          " + Environment.NewLine +
                "         Q                               Q         " + Environment.NewLine +
                "        R                                 R        " + Environment.NewLine +
                "       S                                   S       " + Environment.NewLine +
                "      T                                     T      " + Environment.NewLine +
                "     U                                       U     " + Environment.NewLine +
                "    V                                         V    " + Environment.NewLine +
                "   W                                           W   " + Environment.NewLine +
                "  X                                             X  " + Environment.NewLine +
                " Y                                               Y " + Environment.NewLine +
                "Z                                                 Z" + Environment.NewLine +
                " Y                                               Y " + Environment.NewLine +
                "  X                                             X  " + Environment.NewLine +
                "   W                                           W   " + Environment.NewLine +
                "    V                                         V    " + Environment.NewLine +
                "     U                                       U     " + Environment.NewLine +
                "      T                                     T      " + Environment.NewLine +
                "       S                                   S       " + Environment.NewLine +
                "        R                                 R        " + Environment.NewLine +
                "         Q                               Q         " + Environment.NewLine +
                "          P                             P          " + Environment.NewLine +
                "           O                           O           " + Environment.NewLine +
                "            N                         N            " + Environment.NewLine +
                "             M                       M             " + Environment.NewLine +
                "              L                     L              " + Environment.NewLine +
                "               K                   K               " + Environment.NewLine +
                "                J                 J                " + Environment.NewLine +
                "                 I               I                 " + Environment.NewLine +
                "                  H             H                  " + Environment.NewLine +
                "                   G           G                   " + Environment.NewLine +
                "                    F         F                    " + Environment.NewLine +
                "                     E       E                     " + Environment.NewLine +
                "                      D     D                      " + Environment.NewLine +
                "                       C   C                       " + Environment.NewLine +
                "                        B B                        " + Environment.NewLine +
                "                         A                         ");
    }
}