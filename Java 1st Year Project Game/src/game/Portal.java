package game;

import city.cs.engine.*;

/**
 * The Portal class represents a portal that the Hero can use to travel to another level.
 */
public class Portal extends StaticBody {
    private static final Shape portalShape = new BoxShape(1f, 2f);
    private static final BodyImage portalImage = new BodyImage("data/portal.png", 4f);

    public Portal(World world) {
        super(world, portalShape);
        addImage(portalImage);
    }
}
