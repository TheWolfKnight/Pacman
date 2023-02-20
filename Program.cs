
namespace Pacman;

public class Program {

  public static char[,] Board = new char[,] {
  };

  static void Main(string[] args) {

    while (true) {
      break;
    }

  }

  static void Setup() {
    throw new NotImplementedException();
  }

}

public struct Entity {
  char Display;
  UInt32 Color;
  UInt16 Position;

  public Entity(char display, UInt32 color, byte x, byte y) {
    Display = display;
    Color = color;

    // Encodes the position into a 16 bit variable
    // Format: first 8: Y, last 8: X
    Position += y;
    Position <<= 8;
    Position += x;
  }

  public byte GetXPosition() {
    const UInt16 X_MASK = 0x00FF;

    // Position -> UInt16:
    // Y:    10011000 X: 01110100
    // Mask: 00000000    11111111
    // &
    //       00000000    01110100
    // (byte)
    //                   01110100

    return (byte)(Position & X_MASK);
  }

  public byte GetYPosition() {
    const UInt16 Y_MASK = 0xFF00;

    // Position -> UInt16:
    // Y:    10011000 X: 01110100
    // Mask: 11111111    00000000
    // &
    //       10011000    00000000
    // >> 8
    //       00000000    10011000
    // (byte)
    //                   10011000

    return (byte)((Position & Y_MASK) >> 8);
  }

  public void Update(byte x, byte y) {
    // Clear the Postion field by shifting the bytes out of
    // memory.
    Position <<= 16;

    Position += y;
    Position <<= 8;
    Position += x;
  }

}

public enum Tiles {
}
