package game;

import city.cs.engine.*;

/**
 * The PortalListener class handles collisions between the Hero and the Portal.
 */
public class PortalListener implements CollisionListener {
    private Game game;

    public PortalListener(Game game) {
        this.game = game;
    }

    @Override
    public void collide(CollisionEvent e) {
        if (e.getOtherBody() instanceof Hero) {
            System.out.println("Level complete! Switching level...");
            game.goToNextLevel();
        }
    }
}
