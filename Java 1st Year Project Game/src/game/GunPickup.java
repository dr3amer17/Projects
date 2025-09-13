package game;
import city.cs.engine.*;
/**
 * The GunPickup class represents a gun that the Hero can collect.
 * When picked up, it allows the Hero to shoot bullets at enemies.
 */
public class GunPickup extends StaticBody {
    private static final Shape gunShape = new BoxShape(0.5f, 0.25f);

    public GunPickup(World world) {
        super(world, gunShape);
        addImage(new BodyImage("data/gun.png", 0.5f));
    }
}
