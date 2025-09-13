package game;

import city.cs.engine.*;
import org.jbox2d.common.Vec2;

/**
 * Handles all collision events in the game.
 * Controls interactions such as:
 * - Hero losing HP when touching enemies
 * - Hero picking up guns and healing potions
 * - Bullets hitting enemies and destroying them
 */
public class Collisions implements CollisionListener {

    // Reference to the Hero involved in the collisions
    private Hero hero;

    /**
     * @param hero The hero to apply collision effects to.
     */
    public Collisions(Hero hero) {
        this.hero = hero;
    }

    /**
     * Handles collision events between different game objects.
     * @param e The collision event that occurred.
     */
    @Override
    public void collide(CollisionEvent e) {
        //  Hero touches Enemy, lose HP
        if (e.getReportingBody() instanceof Hero && e.getOtherBody() instanceof Enemy) {
            hero.decreaseHp(50);
            System.out.println("Hero HP: " + hero.getHp());
        }

        //  Hero touches GunPickup, pickup gun
        if (e.getOtherBody() instanceof GunPickup) {
            System.out.println("Picked up a gun!");
            hero.setHasGun(true);
            e.getOtherBody().destroy(); // Remove gun pickup after use
        }

        //  Hero touches HealingPotion, heal
        if (e.getOtherBody() instanceof HealingPotion) {
            if (hero.getHp() < 100) {
                System.out.println("Picked up healing potion!");
                hero.increaseHp(30);
                if (hero.getHp() > 100) {
                    hero.setHp(100); // Cap health at 100
                }
                e.getOtherBody().destroy(); // Remove potion after use
            } else {
                System.out.println("Hero already at full health. Potion not picked up.");
            }
        }

        // Bullet touches Enemy, destroy both
        if (e.getReportingBody() instanceof Bullet && e.getOtherBody() instanceof Enemy) {
            System.out.println("Enemy hit by bullet!");

            Bullet bullet = (Bullet) e.getReportingBody();
            Enemy enemy = (Enemy) e.getOtherBody();

            enemy.destroy(); // Destroy enemy
            bullet.destroy(); // Destroy bullet

            GameWorld world = (GameWorld) enemy.getWorld();
            world.removeEnemy(enemy); // Update enemy count
        }
    }
}
