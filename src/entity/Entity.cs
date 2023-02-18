
namespace Pacman.Src.Entity;

public class EntityDescriptor {

  public int X, Y;
  public SpriteDescriptor Sprite;

  /// <summary>
  /// Constructs a new Entity instance
  /// </summary>
  /// <param name="x"> The starting value for the X position </param>
  /// <param name="y"> The starting value for the Y position </param>
  /// <param name="sprite"> The description of how the sprite should be renderd </param>
  public EntityDescriptor(int x, int y, SpriteDescriptor sprite) {
    X = x;
    Y = y;
    Sprite = sprite;
  }

  /// <summary>
  /// 
  /// </summary>
  public virtual void Show() {
    System.Console.Write(Sprite.Display);
  }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="x"></param>
  /// <param name="y"></param>
  public virtual void Update(int x, int y) {
    X = x;
    Y = y;
  }
}

public record SpriteDescriptor(char Display, UInt32 color);
