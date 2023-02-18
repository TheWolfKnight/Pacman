
using Pacman.Src.Entity;

namespace Pacman.Src.Enemy;

public class Inky : EntityDescriptor {

  public Inky() : base(0, 0, new SpriteDescriptor('\"', 0xFF0000FF)) {}
}

public class Pinky : EntityDescriptor {

  public Pinky() : base(0, 0, new SpriteDescriptor('\"', 0xFF0022FF)) {}

}

public class Blinky : EntityDescriptor {

  public Blinky() : base(0, 0, new SpriteDescriptor('\"', 0x00FF00FF)) {}

}

public class Bly : EntityDescriptor {

  public Bly() : base(0, 0, new SpriteDescriptor('\"', 0x0000FFFF)) {}

}
